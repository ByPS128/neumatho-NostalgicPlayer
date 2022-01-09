﻿/******************************************************************************/
/* This source, or parts thereof, may be used in any software as long the     */
/* license of NostalgicPlayer is keep. See the LICENSE file for more          */
/* information.                                                               */
/*                                                                            */
/* Copyright (C) 2021-2022 by Polycode / NostalgicPlayer team.                */
/* All rights reserved.                                                       */
/******************************************************************************/
namespace Polycode.NostalgicPlayer.Agent.SampleConverter.Iff8Svx
{
	/// <summary>
	/// Base class for all the formats
	/// </summary>
	internal abstract class Iff8SvxWorkerBase
	{
		/********************************************************************/
		/// <summary>
		/// Return the format ID
		/// </summary>
		/********************************************************************/
		protected abstract Format FormatId { get; }
	}
}
