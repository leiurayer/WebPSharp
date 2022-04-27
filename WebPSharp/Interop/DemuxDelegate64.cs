using System;
using System.Runtime.InteropServices;
using WebPSharp.Enum;
using WebPSharp.Struct;

namespace WebPSharp.Interop
{
    internal class DemuxDelegate64
    {

        /// <summary>
        /// Returns the version number of the demux library, packed in hexadecimal using
        /// 8bits for each of major/minor/revision. E.g: v2.5.7 is 0x020507.
        /// <br/>
        /// int WebPGetDemuxVersion(void);
        /// </summary>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int WebPGetDemuxVersion();

        /// <summary>
        /// Internal, version-checked, entry point
        /// <br/>
        /// Parses the full WebP file given by 'data'. For single images the WebP file
        /// header alone or the file header and the chunk header may be absent.
        /// Returns a WebPDemuxer object on successful parse, NULL otherwise.
        /// <br/>
        /// WebPDemuxer* WebPDemuxInternal(const WebPData* data, int allow_partial, WebPDemuxState* state, int version);
        /// </summary>
        /// <param name="data"></param>
        /// <param name="allow_partial"></param>
        /// <param name="state"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate IntPtr WebPDemuxInternal(ref WebPData data, int allow_partial, IntPtr state, int version);

        /// <summary>
        /// Frees memory associated with 'dmux'.
        /// <br/>
        /// void WebPDemuxDelete(WebPDemuxer* dmux);
        /// </summary>
        /// <param name="dmux"></param>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate void WebPDemuxDelete(ref WebPDemuxer dmux);

        /// <summary>
        /// Get the 'feature' value from the 'dmux'.
        /// NOTE: values are only valid if WebPDemux() was used or WebPDemuxPartial()
        /// returned a state > WEBP_DEMUX_PARSING_HEADER.
        /// If 'feature' is WEBP_FF_FORMAT_FLAGS, the returned value is a bit-wise
        /// combination of WebPFeatureFlags values.
        /// If 'feature' is WEBP_FF_LOOP_COUNT, WEBP_FF_BACKGROUND_COLOR, the returned
        /// value is only meaningful if the bitstream is animated.
        /// <br/>
        /// uint32_t WebPDemuxGetI(const WebPDemuxer* dmux, WebPFormatFeature feature);
        /// </summary>
        /// <param name="dmux"></param>
        /// <param name="feature"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate UInt64 WebPDemuxGetI(ref WebPDemuxer dmux, WebPFormatFeature feature);

        /// <summary>
        /// Retrieves frame 'frame_number' from 'dmux'.
        /// 'iter->fragment' points to the frame on return from this function.
        /// Setting 'frame_number' equal to 0 will return the last frame of the image.
        /// Returns false if 'dmux' is NULL or frame 'frame_number' is not present.
        /// Call WebPDemuxReleaseIterator() when use of the iterator is complete.
        /// NOTE: 'dmux' must persist for the lifetime of 'iter'.
        /// <br/>
        /// int WebPDemuxGetFrame(const WebPDemuxer* dmux, int frame_number, WebPIterator* iter);
        /// </summary>
        /// <param name="dmux"></param>
        /// <param name="frame_number"></param>
        /// <param name="iter"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int WebPDemuxGetFrame(ref WebPDemuxer dmux, int frame_number, ref WebPIterator iter);

        /// <summary>
        /// Sets 'iter->fragment' to point to the next ('iter->frame_num' + 1) or
        /// previous ('iter->frame_num' - 1) frame. These functions do not loop.
        /// Returns true on success, false otherwise.
        /// <br/>
        /// int WebPDemuxNextFrame(WebPIterator* iter);
        /// </summary>
        /// <param name="iter"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int WebPDemuxNextFrame(ref WebPIterator iter);

        /// <summary>
        /// int WebPDemuxPrevFrame(WebPIterator* iter);
        /// </summary>
        /// <param name="iter"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int WebPDemuxPrevFrame(ref WebPIterator iter);

        /// <summary>
        /// Releases any memory associated with 'iter'.
        /// Must be called before any subsequent calls to WebPDemuxGetChunk() on the same
        /// iter. Also, must be called before destroying the associated WebPDemuxer with
        /// WebPDemuxDelete().
        /// <br/>
        /// void WebPDemuxReleaseIterator(WebPIterator* iter);
        /// </summary>
        /// <param name="iter"></param>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate void WebPDemuxReleaseIterator(ref WebPIterator iter);

        /// <summary>
        /// Retrieves the 'chunk_number' instance of the chunk with id 'fourcc' from
        /// 'dmux'.
        /// 'fourcc' is a character array containing the fourcc of the chunk to return,
        /// e.g., "ICCP", "XMP ", "EXIF", etc.
        /// Setting 'chunk_number' equal to 0 will return the last chunk in a set.
        /// Returns true if the chunk is found, false otherwise. Image related chunk
        /// payloads are accessed through WebPDemuxGetFrame() and related functions.
        /// Call WebPDemuxReleaseChunkIterator() when use of the iterator is complete.
        /// NOTE: 'dmux' must persist for the lifetime of the iterator.
        /// <br/>
        /// int WebPDemuxGetChunk(const WebPDemuxer* dmux, const char fourcc[4], int chunk_number, WebPChunkIterator* iter);
        /// </summary>
        /// <param name="dmux"></param>
        /// <param name="fourcc"></param>
        /// <param name="chunk_number"></param>
        /// <param name="iter"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int WebPDemuxGetChunk(ref WebPDemuxer dmux,
            [MarshalAs(UnmanagedType.LPArray, SizeConst = 4)] char[] fourcc, int chunk_number,
            ref WebPChunkIterator iter);

        /// <summary>
        /// Sets 'iter->chunk' to point to the next ('iter->chunk_num' + 1) or previous
        /// ('iter->chunk_num' - 1) chunk. These functions do not loop.
        /// Returns true on success, false otherwise.
        /// <br/>
        /// int WebPDemuxNextChunk(WebPChunkIterator* iter);
        /// </summary>
        /// <param name="iter"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int WebPDemuxNextChunk(ref WebPChunkIterator iter);

        /// <summary>
        /// int WebPDemuxPrevChunk(WebPChunkIterator* iter);
        /// </summary>
        /// <param name="iter"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int WebPDemuxPrevChunk(ref WebPChunkIterator iter);

        /// <summary>
        /// Releases any memory associated with 'iter'.
        /// Must be called before destroying the associated WebPDemuxer with
        /// WebPDemuxDelete().
        /// <br/>
        /// void WebPDemuxReleaseChunkIterator(WebPChunkIterator* iter);
        /// </summary>
        /// <param name="iter"></param>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate void WebPDemuxReleaseChunkIterator(ref WebPChunkIterator iter);

        /// <summary>
        /// Internal, version-checked, entry point.
        /// <br/>
        /// Should always be called, to initialize a fresh WebPAnimDecoderOptions
        /// structure before modification. Returns false in case of version mismatch.
        /// WebPAnimDecoderOptionsInit() must have succeeded before using the
        /// 'dec_options' object.
        /// <br/>
        /// int WebPAnimDecoderOptionsInitInternal(WebPAnimDecoderOptions* dec_options, int abi_version);
        /// </summary>
        /// <param name="dec_options"></param>
        /// <param name="abi_version"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int WebPAnimDecoderOptionsInitInternal(ref WebPAnimDecoderOptions dec_options, int abi_version);

        /// <summary>
        /// Internal, version-checked, entry point.
        /// <br/>
        /// Creates and initializes a WebPAnimDecoder object.
        /// Parameters:
        ///   webp_data - (in) WebP bitstream. This should remain unchanged during the
        ///                    lifetime of the output WebPAnimDecoder object.
        ///   dec_options - (in) decoding options. Can be passed NULL to choose
        ///                      reasonable defaults (in particular, color mode MODE_RGBA
        ///                      will be picked).
        /// Returns:
        ///   A pointer to the newly created WebPAnimDecoder object, or NULL in case of
        ///   parsing error, invalid option or memory error.
        /// <br/>
        /// WebPAnimDecoder* WebPAnimDecoderNewInternal(  const WebPData* webp_data, const WebPAnimDecoderOptions* dec_options, int abi_version);
        /// </summary>
        /// <param name="webp_data"></param>
        /// <param name="dec_options"></param>
        /// <param name="abi_version"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate IntPtr WebPAnimDecoderNewInternal(ref WebPData webp_data, ref WebPAnimDecoderOptions dec_options, int abi_version);

        /// <summary>
        /// Get global information about the animation.
        /// Parameters:
        ///   dec - (in) decoder instance to get information from.
        ///   info - (out) global information fetched from the animation.
        /// Returns:
        ///   True on success.
        /// <br/>
        /// int WebPAnimDecoderGetInfo(const WebPAnimDecoder* dec, WebPAnimInfo* info);
        /// </summary>
        /// <param name="dec"></param>
        /// <param name="info"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int WebPAnimDecoderGetInfo(ref WebPAnimDecoder dec, ref WebPAnimInfo info);

        /// <summary>
        /// Fetch the next frame from 'dec' based on options supplied to
        /// WebPAnimDecoderNew(). This will be a fully reconstructed canvas of size
        /// 'canvas_width * 4 * canvas_height', and not just the frame sub-rectangle. The
        /// returned buffer 'buf' is valid only until the next call to
        /// WebPAnimDecoderGetNext(), WebPAnimDecoderReset() or WebPAnimDecoderDelete().
        /// Parameters:
        ///   dec - (in/out) decoder instance from which the next frame is to be fetched.
        ///   buf - (out) decoded frame.
        ///   timestamp - (out) timestamp of the frame in milliseconds.
        /// Returns:
        ///   False if any of the arguments are NULL, or if there is a parsing or
        ///   decoding error, or if there are no more frames. Otherwise, returns true.
        /// <br/>
        /// int WebPAnimDecoderGetNext(WebPAnimDecoder* dec, uint8_t** buf, int* timestamp);
        /// </summary>
        /// <param name="dec"></param>
        /// <param name="buf"></param>
        /// <param name="timestamp"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int WebPAnimDecoderGetNext(ref WebPAnimDecoder dec, ref IntPtr buf, ref int timestamp);

        /// <summary>
        /// Check if there are more frames left to decode.
        /// Parameters:
        ///   dec - (in) decoder instance to be checked.
        /// Returns:
        ///   True if 'dec' is not NULL and some frames are yet to be decoded.
        ///   Otherwise, returns false.
        /// <br/>
        /// int WebPAnimDecoderHasMoreFrames(const WebPAnimDecoder* dec);
        /// </summary>
        /// <param name="dec"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int WebPAnimDecoderHasMoreFrames(ref WebPAnimDecoder dec);

        /// <summary>
        /// Resets the WebPAnimDecoder object, so that next call to
        /// WebPAnimDecoderGetNext() will restart decoding from 1st frame. This would be
        /// helpful when all frames need to be decoded multiple times (e.g.
        /// info.loop_count times) without destroying and recreating the 'dec' object.
        /// Parameters:
        ///   dec - (in/out) decoder instance to be reset
        /// <br/>
        /// void WebPAnimDecoderReset(WebPAnimDecoder* dec);
        /// </summary>
        /// <param name="dec"></param>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate void WebPAnimDecoderReset(ref WebPAnimDecoder dec);

        /// <summary>
        /// Grab the internal demuxer object.
        /// Getting the demuxer object can be useful if one wants to use operations only
        /// available through demuxer; e.g. to get XMP/EXIF/ICC metadata. The returned
        /// demuxer object is owned by 'dec' and is valid only until the next call to
        /// WebPAnimDecoderDelete().
        ///
        /// Parameters:
        ///   dec - (in) decoder instance from which the demuxer object is to be fetched.
        /// <br/>
        /// const WebPDemuxer* WebPAnimDecoderGetDemuxer(const WebPAnimDecoder* dec);
        /// </summary>
        /// <param name="dec"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate IntPtr WebPAnimDecoderGetDemuxer(ref WebPAnimDecoder dec);

        /// <summary>
        /// Deletes the WebPAnimDecoder object.
        /// Parameters:
        ///   dec - (in/out) decoder instance to be deleted
        /// <br/>
        /// void WebPAnimDecoderDelete(WebPAnimDecoder* dec);
        /// </summary>
        /// <param name="dec"></param>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate void WebPAnimDecoderDelete(ref WebPAnimDecoder dec);

    }
}
