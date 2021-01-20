﻿/******************************************************************************/
/* This source, or parts thereof, may be used in any software as long the     */
/* license of NostalgicPlayer is keep. See the LICENSE file for more          */
/* information.                                                               */
/*                                                                            */
/* Copyright (C) 2021 by Polycode / NostalgicPlayer team.                     */
/* All rights reserved.                                                       */
/******************************************************************************/
using System;

namespace Polycode.NostalgicPlayer.Kit.Encoders
{
	/// <summary>
	/// This class can decode the Amiga character set
	/// </summary>
	internal class Amiga : EncoderBase
	{
		/********************************************************************/
		/// <summary>
		/// Return the encoder name
		/// </summary>
		/********************************************************************/
		public override string EncodingName
		{
			get
			{
				return "Amiga";
			}
		}



		/********************************************************************/
		/// <summary>
		/// Single byte encoding
		/// </summary>
		/********************************************************************/
		public override bool IsSingleByte
		{
			get
			{
				return true;
			}
		}



		/********************************************************************/
		/// <summary>
		/// Return the number of bytes needed to encode the given characters
		/// </summary>
		/********************************************************************/
		public override int GetByteCount(char[] chars, int index, int count)
		{
			ValidateArguments(chars, index, count);

			return count;
		}



		/********************************************************************/
		/// <summary>
		/// Encode the given characters into the given buffer
		/// </summary>
		/********************************************************************/
		public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
		{
			ValidateArguments(chars, charIndex, charCount);
			ValidateArguments(bytes, byteIndex, 0);

			if ((charCount + byteIndex) < bytes.Length)
				throw new ArgumentException("Resulting byte array is too short");

			for (; charIndex < charCount; charIndex++, byteIndex++)
				bytes[byteIndex] = GetByteFromMultiTable(chars[charIndex], highByteIndexTable);

			return charCount;
		}



		/********************************************************************/
		/// <summary>
		/// Return the number of characters needed to decode the given bytes
		/// </summary>
		/********************************************************************/
		public override int GetCharCount(byte[] bytes, int index, int count)
		{
			ValidateArguments(bytes, index, count);

			int needed = 0;
			while ((count > 0) && (bytes[index] != 0x00))
			{
				index++;
				count--;
				needed++;
			}

			return needed;
		}



		/********************************************************************/
		/// <summary>
		/// Decode the given bytes into the given buffer
		/// </summary>
		/********************************************************************/
		public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			ValidateArguments(bytes, byteIndex, byteCount);
			ValidateArguments(chars, charIndex, 0);

			int taken = 0;
			for (; byteIndex < byteCount; byteIndex++, charIndex++, taken++)
			{
				// Stop with null terminator
				if (bytes[byteIndex] == 0x00)
					break;

				chars[charIndex] = (char)lookupTable[bytes[byteIndex]];
			}

			return taken;
		}



		/********************************************************************/
		/// <summary>
		/// Return the max number of bytes needed
		/// </summary>
		/********************************************************************/
		public override int GetMaxByteCount(int charCount)
		{
			return charCount;
		}



		/********************************************************************/
		/// <summary>
		/// Return the max number of characters needed
		/// </summary>
		/********************************************************************/
		public override int GetMaxCharCount(int byteCount)
		{
			return byteCount;
		}



		/********************************************************************/
		/// <summary>
		/// Validates the arguments
		/// </summary>
		/********************************************************************/
		private void ValidateArguments(Array array, int index, int count)
		{
			if (array == null)
				throw new ArgumentNullException(nameof(array));

			if (index < 0)
				throw new ArgumentException("Negative index", nameof(index));

			if (count < 0)
				throw new ArgumentException("Negative index", nameof(count));

			if ((index + count) > array.Length)
				throw new ArgumentException("Index + count bigger than character array");
		}

		#region Lookup tables
		/********************************************************************/
		// The tables below holds the Amiga codes. This are the ISO/DIS
		// 6429.2 and ANSI X3.64-1979 8-bit standard
		/********************************************************************/

		/********************************************************************/
		/// <summary>
		/// Character values for each byte
		///
		/// Undefined values: 0x80 - 0x9f
		/// </summary>
		/********************************************************************/
		private static readonly ushort[] lookupTable =
		{
			// 0x00 - 0x1f
			0x0000, 0x0001, 0x0002, 0x0003, 0x0004, 0x0005, 0x0006, 0x0007,
			0x0008, 0x0009, 0x000a, 0x000b, 0x000c, 0x000d, 0x000e, 0x000f,
			0x0010, 0x0011, 0x0012, 0x0013, 0x0014, 0x0015, 0x0016, 0x0017,
			0x0018, 0x0019, 0x001a, 0x001b, 0x001c, 0x001d, 0x001e, 0x001f,

			// 0x20 - 0x3f
			0x0020, 0x0021, 0x0022, 0x0023, 0x0024, 0x0025, 0x0026, 0x0027,
			0x0028, 0x0029, 0x002a, 0x002b, 0x002c, 0x002d, 0x002e, 0x002f,
			0x0030, 0x0031, 0x0032, 0x0033, 0x0034, 0x0035, 0x0036, 0x0037,
			0x0038, 0x0039, 0x003a, 0x003b, 0x003c, 0x003d, 0x003e, 0x003f,

			// 0x40 - 0x5f
			0x0040, 0x0041, 0x0042, 0x0043, 0x0044, 0x0045, 0x0046, 0x0047,
			0x0048, 0x0049, 0x004a, 0x004b, 0x004c, 0x004d, 0x004e, 0x004f,
			0x0050, 0x0051, 0x0052, 0x0053, 0x0054, 0x0055, 0x0056, 0x0057,
			0x0058, 0x0059, 0x005a, 0x005b, 0x005c, 0x005d, 0x005e, 0x005f,

			// 0x60 - 0x7f
			0x0060, 0x0061, 0x0062, 0x0063, 0x0064, 0x0065, 0x0066, 0x0067,
			0x0068, 0x0069, 0x006a, 0x006b, 0x006c, 0x006d, 0x006e, 0x006f,
			0x0070, 0x0071, 0x0072, 0x0073, 0x0074, 0x0075, 0x0076, 0x0077,
			0x0078, 0x0079, 0x007a, 0x007b, 0x007c, 0x007d, 0x007e, 0x007f,

			// 0x80 - 0x9f
			0x003f, 0x003f, 0x003f, 0x003f, 0x003f, 0x003f, 0x003f, 0x003f,
			0x003f, 0x003f, 0x003f, 0x003f, 0x003f, 0x003f, 0x003f, 0x003f,
			0x003f, 0x003f, 0x003f, 0x003f, 0x003f, 0x003f, 0x003f, 0x003f,
			0x003f, 0x003f, 0x003f, 0x003f, 0x003f, 0x003f, 0x003f, 0x003f,

			// 0xa0 - 0xbf
			0x00a0, 0x00a1, 0x00a2, 0x00a3, 0x00a4, 0x00a5, 0x00a6, 0x00a7,
			0x00a8, 0x00a9, 0x00aa, 0x00ab, 0x00ac, 0x00ad, 0x00ae, 0x00af,
			0x00b0, 0x00b1, 0x00b2, 0x00b3, 0x00b4, 0x00b5, 0x00b6, 0x00b7,
			0x00b8, 0x00b9, 0x00ba, 0x00bb, 0x00bc, 0x00bd, 0x00be, 0x00bf,

			// 0xc0 - 0xdf
			0x00c0, 0x00c1, 0x00c2, 0x00c3, 0x00c4, 0x00c5, 0x00c6, 0x00c7,
			0x00c8, 0x00c9, 0x00ca, 0x00cb, 0x00cc, 0x00cd, 0x00ce, 0x00cf,
			0x00d0, 0x00d1, 0x00d2, 0x00d3, 0x00d4, 0x00d5, 0x00d6, 0x00d7,
			0x00d8, 0x00d9, 0x00da, 0x00db, 0x00dc, 0x00dd, 0x00de, 0x00df,

			// 0xe0 - 0xff
			0x00e0, 0x00e1, 0x00e2, 0x00e3, 0x00e4, 0x00e5, 0x00e6, 0x00e7,
			0x00e8, 0x00e9, 0x00ea, 0x00eb, 0x00ec, 0x00ed, 0x00ee, 0x00ef,
			0x00f0, 0x00f1, 0x00f2, 0x00f3, 0x00f4, 0x00f5, 0x00f6, 0x00f7,
			0x00f8, 0x00f9, 0x00fa, 0x00fb, 0x00fc, 0x00fd, 0x00fe, 0x00ff
		};



		/********************************************************************/
		/// <summary>
		/// High-byte 0x00 char table
		/// </summary>
		/********************************************************************/
		private static readonly byte[] byte00Table =
		{
			// 0x0000 - 0x001f
			0x00, 0x01, 0x02, 0x03,	0x04, 0x05, 0x06, 0x07,
			0x08, 0x09, 0x0a, 0x0b,	0x0c, 0x0d, 0x0e, 0x0f,
			0x10, 0x11, 0x12, 0x13,	0x14, 0x15, 0x16, 0x17,
			0x18, 0x19, 0x1a, 0x1b,	0x1c, 0x1d, 0x1e, 0x1f,

			// 0x0020 - 0x003f
			0x20, 0x21, 0x22, 0x23,	0x24, 0x25, 0x26, 0x27,
			0x28, 0x29, 0x2a, 0x2b,	0x2c, 0x2d, 0x2e, 0x2f,
			0x30, 0x31, 0x32, 0x33,	0x34, 0x35, 0x36, 0x37,
			0x38, 0x39, 0x3a, 0x3b,	0x3c, 0x3d, 0x3e, 0x3f,

			// 0x0040 - 0x005f
			0x40, 0x41, 0x42, 0x43,	0x44, 0x45, 0x46, 0x47,
			0x48, 0x49, 0x4a, 0x4b,	0x4c, 0x4d, 0x4e, 0x4f,
			0x50, 0x51, 0x52, 0x53,	0x54, 0x55, 0x56, 0x57,
			0x58, 0x59, 0x5a, 0x5b,	0x5c, 0x5d, 0x5e, 0x5f,

			// 0x0060 - 0x007f
			0x60, 0x61, 0x62, 0x63,	0x64, 0x65, 0x66, 0x67,
			0x68, 0x69, 0x6a, 0x6b,	0x6c, 0x6d, 0x6e, 0x6f,
			0x70, 0x71, 0x72, 0x73,	0x74, 0x75, 0x76, 0x77,
			0x78, 0x79, 0x7a, 0x7b,	0x7c, 0x7d, 0x7e, 0x7f,

			// 0x0080 - 0x009f
			0x3f, 0x3f, 0x3f, 0x3f, 0x3f, 0x3f, 0x3f, 0x3f,
			0x3f, 0x3f, 0x3f, 0x3f, 0x3f, 0x3f, 0x3f, 0x3f,
			0x3f, 0x3f, 0x3f, 0x3f, 0x3f, 0x3f, 0x3f, 0x3f,
			0x3f, 0x3f, 0x3f, 0x3f, 0x3f, 0x3f, 0x3f, 0x3f,

			// 0x00a0 - 0x00bf
			0xa0, 0xa1, 0xa2, 0xa3,	0xa4, 0xa5, 0xa6, 0xa7,
			0xa8, 0xa9, 0xaa, 0xab,	0xac, 0xad, 0xae, 0xaf,
			0xb0, 0xb1, 0xb2, 0xb3,	0xb4, 0xb5, 0xb6, 0xb7,
			0xb8, 0xb9, 0xba, 0xbb,	0xbc, 0xbd, 0xbe, 0xbf,

			// 0x00c0 - 0x00df
			0xc0, 0xc1, 0xc2, 0xc3,	0xc4, 0xc5, 0xc6, 0xc7,
			0xc8, 0xc9, 0xca, 0xcb,	0xcc, 0xcd, 0xce, 0xcf,
			0xd0, 0xd1, 0xd2, 0xd3,	0xd4, 0xd5, 0xd6, 0xd7,
			0xd8, 0xd9, 0xda, 0xdb,	0xdc, 0xdd, 0xde, 0xdf,

			// 0x00e0 - 0x00ff
			0xe0, 0xe1, 0xe2, 0xe3, 0xe4, 0xe5, 0xe6, 0xe7,
			0xe8, 0xe9, 0xea, 0xeb,	0xec, 0xed, 0xee, 0xef,
			0xf0, 0xf1, 0xf2, 0xf3,	0xf4, 0xf5, 0xf6, 0xf7,
			0xf8, 0xf9, 0xfa, 0xfb, 0xfc, 0xfd, 0xfe, 0xff
		};



		/********************************************************************/
		/// <summary>
		/// High-byte index table
		/// </summary>
		/********************************************************************/
		private static readonly byte[][] highByteIndexTable =
		{
			byte00Table, null, null, null, null, null, null, null,
			null, null, null, null, null, null, null, null,
			null, null, null, null, null, null, null, null,
			null, null, null, null, null, null, null, null,
			null, null, null, null, null, null, null, null,
			null, null, null, null, null, null, null, null,
			null, null, null, null, null, null, null, null,
			null, null, null, null, null, null, null, null,
			null, null, null, null, null, null, null, null,
			null, null, null, null, null, null, null, null,
			null, null, null, null, null, null, null, null,
			null, null, null, null, null, null, null, null,
			null, null, null, null, null, null, null, null,
			null, null, null, null, null, null, null, null,
			null, null, null, null, null, null, null, null,
			null, null, null, null, null, null, null, null,
			null, null, null, null, null, null, null, null,
			null, null, null, null, null, null, null, null,
			null, null, null, null, null, null, null, null,
			null, null, null, null, null, null, null, null,
			null, null, null, null, null, null, null, null,
			null, null, null, null, null, null, null, null,
			null, null, null, null, null, null, null, null,
			null, null, null, null, null, null, null, null,
			null, null, null, null, null, null, null, null,
			null, null, null, null, null, null, null, null,
			null, null, null, null, null, null, null, null,
			null, null, null, null, null, null, null, null,
			null, null, null, null, null, null, null, null,
			null, null, null, null, null, null, null, null,
			null, null, null, null, null, null, null, null,
			null, null, null, null, null, null, null, null
		};
		#endregion
	}
}
