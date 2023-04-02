﻿/******************************************************************************/
/* This source, or parts thereof, may be used in any software as long the     */
/* license of NostalgicPlayer is keep. See the LICENSE file for more          */
/* information.                                                               */
/******************************************************************************/
using System.Linq;
using Polycode.NostalgicPlayer.Kit.Interfaces;

namespace Polycode.NostalgicPlayer.Agent.Player.ModTracker.Containers
{
	/// <summary>
	/// Holds all the information about the player state at a specific time
	/// </summary>
	internal class Snapshot : ISnapshot
	{
		public GlobalPlayingInfo PlayingInfo;
		public ModChannel[] Channels;

		/********************************************************************/
		/// <summary>
		/// Constructor
		/// </summary>
		/********************************************************************/
		public Snapshot(GlobalPlayingInfo playingInfo, ModChannel[] channels)
		{
			PlayingInfo = playingInfo.MakeDeepClone();
			Channels = channels.Select(x => x.MakeDeepClone()).ToArray();
		}
	}
}
