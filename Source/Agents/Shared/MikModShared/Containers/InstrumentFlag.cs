﻿/******************************************************************************/
/* This source, or parts thereof, may be used in any software as long the     */
/* license of NostalgicPlayer is keep. See the LICENSE file for more          */
/* information.                                                               */
/*                                                                            */
/* Copyright (C) 2021-2022 by Polycode / NostalgicPlayer team.                */
/* All rights reserved.                                                       */
/******************************************************************************/
using System;

namespace Polycode.NostalgicPlayer.Agent.Shared.MikMod.Containers
{
	/// <summary>
	/// Instrument flags (IF_)
	/// </summary>
	[Flags]
	public enum InstrumentFlag : byte
	{
		/// <summary></summary>
		None = 0,

		/// <summary></summary>
		OwnPan = 1,
		/// <summary></summary>
		PitchPan = 2
	}
}
