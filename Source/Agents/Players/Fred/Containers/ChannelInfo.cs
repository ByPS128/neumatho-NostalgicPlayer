﻿/******************************************************************************/
/* This source, or parts thereof, may be used in any software as long the     */
/* license of NostalgicPlayer is keep. See the LICENSE file for more          */
/* information.                                                               */
/*                                                                            */
/* Copyright (C) 2021 by Polycode / NostalgicPlayer team.                     */
/* All rights reserved.                                                       */
/******************************************************************************/
namespace Polycode.NostalgicPlayer.Agent.Player.Fred.Containers
{
	/// <summary>
	/// Channel information
	/// </summary>
	internal class ChannelInfo
	{
		public int ChanNum;
		public sbyte[] PositionTable;
		public byte[] TrackTable;
		public ushort Position;
		public ushort TrackPosition;
		public ushort TrackDuration;
		public byte TrackNote;
		public ushort TrackPeriod;
		public short TrackVolume;
		public Instrument Instrument;
		public VibFlags VibFlags;
		public byte VibDelay;
		public sbyte VibSpeed;
		public sbyte VibAmpl;
		public sbyte VibValue;
		public bool PortRunning;
		public ushort PortDelay;
		public ushort PortLimit;
		public byte PortTargetNote;
		public ushort PortStartPeriod;
		public short PeriodDiff;
		public ushort PortCounter;
		public ushort PortSpeed;
		public EnvelopeState EnvState;
		public byte SustainDelay;
		public byte ArpPosition;
		public byte ArpSpeed;
		public bool PulseWay;
		public byte PulsePosition;
		public byte PulseDelay;
		public byte PulseSpeed;
		public byte PulseShot;
		public bool BlendWay;
		public ushort BlendPosition;
		public byte BlendDelay;
		public byte BlendShot;
		public sbyte[] SynthSample;
	}
}
