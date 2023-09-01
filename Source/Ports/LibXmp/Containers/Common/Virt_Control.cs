﻿/******************************************************************************/
/* This source, or parts thereof, may be used in any software as long the     */
/* license of NostalgicPlayer is keep. See the LICENSE file for more          */
/* information.                                                               */
/******************************************************************************/
using Polycode.NostalgicPlayer.Ports.LibXmp.Containers.Mixer;

namespace Polycode.NostalgicPlayer.Ports.LibXmp.Containers.Common
{
	/// <summary>
	/// 
	/// </summary>
	internal class Virt_Control
	{
		/// <summary>
		/// Number of tracks
		/// </summary>
		public c_int Num_Tracks;

		/// <summary>
		/// Number of virtual channels
		/// </summary>
		public c_int Virt_Channels;

		/// <summary>
		/// Number of voices currently in use
		/// </summary>
		public c_int Virt_Used;

		/// <summary>
		/// Number of sound card voices
		/// </summary>
		public c_int MaxVoc;

		public Virt_Channel[] Virt_Channel;

		public Mixer_Voice[] Voice_Array;
	}
}
