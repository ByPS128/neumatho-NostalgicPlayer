﻿/******************************************************************************/
/* This source, or parts thereof, may be used in any software as long the     */
/* license of NostalgicPlayer is keep. See the LICENSE file for more          */
/* information.                                                               */
/******************************************************************************/
namespace Polycode.NostalgicPlayer.Ports.LibFlac.Flac.Containers.Decoder
{
	/// <summary>
	/// Possible values passed back to the Flac__StreamDecoder Error Callback.
	/// Lost_Sync is the generic catch-all. The rest could be caused by bad
	/// sync (false synchronization on data that is not the start of a frame)
	/// or corrupted data. The error itself is the decoder's best guess at what
	/// happened assuming a correct sync. For example Bad_Header could be caused
	/// by a correct sync on the start of a frame, but some data in the frame
	/// header was corrupted. Or it could be the result of syncing on a point
	/// the stream that looked like the starting of a frame but was not.
	/// Unparseable_Stream could be because the decoder encountered a valid frame
	/// made by a future version of the encoder which it cannot parse, or because
	/// of a false sync making it appear as though an encountered frame was
	/// generated by a future encoder. Bad_Metadata is
	/// caused by finding data that doesn't fit a metadata block (too large
	/// or too small) or finding inconsistencies in the metadata, for example
	/// a PICTURE block with an image that exceeds the size of the metadata
	/// block
	/// </summary>
	public enum Flac__StreamDecoderErrorStatus
	{
		/// <summary>
		/// An error in the stream caused the decoder to lose synchronization
		/// </summary>
		Lost_Sync,

		/// <summary>
		/// The decoder encountered a corrupted frame header
		/// </summary>
		Bad_Header,

		/// <summary>
		/// The frame's data did not match the CRC in the footer
		/// </summary>
		Crc_Mismatch,

		/// <summary>
		/// The decoder encountered reserved fields in use in the stream
		/// </summary>
		Unparseable_Stream,

		/// <summary>
		/// The decoder encountered a corrupted metadata block
		/// </summary>
		Bad_Metadata
	}
}