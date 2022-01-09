﻿/******************************************************************************/
/* This source, or parts thereof, may be used in any software as long the     */
/* license of NostalgicPlayer is keep. See the LICENSE file for more          */
/* information.                                                               */
/*                                                                            */
/* Copyright (C) 2021-2022 by Polycode / NostalgicPlayer team.                */
/* All rights reserved.                                                       */
/******************************************************************************/
namespace Polycode.NostalgicPlayer.Agent.Player.Ahx
{
	/// <summary>
	/// Holds different tables
	/// </summary>
	internal static class Tables
	{
		/// <summary>
		/// White noise
		/// </summary>
		public static readonly byte[] WhiteNoiseTable =
		{
			0x7f, 0x7f, 0xa8, 0xe2, 0x78, 0x3e, 0x2c, 0x92, 0x52, 0xd5, 0x80, 0x80, 0xab, 0x80, 0x7f, 0x37,
			0x7f, 0x7f, 0x15, 0x3b, 0xbc, 0x66, 0xf3, 0x7f, 0x80, 0x80, 0x80, 0x80, 0x42, 0xe5, 0xf8, 0x80,
			0x7f, 0x7f, 0x26, 0x7f, 0x80, 0x97, 0x80, 0x5f, 0xa7, 0x7f, 0x80, 0x80, 0x80, 0x7f, 0x7f, 0x7f,
			0xce, 0x79, 0x8c, 0x80, 0x4a, 0x7f, 0x80, 0x16, 0x7f, 0x7f, 0x80, 0x80, 0x09, 0xf1, 0x80, 0x95,
			0x78, 0x78, 0x7f, 0xb8, 0xe2, 0x52, 0x7f, 0x08, 0x93, 0x7f, 0x7f, 0x80, 0xfb, 0xa8, 0x44, 0xe5,
			0xca, 0x09, 0x7f, 0x80, 0x7f, 0x80, 0xcb, 0x80, 0x7f, 0xf7, 0x80, 0x80, 0xb7, 0x7f, 0x5b, 0x80,
			0x3b, 0x14, 0xcf, 0x80, 0x7f, 0x80, 0x16, 0x1f, 0x67, 0xa1, 0x62, 0x71, 0x71, 0xa7, 0x7f, 0x44,
			0x41, 0x80, 0x7f, 0xcd, 0x41, 0x43, 0x4b, 0xf3, 0x80, 0xc7, 0xdf, 0xdf, 0xd5, 0x27, 0x1f, 0x1f,
			0x9f, 0x36, 0x24, 0x73, 0x71, 0x7f, 0x80, 0x7f, 0x79, 0x42, 0x7f, 0x7f, 0x80, 0x80, 0x80, 0x2e,
			0x22, 0x7f, 0xf2, 0x46, 0x80, 0x80, 0xb4, 0xd2, 0x35, 0x2e, 0x80, 0x8f, 0xb5, 0xbc, 0x80, 0x38,
			0xf2, 0x7f, 0x10, 0x2d, 0x7f, 0x7f, 0x26, 0x91, 0x7f, 0xf0, 0x7f, 0xdf, 0x2b, 0x7f, 0x80, 0x3e,
			0x7f, 0x7f, 0x80, 0x80, 0xab, 0xae, 0x7f, 0xca, 0x80, 0x80, 0xf3, 0xba, 0x34, 0x80, 0x80, 0x7f,
			0x7f, 0x80, 0x3e, 0x66, 0x80, 0x17, 0x80, 0xab, 0x80, 0x09, 0xf3, 0x7f, 0x29, 0x80, 0xc4, 0x7f,
			0x80, 0xd3, 0x7f, 0xba, 0x80, 0x7f, 0x80, 0x9d, 0x7f, 0x80, 0x38, 0x80, 0x7f, 0x7f, 0x7f, 0x69,
			0x7f, 0x7f, 0x15, 0x4f, 0x80, 0x7c, 0x8c, 0x1b, 0x7f, 0x7f, 0x80, 0x80, 0x70, 0x2b, 0x80, 0x7f,
			0x5a, 0xc1, 0x7f, 0x80, 0x7f, 0x45, 0xbb, 0x80, 0x7f, 0xf7, 0xce, 0x80, 0x80, 0x80, 0xda, 0x9d,
			0x7f, 0x80, 0x7f, 0xba, 0xe2, 0x02, 0x80, 0x95, 0xba, 0x80, 0xfa, 0xfe, 0x80, 0xb4, 0x80, 0x80,
			0x88, 0x7f, 0x7f, 0x12, 0x80, 0x80, 0x0e, 0x9b, 0x80, 0x80, 0x4f, 0xc9, 0x2b, 0x80, 0x77, 0xb5,
			0x7f, 0x51, 0x7f, 0x7f, 0x7f, 0x7f, 0x80, 0x7f, 0xf1, 0x80, 0x31, 0xe6, 0x80, 0x7f, 0x80, 0xa5,
			0x80, 0x7f, 0xca, 0x7f, 0x25, 0x80, 0x92, 0xb4, 0x7f, 0x80, 0x97, 0x7f, 0x7f, 0x94, 0x20, 0x1b,
			0x3b, 0x7f, 0xee, 0xca, 0x80, 0x80, 0x42, 0x80, 0x80, 0xa3, 0x80, 0xc5, 0xf1, 0x80, 0x7f, 0x7f,
			0x7f, 0x51, 0xaf, 0x7f, 0x35, 0x42, 0x80, 0x7f, 0xf1, 0x80, 0xc5, 0x7f, 0x7f, 0x7f, 0x80, 0x28,
			0x7f, 0xb3, 0x2c, 0x2c, 0xea, 0x7f, 0x7f, 0x80, 0x7f, 0x21, 0xa9, 0x7f, 0x34, 0x7f, 0xae, 0x1e,
			0xc5, 0xbf, 0xae, 0x7f, 0x8b, 0x37, 0x7f, 0x0d, 0x80, 0x73, 0x23, 0xbb, 0x80, 0x80, 0xc6, 0x80,
			0xb6, 0x80, 0x7f, 0x80, 0x80, 0x7f, 0x7f, 0x80, 0x21, 0x7f, 0x20, 0x45, 0xa7, 0xca, 0x7f, 0x80,
			0x80, 0x80, 0x3d, 0x7f, 0x15, 0x45, 0xf3, 0xd8, 0x8b, 0x9b, 0xce, 0x55, 0x80, 0x80, 0x7f, 0xbd,
			0xce, 0x7f, 0x36, 0x80, 0x7f, 0xbf, 0x62, 0x23, 0x07, 0x25, 0xf1, 0xca, 0x59, 0x7f, 0xaa, 0x7f,
			0x7f, 0x47, 0x93, 0x80, 0x1b, 0x21, 0x80, 0x9b, 0xca, 0x80, 0x2d, 0x80, 0x98, 0x7f, 0x7f, 0x7f,
			0xee, 0x80, 0x80, 0x80, 0x7f, 0x20, 0x3b, 0x80, 0x3c, 0x22, 0xcf, 0x7f, 0x80, 0x80, 0x59, 0x9d,
			0x7f, 0x2a, 0x7f, 0x80, 0x7c, 0x80, 0xd3, 0x21, 0x80, 0xa7, 0x7f, 0x7f, 0x80, 0x09, 0x3d, 0x7f,
			0x7f, 0xae, 0x80, 0xa7, 0x80, 0x7f, 0x73, 0x05, 0x3d, 0x80, 0x7f, 0x7f, 0x7f, 0x26, 0x3b, 0x7f,
			0xf6, 0x80, 0x7f, 0x5e, 0x47, 0xdf, 0x80, 0x7c, 0x36, 0x36, 0x7f, 0xff, 0xbc, 0xbc, 0xbc, 0x7f,
			0x7f, 0x7f, 0x80, 0x80, 0x4d, 0x21, 0x7f, 0x7f, 0x7f, 0x41, 0x4d, 0x80, 0x7f, 0x7f, 0x80, 0xc0,
			0xaf, 0x2c, 0x7f, 0x17, 0x35, 0x80, 0x80, 0x7f, 0xf0, 0x3c, 0x12, 0x87, 0x7f, 0x80, 0x80, 0x13,
			0x73, 0x2d, 0x3e, 0x80, 0x7f, 0x80, 0xa6, 0xd8, 0x19, 0x80, 0x7f, 0x27, 0x80, 0x7f, 0x80, 0x7f,
			0x80, 0x7f, 0x23, 0x80, 0x4d, 0x80, 0x7f, 0x7f, 0x89, 0x7f, 0x80, 0xb5, 0x4a, 0x17, 0xaf, 0x88,
			0x95, 0x80, 0x70, 0x77, 0x97, 0x7f, 0x80, 0x80, 0x22, 0x9b, 0x02, 0x2f, 0x80, 0x80, 0x98, 0x7f,
			0x7f, 0x12, 0x2d, 0x28, 0xce, 0xaf, 0x90, 0x58, 0xe9, 0x1a, 0x71, 0x2f, 0x5c, 0x7f, 0x80, 0x7f,
			0x7f, 0x80, 0x7f, 0x47, 0xcd, 0xaf, 0x2c, 0x06, 0x80, 0x2f, 0x80, 0xe8, 0x80, 0x2e, 0x58, 0x11,
			0xd7, 0xad, 0x58, 0x43, 0x17, 0x9f, 0x70, 0xc3, 0x80, 0x70, 0x19, 0xc3, 0x37, 0x2e, 0x42, 0x80,
			0x2c, 0xbc, 0x80, 0x7f, 0x7f, 0x7f, 0x10, 0x45, 0x2d, 0x3e, 0x3e, 0x90, 0x80, 0xa6, 0xd8, 0x5b,
			0x80, 0x7f, 0x27, 0x80, 0x7f, 0x80, 0x33, 0x80, 0x75, 0x80, 0x7f, 0x7f, 0x94, 0x80, 0x21, 0xf1,
			0x7f, 0xee, 0x7f, 0xae, 0xf6, 0xae, 0x80, 0x41, 0x80, 0xa5, 0x7f, 0x40, 0x7f, 0x8a, 0x3d, 0x12,
			0xdd, 0x7f, 0x9e, 0x7f, 0x92, 0x36, 0x66, 0x19, 0x80, 0x80, 0xa7, 0xa0, 0x90, 0x80, 0x5f, 0x23,
			0x57, 0x80, 0x31, 0x80, 0x2d, 0x36, 0xa0, 0xd2, 0x8f, 0xd9, 0x3f, 0x80, 0x3e, 0x80, 0x29, 0xd8,
			0xad, 0x7f, 0x7f, 0x51, 0xbb, 0x70, 0xcb, 0xb5, 0xdc, 0x3d, 0xc2, 0xb7, 0x7f, 0xba, 0x80, 0x3e,
			0x80, 0x7f, 0x3b, 0x44, 0x80, 0xa6, 0x7f, 0x80, 0x80, 0x7c, 0x80, 0x61, 0x7f, 0xca, 0x7f, 0x7f,
			0x80, 0xff, 0x34, 0x7f, 0x46, 0x05, 0x7f, 0x24, 0x7f, 0x7f, 0x7f, 0x7f, 0xbc, 0x7f, 0x7f, 0x7f,
			0x80, 0x7f, 0x15, 0x7f, 0xce, 0xe5, 0x7f, 0x80, 0x7f, 0xbd, 0x58, 0x85, 0x33, 0x7f, 0x7e, 0x80,
			0x80, 0x80, 0x7f, 0x7f, 0x80, 0x7f, 0xf7, 0x32, 0x94, 0x40, 0x73, 0x7f, 0x7f, 0xee, 0xdc, 0x7f,
			0x24, 0x7f, 0x7f, 0xba, 0xc6, 0x27, 0x21, 0x95, 0x80, 0x3d, 0xa4, 0x80, 0x7f, 0x7f, 0x80, 0x7f,
			0x7f, 0x94, 0x7f, 0x7f, 0x94, 0x80, 0x61, 0x7f, 0x80, 0x7f, 0x7f, 0x79, 0x80, 0x42, 0x7f, 0xbe,
			0x80, 0x80, 0xc2, 0x43, 0xf7, 0xac, 0xac, 0x80, 0x7f, 0x7f, 0x7f, 0x80, 0x14, 0x7f, 0x15, 0x7f,
			0xc2, 0x1d, 0x7f, 0x80, 0x7f, 0xbb, 0x80, 0x80, 0x80, 0x80, 0xb6, 0x7f, 0x7f, 0x44, 0x7f, 0x09,
			0x07, 0x80, 0x7f, 0x80, 0x7f, 0x7f, 0x96, 0x7f, 0xce, 0x80, 0x80, 0x61, 0x65, 0x80, 0x2d, 0x4a,
			0x7f, 0x7f, 0x80, 0x7f, 0x46, 0x80, 0x7f, 0xaa, 0x44, 0x80, 0xcb, 0x89, 0x7f, 0x80, 0x7f, 0x80,
			0x7f, 0x8e, 0x9f, 0x80, 0xc3, 0x43, 0x71, 0x99, 0x80, 0x7f, 0x47, 0x41, 0xaf, 0x80, 0x3b, 0xb6,
			0x7f, 0x72, 0x80, 0xd1, 0x80, 0x7f, 0x44, 0x80, 0x2f, 0x7f, 0x7f, 0x42, 0x80, 0x7f, 0xf0, 0x7f,
			0x45, 0x7f, 0x80, 0x7f, 0x80, 0xc0, 0xaf, 0x7f, 0x9c, 0x1e, 0x35, 0x7f, 0xca, 0x65, 0xf1, 0x3c,
			0x92, 0xb4, 0xa0, 0x80, 0x7f, 0x7f, 0x0f, 0xd7, 0x73, 0x80, 0x0e, 0x80, 0x7f, 0x80, 0x7c, 0xca,
			0xc7, 0xad, 0x80, 0x80, 0x3d, 0x9e, 0xf0, 0x82, 0x8d, 0xd9, 0x19, 0x7f, 0x93, 0x7f, 0x80, 0x80,
			0x80, 0x98, 0x80, 0x80, 0x7f, 0x3b, 0x28, 0xce, 0x09, 0x7f, 0x5e, 0xe9, 0x80, 0x80, 0x7f, 0x45,
			0x80, 0xfa, 0x7f, 0x7f, 0x80, 0x7f, 0x80, 0x7f, 0x7f, 0x11, 0x80, 0xb4, 0x2c, 0x80, 0x13, 0x7f,
			0x80, 0x80, 0xc5, 0x7f, 0x7f, 0xee, 0x82, 0x80, 0x80, 0x41, 0x80, 0x11, 0x7f, 0x80, 0xc1, 0x7f,
			0xad, 0x7f, 0x7f, 0x7f, 0x81, 0xf1, 0x80, 0x31, 0xa0, 0x80, 0x7f, 0x7f, 0x25, 0x57, 0x7f, 0xc4,
			0x80, 0x2d, 0x36, 0x7f, 0xbd, 0x80, 0xd9, 0x7f, 0xbb, 0x7f, 0x80, 0x2f, 0x7f, 0x36, 0x80, 0x3e,
			0x58, 0x80, 0x80, 0x41, 0x5f, 0x80, 0x22, 0x80, 0x80, 0xcc, 0x7f, 0x7f, 0x24, 0xc5, 0x29, 0xe6,
			0xc4, 0x7f, 0x80, 0xd1, 0x80, 0x3a, 0x0c, 0xa1, 0x80, 0xb7, 0x7f, 0xbe, 0x80, 0x14, 0x95, 0x80,
			0xf3, 0x7f, 0x89, 0x80, 0xc1, 0x7f, 0x80, 0x7f, 0x7f, 0xa8, 0x1e, 0xc3, 0x43, 0x21, 0x80, 0x80,
			0x7f, 0x47, 0xcd, 0x7b, 0x80, 0x3b, 0x80, 0x7f, 0x25, 0x80, 0xd1, 0x27, 0x89, 0x7f, 0x80, 0x28,
			0xa4, 0x90, 0x7f, 0x59, 0x7f, 0x24, 0x7f, 0xb1, 0x5c, 0x7f, 0xbf, 0x7f, 0x7f, 0x80, 0x16, 0x80,
			0xdb, 0x80, 0x7f, 0x80, 0x7f, 0x7f, 0xf5, 0xb2, 0x7f, 0x7f, 0x80, 0x7f, 0x0f, 0x80, 0x80, 0x80,
			0x77, 0x80, 0x2e, 0x80, 0x3c, 0xa0, 0x7f, 0x2b, 0x7f, 0x68, 0x80, 0xc0, 0x7f, 0x7f, 0x7f, 0x10,
			0xb5, 0x7f, 0xca, 0x11, 0x91, 0x80, 0x95, 0x7f, 0x7f, 0x7f, 0x7f, 0x80, 0x80, 0xcb, 0x80, 0x7f,
			0x81, 0x7f, 0xac, 0xaa, 0x7f, 0x7f, 0x80, 0x93, 0x3a, 0xc0, 0x80, 0x80, 0x98, 0x52, 0x80, 0x7f,
			0xe1, 0xa8, 0xdc, 0x85, 0xb3, 0x76, 0x7f, 0xba, 0x80, 0x7f, 0xa3, 0x80, 0xb4, 0x80, 0xc6, 0x21,
			0x7f, 0x0f, 0x7f, 0x7f, 0x80, 0x09, 0x7f, 0x7f, 0x7f, 0xa1, 0xf8, 0x7f, 0xa3, 0x7f, 0x26, 0x80,
			0xc3, 0x80, 0x41, 0x2b, 0x7f, 0x7f, 0x80, 0xc1, 0x55, 0x7f, 0x7f, 0x7f, 0xaf, 0x80, 0x80, 0x80,
			0x31, 0x80, 0x7f, 0x7f, 0xbf, 0x52, 0x39, 0x66, 0x73, 0xf7, 0x5c, 0xe9, 0x80, 0x7f, 0x7f, 0x42,
			0x55, 0x80, 0x80, 0x92, 0x7f, 0x7f, 0x80, 0x97, 0x7f, 0x15, 0x80, 0x23, 0x1b, 0xbb, 0x9a, 0x80,
			0x80, 0x80, 0xb6, 0x28, 0xbe, 0x80, 0x7f, 0x0f, 0xeb, 0xf0, 0x80, 0x5f, 0xc9, 0x21, 0x6b, 0x7f,
			0x4c, 0x80, 0x7f, 0xad, 0xc4, 0xc1, 0x7f, 0x96, 0x7f, 0x7f, 0xaf, 0x7f, 0xe1, 0x9e, 0x80, 0x7f,
			0xb3, 0xf6, 0x80, 0x80, 0x80, 0x80, 0xab, 0xf0, 0x80, 0x80, 0xfa, 0x3a, 0x7f, 0x80, 0x80, 0x89,
			0x7f, 0x08, 0x7f, 0x80, 0x7f, 0x80, 0xfa, 0x44, 0x8f, 0x09, 0x7f, 0x80, 0x7f, 0x80, 0x80, 0x22,
			0x9b, 0x7f, 0xb8, 0x80, 0x7f, 0x7f, 0x80, 0x7f, 0x15, 0x2d, 0x7f, 0x7f, 0x7f, 0x95, 0x58, 0x93,
			0x7f, 0xf0, 0xe2, 0xdc, 0x7f, 0x15, 0x7f, 0x80, 0x7f, 0x81, 0x7f, 0xf2, 0x94, 0x80, 0x80, 0x7f,
			0x80, 0x7f, 0xce, 0x80, 0x80, 0x80, 0x80, 0x80, 0x9b, 0x80, 0x3f, 0xa2, 0x80, 0x98, 0x02, 0x7f,
			0x20, 0x29, 0xa8, 0x78, 0x7f, 0x44, 0x69, 0x11, 0x7f, 0xca, 0x41, 0x4d, 0x17, 0x7f, 0x7f, 0x80,
			0x80, 0x70, 0xf7, 0x7f, 0xfc, 0x80, 0x80, 0x7f, 0xce, 0x7f, 0x80, 0x80, 0x4a, 0x1d, 0x80, 0x4d,
			0x7f, 0x80, 0x7f, 0xf2, 0x80, 0xfe, 0x80, 0x80, 0xec, 0x62, 0x7f, 0x7f, 0xff, 0x80, 0xcb, 0x80,
			0x7f, 0x80, 0xc0, 0x7f, 0x80, 0x4e, 0x21, 0x35, 0x0c, 0xaf, 0xb2, 0x7f, 0x80, 0x3e, 0xf0, 0x96,
			0xac, 0x7f, 0x2b, 0xea, 0x80, 0x80, 0x80, 0x80, 0xa0, 0x7f, 0x44, 0x7f, 0x7f, 0x6d, 0xc7, 0x7f,
			0x24, 0x80, 0x2a, 0x7f, 0x80, 0x3c, 0x80, 0xec, 0x7f, 0x80, 0xe8, 0x80, 0xa4, 0x2a, 0x3e, 0x56,
			0x80, 0x80, 0xd3, 0xdb, 0xb5, 0xc0, 0x80, 0x7f, 0xaf, 0x14, 0x35, 0x80, 0x38, 0x7f, 0x96, 0x7f,
			0x7f, 0x68, 0x7f, 0x7f, 0x41, 0x7f, 0x44, 0x7f, 0x80, 0xc7, 0xc7, 0x80, 0x80, 0x80, 0x14, 0x80,
			0x7f, 0x7f, 0xdc, 0x1d, 0x7f, 0x7f, 0x7f, 0xbf, 0x80, 0x5c, 0x80, 0x77, 0xf7, 0xc0, 0xc1, 0x80,
			0x23, 0x59, 0x80, 0x80, 0x7f, 0xad, 0xdc, 0x7f, 0x8a, 0x89, 0x7f, 0xba, 0x7f, 0x7f, 0x80, 0xa9,
			0x80, 0x80, 0x7f, 0x4b, 0x91, 0x7f, 0x4c, 0x7f, 0x44, 0xaf, 0x7f, 0x7f, 0x80, 0x7f, 0x7f, 0xb8,
			0x80, 0x3c, 0x7f, 0x3b, 0x7f, 0x80, 0xe8, 0x80, 0x7f, 0x7a, 0x2c, 0x56, 0x80, 0x7f, 0x80, 0xe8,
			0x7f, 0x7f, 0x17, 0x3f, 0x7f, 0xd8, 0x05, 0x73, 0xdf, 0x2d, 0xb4, 0x80, 0x7f, 0x95, 0x80, 0x8c,
			0x7f, 0x7f, 0xe3, 0x80, 0x09, 0x25, 0x7f, 0x7f, 0x7f, 0x7f, 0xaa, 0x7f, 0x15, 0xc3, 0xaf, 0xba,
			0x80, 0x80, 0x2c, 0xf0, 0xba, 0x7f, 0x7f, 0x68, 0x7f, 0x7f, 0x7f, 0x17, 0x4f, 0x85, 0x80, 0x80,
			0x70, 0x7f, 0x9b, 0x62, 0x2d, 0x80, 0x80, 0x9b, 0x80, 0x80, 0x95, 0x80, 0x98, 0x7f, 0xf7, 0x7f,
			0x36, 0x80, 0x80, 0x80, 0x7f, 0x27, 0x80, 0x7f, 0xca, 0x27, 0x80, 0x0e, 0x80, 0x3a, 0x80, 0x80,
			0x31, 0xf0, 0x7f, 0x94, 0xb2, 0x52, 0x7f, 0x80, 0x80, 0x88, 0x5d, 0x05, 0xa3, 0x14, 0x91, 0x80,
			0xcc, 0x7f, 0x80, 0x7f, 0x7f, 0x80, 0x80, 0x7f, 0x80, 0x7f, 0x7f, 0x4c, 0x7f, 0xf6, 0x7f, 0x7f,
			0x80, 0xa4, 0x7f, 0x7f, 0x95, 0x7f, 0x24, 0x7f, 0xf7, 0x62, 0x7f, 0x80, 0x21, 0x7f, 0x44, 0x7f,
			0x43, 0x4d, 0xcb, 0x80, 0x7f, 0x80, 0xc0, 0x80, 0x7f, 0x7f, 0x12, 0x35, 0x24, 0x4b, 0x93, 0x90,
			0x80, 0x80, 0xc7, 0x2b, 0x80, 0x3b, 0x08, 0x7f, 0x5e, 0x7f, 0x51, 0x80, 0xa1, 0xb2, 0x80, 0x7f,
			0xae, 0x80, 0x7f, 0x5a, 0x4b, 0xf7, 0x80, 0x80, 0xc2, 0x7f, 0x80, 0x80, 0x92, 0x34, 0x80, 0x95,
			0xac, 0x80, 0xa7, 0x7f, 0x7f, 0x11, 0x3b, 0x3c, 0x7f, 0x80, 0x7f, 0x80, 0xe8, 0x66, 0x7f, 0x7f,
			0x17, 0xd7, 0xa3, 0x3a, 0x80, 0x70, 0x80, 0x80, 0x7f, 0x7f, 0x80, 0x80, 0x80, 0x5c, 0x2d, 0x80,
			0x17, 0x7f, 0x7f, 0x80, 0x38, 0x80, 0xab, 0x7f, 0x0f, 0x80, 0x7f, 0x80, 0x80, 0xc8, 0xf1, 0xaa,
			0x7f, 0x7f, 0x80, 0x7f, 0x7f, 0x80, 0x4f, 0xa7, 0xc4, 0x80, 0x02, 0x37, 0x80, 0x3d, 0x80, 0x7f,
			0x7f, 0xb8, 0x7f, 0x80, 0x2f, 0x14, 0x13, 0x80, 0x38, 0x80, 0x7f, 0xf0, 0x7f, 0x68, 0x7f, 0x59,
			0xe9, 0x2a, 0xce, 0x7b, 0x5c, 0x80, 0xec, 0x7f, 0x7f, 0x7f, 0xf8, 0x80, 0x80, 0x88, 0x2d, 0x7f,
			0x43, 0x13, 0x91, 0xd8, 0x80, 0xc4, 0x7f, 0x3b, 0x7f, 0x80, 0x80, 0xcb, 0x80, 0x80, 0x80, 0x7f,
			0xac, 0x7f, 0x26, 0x7f, 0x80, 0x80, 0xd9, 0x27, 0x1b, 0x7f, 0x7a, 0x34, 0x7f, 0x80, 0x7f, 0x7f,
			0x7f, 0x0c, 0x7f, 0x7f, 0x7f, 0x80, 0x7f, 0x80, 0x17, 0x80, 0x6e, 0x80, 0x76, 0x80, 0x80, 0x5f,
			0xa1, 0xa0, 0x9e, 0x7f, 0x4d, 0x55, 0xd5, 0x19, 0x7f, 0x7f, 0x7f, 0x80, 0x13, 0xe7, 0x2c, 0x2c
		};

		/// <summary>
		/// Vibrato table
		/// </summary>
		public static readonly int[] VibratoTable =
		{
			0, 24, 49, 74, 97, 120, 141, 161, 180, 197, 212, 224, 235, 244, 250, 253, 255,
			253, 250, 244, 235, 224, 212, 197, 180, 161, 141, 120, 97, 74, 49, 24,
			0, -24, -49, -74, -97, -120, -141, -161, -180, -197, -212, -224, -235, -244, -250, -253, -255,
			-253, -250, -244, -235, -224, -212, -197, -180, -161, -141, -120, -97, -74, -49, -24
		};

		/// <summary>
		/// Periods
		/// </summary>
		public static readonly int[] PeriodTable =
		{
			0x0000, 0x0d60, 0x0ca0, 0x0be8, 0x0b40, 0x0a98, 0x0a00, 0x0970,
			0x08e8, 0x0868, 0x07f0, 0x0780, 0x0714, 0x06b0, 0x0650, 0x05f4,
			0x05a0, 0x054c, 0x0500, 0x04b8, 0x0474, 0x0434, 0x03f8, 0x03c0,
			0x038a, 0x0358, 0x0328, 0x02fa, 0x02d0, 0x02a6, 0x0280, 0x025c,
			0x023a, 0x021a, 0x01fc, 0x01e0, 0x01c5, 0x01ac, 0x0194, 0x017d,
			0x0168, 0x0153, 0x0140, 0x012e, 0x011d, 0x010d, 0x00fe, 0x00f0,
			0x00e2, 0x00d6, 0x00ca, 0x00be, 0x00b4, 0x00aa, 0x00a0, 0x0097,
			0x008f, 0x0087, 0x007f, 0x0078, 0x0071
		};

		/// <summary>
		/// Waveform offset table
		/// </summary>
		public static readonly int[] OffsetTable =
		{
			0x00, 0x04, 0x04 + 0x08, 0x04 + 0x08 + 0x10, 0x04 + 0x08 + 0x10 + 0x20, 0x04 + 0x08 + 0x10 + 0x20 + 0x40
		};
	}
}
