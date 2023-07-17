﻿/******************************************************************************/
/* This source, or parts thereof, may be used in any software as long the     */
/* license of NostalgicPlayer is keep. See the LICENSE file for more          */
/* information.                                                               */
/******************************************************************************/
using System;
using Polycode.NostalgicPlayer.Kit.Bases;
using Polycode.NostalgicPlayer.Kit.Containers;
using Polycode.NostalgicPlayer.Kit.Interfaces;
using Polycode.NostalgicPlayer.Kit.Streams;

namespace Polycode.NostalgicPlayer.Agent.Player.Sample
{
	/// <summary>
	/// Main worker class
	/// </summary>
	internal class SampleWorker : SamplePlayerWithDurationAgentBase
	{
		private readonly ISampleLoaderAgent loaderAgent;

		private LoadSampleFormatInfo formatInfo;

		private long totalLength;

		/********************************************************************/
		/// <summary>
		/// Constructor
		/// </summary>
		/********************************************************************/
		public SampleWorker(AgentInfo agentInfo)
		{
			loaderAgent = (ISampleLoaderAgent)agentInfo.Agent.CreateInstance(agentInfo.TypeId);
		}

		#region IPlayerAgent implementation
		/********************************************************************/
		/// <summary>
		/// Returns the file extensions that identify this player
		/// </summary>
		/********************************************************************/
		public override string[] FileExtensions => loaderAgent.FileExtensions;



		/********************************************************************/
		/// <summary>
		/// Test the file to see if it could be identified
		/// </summary>
		/********************************************************************/
		public override AgentResult Identify(PlayerFileInfo fileInfo)
		{
			return loaderAgent.Identify(fileInfo.ModuleStream);
		}



		/********************************************************************/
		/// <summary>
		/// Return the name of the module
		/// </summary>
		/********************************************************************/
		public override string ModuleName => formatInfo.Name;



		/********************************************************************/
		/// <summary>
		/// Return the name of the author
		/// </summary>
		/********************************************************************/
		public override string Author => formatInfo.Author;



		/********************************************************************/
		/// <summary>
		/// Return all pictures available
		/// </summary>
		/********************************************************************/
		public override PictureInfo[] Pictures => formatInfo.Pictures;



		/********************************************************************/
		/// <summary>
		/// Returns the description and value on the line given. If the line
		/// is out of range, false is returned
		/// </summary>
		/********************************************************************/
		public override bool GetInformationString(int line, out string description, out string value)
		{
			if (line >= 3)
				return loaderAgent.GetInformationString(line - 3, out description, out value);

			// Find out which line to take
			switch (line)
			{
				// Bit size
				case 0:
				{
					description = Resources.IDS_SAMPLE_INFODESCLINE0;
					value = formatInfo.Bits.ToString();
					break;
				}

				// Frequency
				case 1:
				{
					description = Resources.IDS_SAMPLE_INFODESCLINE1;
					value = formatInfo.Frequency.ToString();
					break;
				}

				// Looping
				case 2:
				{
					description = Resources.IDS_SAMPLE_INFODESCLINE2;
					value = (formatInfo.Flags & LoadSampleFormatInfo.SampleFlag.Loop) != 0 ? Resources.IDS_SAMPLE_YES : Resources.IDS_SAMPLE_NO;
					break;
				}

				default:
				{
					description = null;
					value = null;

					return false;
				}
			}

			return true;
		}
		#endregion

		#region ISamplePlayerAgent implementation
		/********************************************************************/
		/// <summary>
		/// Will load the header information from the file
		/// </summary>
		/********************************************************************/
		public override AgentResult LoadHeaderInfo(ModuleStream moduleStream, out string errorMessage)
		{
			// Start to initialize the converter
			if (!loaderAgent.InitLoader(out errorMessage))
				return AgentResult.Error;

			// Load the header
			if (!loaderAgent.LoadHeader(moduleStream, out formatInfo, out errorMessage))
				return AgentResult.Error;

			return AgentResult.Ok;
		}



		/********************************************************************/
		/// <summary>
		/// Initializes the player
		/// </summary>
		/********************************************************************/
		public override bool InitPlayer(ModuleStream moduleStream, out string errorMessage)
		{
			if (!base.InitPlayer(moduleStream, out errorMessage))
				return false;

			// Get number of samples of the file
			totalLength = loaderAgent.GetTotalSampleLength(formatInfo);

			return true;
		}



		/********************************************************************/
		/// <summary>
		/// Cleanup the player
		/// </summary>
		/********************************************************************/
		public override void CleanupPlayer()
		{
			loaderAgent.CleanupLoader();

			base.CleanupPlayer();
		}



		/********************************************************************/
		/// <summary>
		/// Initializes the player to start the sample from start
		/// </summary>
		/********************************************************************/
		public override bool InitSound(out string errorMessage)
		{
			if (!base.InitSound(out errorMessage))
				return false;

			// Reset the sample position
			loaderAgent.SetSamplePosition(modStream, 0, formatInfo);

			return true;
		}



		/********************************************************************/
		/// <summary>
		/// Will load and decode a data block and store it in the buffer
		/// given
		/// </summary>
		/********************************************************************/
		public override int LoadDataBlock(int[] outputBuffer, int count)
		{
			// Load the next block of data
			int filled = loaderAgent.LoadData(modStream, outputBuffer, count, formatInfo);

			if (filled == 0)
			{
				OnEndReached();

				// Loop the sample
				if ((formatInfo.Flags & LoadSampleFormatInfo.SampleFlag.Loop) != 0)
					loaderAgent.SetSamplePosition(modStream, formatInfo.LoopStart, formatInfo);
				else
					loaderAgent.SetSamplePosition(modStream, 0, formatInfo);
			}

			return filled;
		}



		/********************************************************************/
		/// <summary>
		/// Return the number of channels the sample uses
		/// </summary>
		/********************************************************************/
		public override int ChannelCount => formatInfo.Channels;



		/********************************************************************/
		/// <summary>
		/// Return the frequency the sample is stored with
		/// </summary>
		/********************************************************************/
		public override int Frequency => formatInfo.Frequency;
		#endregion

		#region SamplePlayerWithDurationAgentBase
		/********************************************************************/
		/// <summary>
		/// Return the total time of the sample
		/// </summary>
		/********************************************************************/
		protected override TimeSpan GetTotalDuration()
		{
			if (totalLength == 0)
				return TimeSpan.Zero;

			// Calculate the total time
			long totalTime = totalLength * 1000 / formatInfo.Frequency / formatInfo.Channels;

			return new TimeSpan(totalTime * TimeSpan.TicksPerMillisecond);
		}



		/********************************************************************/
		/// <summary>
		/// Set the position in the playing sample to the time given
		/// </summary>
		/********************************************************************/
		protected override void SetPosition(TimeSpan time)
		{
			long newPos = (int)(formatInfo.Frequency * time.TotalSeconds) * formatInfo.Channels;
			loaderAgent.SetSamplePosition(modStream, newPos, formatInfo);
		}
		#endregion
	}
}
