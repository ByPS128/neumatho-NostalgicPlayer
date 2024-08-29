﻿/******************************************************************************/
/* This source, or parts thereof, may be used in any software as long the     */
/* license of NostalgicPlayer is keep. See the LICENSE file for more          */
/* information.                                                               */
/******************************************************************************/
using System;

namespace Polycode.NostalgicPlayer.Ports.ReSidFp.Resample
{
	/// <summary>
	/// This is the theoretically correct (and computationally intensive) audio sample generation.
	/// The samples are generated by resampling to the specified sampling frequency.
	/// The work rate is inversely proportional to the percentage of the bandwidth
	/// allocated to the filter transition band.
	///
	/// This implementation is based on the paper "A Flexible Sampling-Rate Conversion Method",
	/// by J. O. Smith and P. Gosset, or rather on the expanded tutorial on the
	/// [Digital Audio Resampling Home Page](http://www-ccrma.stanford.edu/~jos/resample/).
	///
	/// By building shifted FIR tables with samples according to the sampling frequency,
	/// this implementation dramatically reduces the computational effort in the
	/// filter convolutions, without any loss of accuracy.
	/// The filter convolutions are also vectorizable on current hardware
	/// </summary>
	internal sealed class SincResampler : Resampler
	{
		/// <summary>
		/// Maximum error acceptable in I0 is 1e-6, or ~96 dB
		/// </summary>
		private const double I0E = 1e-6;

		/// <summary>
		/// Size of the ring buffer, must be a power of 2
		/// </summary>
		private const int RingSize = 2048;

		private const int Bits = 16;

		/// <summary>
		/// Table of the fir filter coefficients
		/// </summary>
		private matrix_t firTable;

		private int sampleIndex = 0;

		/// <summary>
		/// Filter resolution
		/// </summary>
		private int firRes;

		/// <summary>
		/// Filter length
		/// </summary>
		private int firN;

		private readonly int cyclesPerSample;
		private int sampleOffset = 0;
		private int outputValue = 0;
		private readonly int[] sample = new int[RingSize * 2];

		/********************************************************************/
		/// <summary>
		/// Constructor
		///
		/// Use a clock freqency of 985248Hz for PAL C64, 1022730Hz for NTSC
		/// C64. The default end of passband frequency is
		/// pass_freq = 0.9*sample_freq/2 for sample frequencies up to
		/// ~ 44.1kHz, and 20kHz for higher sample frequencies.
		///
		/// For resampling, the ratio between the clock frequency and the
		/// sample frequency is limited as follows:
		/// 125*clock_freq/sample_freq &lt; 16384
		/// E.g. provided a clock frequency of ~ 1MHz, the sample frequency
		/// can not be set lower than ~ 8kHz.
		/// A lower sample frequency would make the resampling code overfill
		/// its 16k sample ring buffer.
		///
		/// The end of passband frequency is also limited:
		/// pass_freq &lt;= 0.9*sample_freq/2
		///
		/// E.g. for a 44.1kHz sampling rate the end of passband frequency is
		/// limited to slightly below 20kHz. This constraint ensures that
		/// the FIR table is not overfilled
		/// </summary>
		/********************************************************************/
		public SincResampler(double clockFrequency, double samplingFrequency, double highestAccurateFrequency)
		{
			cyclesPerSample = (int)(clockFrequency / samplingFrequency * 1024.0);

			// 16-bits -> -96dB stopband attenuation
			double a = -20.0 * Math.Log10(1.0 / (1 << Bits));

			// A fraction of the bandwidth is allocated to the transition band, which we double
			// because we design the filter to transition halfway at nyquist
			double dw = (1.0 - 2.0 * highestAccurateFrequency / samplingFrequency) * Math.PI * 2.0;

			// For calculation of beta and N see the reference for the kaiserord
			// function in the MATLAB Signal Processing Toolbox:
			// http://www.mathworks.com/help/signal/ref/kaiserord.html
			double beta = 0.1102 * (a - 8.7);
			double i0Beta = I0(beta);
			double cyclesPerSampleD = clockFrequency / samplingFrequency;
			double inv_CyclesPerSampleD = samplingFrequency / clockFrequency;

			{
				// The filter order will maximally be 124 with the current constraints.
				// N >= (96.33 - 7.95)/(2 * pi * 2.285 * (maxfreq - passbandfreq) >= 123
				// The filter order is equal to the number of zero crossings, i.e.
				// it should be an even number (sinc is symmetric with respect to x = 0)
				int n = (int)((a - 7.95) / (2.285 * dw) + 0.5);
				n += n & 1;

				// The filter length is equal to the filter order + 1.
				// The filter length must be an odd number (sinc is symmetric with respect to
				// x = 0)
				firN = (int)(n * cyclesPerSampleD) + 1;
				firN |= 1;

				// Error is bounded by err < 1.234 / L^2, so L = sqrt(1.234 / (2^-16)) = sqrt(1.234 * 2^16)
				firRes = (int)(Math.Ceiling(Math.Sqrt(1.234 * (1 << Bits)) * inv_CyclesPerSampleD));

				// firN*firRES represent the total resolution of the sinc sampling. JOS
				// recommends a length of 2^BITS, but we don't quite use that good a filter.
				// The filter test program indicates that the filter performs well, though
			}

			// Allocate memory for FIR tables
			firTable = new matrix_t((uint)firRes, (uint)firN);

			// The cutoff frequency is midway through the transition band, in effect the same as nyquist
			double wc = Math.PI;

			// Calculate the sinc tables
			double scale = 32768.0 * wc * inv_CyclesPerSampleD / Math.PI;

			// We're not interested in the fractional part
			// so use int division before converting to double
			int tmp = firN / 2;
			double firN2 = tmp;

			for (int i = 0; i < firRes; i++)
			{
				double jPhase = (double)i / firRes + firN2;

				for (int j = 0; j < firN; j++)
				{
					double x = j - jPhase;

					double xt = x / firN2;
					double kaiserXt = Math.Abs(xt) < 1.0 ? I0(beta * Math.Sqrt(1.0 - xt * xt)) / i0Beta : 0.0;

					double wt = wc * x * inv_CyclesPerSampleD;
					double sincWt = Math.Abs(wt) >= 1e-8 ? Math.Sin(wt) / wt : 1.0;

					firTable[(uint)i][j] = (short)(scale * sincWt * kaiserXt);
				}
			}
		}

		#region Overrides
		/********************************************************************/
		/// <summary>
		/// 
		/// </summary>
		/********************************************************************/
		public override bool Input(int input)
		{
			bool ready = false;

			sample[sampleIndex] = sample[sampleIndex + RingSize] = input;
			sampleIndex = (sampleIndex + 1) & (RingSize - 1);

			if (sampleOffset < 1024)
			{
				outputValue = Fir(sampleOffset);
				ready = true;
				sampleOffset += cyclesPerSample;
			}

			sampleOffset -= 1024;

			return ready;
		}



		/********************************************************************/
		/// <summary>
		/// 
		/// </summary>
		/********************************************************************/
		public override int Output()
		{
			return outputValue;
		}



		/********************************************************************/
		/// <summary>
		/// 
		/// </summary>
		/********************************************************************/
		public override void Reset()
		{
			System.Array.Clear(sample, 0, sample.Length);
			sampleOffset = 0;
		}
		#endregion

		#region Private methods
		/********************************************************************/
		/// <summary>
		/// Compute the 0th order modified Bessel function of the first kind.
		/// This function is originally from resample-1.5/filterkit.c by
		/// J. O. Smith. It is used to build the Kaiser window for resampling
		/// </summary>
		/********************************************************************/
		private double I0(double x)
		{
			double sum = 1.0;
			double u = 1.0;
			double n = 1.0;
			double halfX = x / 2.0;

			do
			{
				double temp = halfX / n;
				u *= temp * temp;
				sum += u;
				n += 1.0;
			}
			while (u >= I0E * sum);

			return sum;
		}



		/********************************************************************/
		/// <summary>
		/// 
		/// </summary>
		/********************************************************************/
		private int Fir(int subCycle)
		{
			// Find the first of the nearest fir tables close to the phase
			int firTableFirst = (subCycle * firRes >> 10);
			int firTableOffset = (subCycle * firRes) & 0x3ff;

			// Find firN most recent samples, plus one extra in case the FIR wraps
			int sampleStart = sampleIndex - firN + RingSize - 1;

			int v1 = Convolve(sampleStart, firTable[(uint)firTableFirst], firN);

			// Use next FIR table, wrap around to first FIR table using
			// previous sample
			if (++firTableFirst == firRes)
			{
				firTableFirst = 0;
				++sampleStart;
			}

			int v2 = Convolve(sampleStart, firTable[(uint)firTableFirst], firN);

			// Linear interpolation between the sinc tables yields good
			// approximation for the exact value
			return v1 + (firTableOffset * (v2 - v1) >> 10);
		}



		/********************************************************************/
		/// <summary>
		/// Calculate convolution with sample and sinc
		/// </summary>
		/********************************************************************/
		private int Convolve(int a, short[] b, int bLength)
		{
			int @out = 0;

			for (int i = 0; i < bLength; i++)
				@out += sample[a + i] * b[i];

			return (@out + (1 << 14)) >> 15;
		}
		#endregion
	}
}
