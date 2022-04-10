using System;
using System.Runtime.InteropServices;
using WebP.Net.Enum;
using WebP.Net.Struct;

namespace WebP.Net.Interop
{
    internal class MuxDelegate32
    {

        /// <summary>
        /// Returns the version number of the mux library, packed in hexadecimal using
        /// 8bits for each of major/minor/revision. E.g: v2.5.7 is 0x020507.
        /// <br/>
        /// int WebPGetMuxVersion(void);
        /// </summary>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int WebPGetMuxVersion();

        /// <summary>
        /// Internal, version-checked, entry point
        /// <br/>
        /// Creates an empty mux object.
        /// Returns:
        ///   A pointer to the newly created empty mux object.
        ///   Or NULL in case of memory error.
        /// <br/>
        /// WebPMux* WebPNewInternal(int);
        /// </summary>
        /// <param name="version"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate IntPtr WebPNewInternal(int version);

        /// <summary>
        /// Deletes the mux object.
        /// Parameters:
        ///   mux - (in/out) object to be deleted
        /// <br/>
        /// void WebPMuxDelete(WebPMux* mux);
        /// </summary>
        /// <param name="mux"></param>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate void WebPMuxDelete(ref WebPMux mux);

        /// <summary>
        /// Internal, version-checked, entry point
        /// <br/>
        /// Creates a mux object from raw data given in WebP RIFF format.
        /// Parameters:
        ///   bitstream - (in) the bitstream data in WebP RIFF format
        ///   copy_data - (in) value 1 indicates given data WILL be copied to the mux
        ///               object and value 0 indicates data will NOT be copied.
        /// Returns:
        ///   A pointer to the mux object created from given data - on success.
        ///   NULL - In case of invalid data or memory error.
        /// <br/>
        /// WebPMux* WebPMuxCreateInternal(const WebPData* bitstream, int copy_data, int version);
        /// </summary>
        /// <param name="bitstream"></param>
        /// <param name="copy_data"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate IntPtr WebPMuxCreateInternal(ref WebPData bitstream, int copy_data, int version);

        /// <summary>
        /// Adds a chunk with id 'fourcc' and data 'chunk_data' in the mux object.
        /// Any existing chunk(s) with the same id will be removed.
        /// Parameters:
        ///   mux - (in/out) object to which the chunk is to be added
        ///   fourcc - (in) a character array containing the fourcc of the given chunk;
        ///                 e.g., "ICCP", "XMP ", "EXIF" etc.
        ///   chunk_data - (in) the chunk data to be added
        ///   copy_data - (in) value 1 indicates given data WILL be copied to the mux
        ///               object and value 0 indicates data will NOT be copied.
        /// Returns:
        ///   WEBP_MUX_INVALID_ARGUMENT - if mux, fourcc or chunk_data is NULL
        ///                               or if fourcc corresponds to an image chunk.
        ///   WEBP_MUX_MEMORY_ERROR - on memory allocation error.
        ///   WEBP_MUX_OK - on success.
        /// <br/>
        /// WebPMuxError WebPMuxSetChunk(WebPMux* mux, const char fourcc[4], const WebPData* chunk_data, int copy_data);
        /// </summary>
        /// <param name="mux"></param>
        /// <param name=""></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate WebPMuxError WebPMuxSetChunk(ref WebPMux mux,
            [MarshalAs(UnmanagedType.LPArray, SizeConst = 4)] char[] fourcc,
            ref WebPData chunk_data, int copy_data);

        /// <summary>
        /// Gets a reference to the data of the chunk with id 'fourcc' in the mux object.
        /// The caller should NOT free the returned data.
        /// Parameters:
        ///   mux - (in) object from which the chunk data is to be fetched
        ///   fourcc - (in) a character array containing the fourcc of the chunk;
        ///                 e.g., "ICCP", "XMP ", "EXIF" etc.
        ///   chunk_data - (out) returned chunk data
        /// Returns:
        ///   WEBP_MUX_INVALID_ARGUMENT - if mux, fourcc or chunk_data is NULL
        ///                               or if fourcc corresponds to an image chunk.
        ///   WEBP_MUX_NOT_FOUND - If mux does not contain a chunk with the given id.
        ///   WEBP_MUX_OK - on success.
        /// <br/>
        /// WebPMuxError WebPMuxGetChunk(const WebPMux* mux, const char fourcc[4], WebPData* chunk_data);
        /// </summary>
        /// <param name="mux"></param>
        /// <param name="fourcc"></param>
        /// <param name="chunk_data"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate WebPMuxError WebPMuxSetChunk2(ref WebPMux mux,
            [MarshalAs(UnmanagedType.LPArray, SizeConst = 4)] char[] fourcc,
            ref WebPData chunk_data);

        /// <summary>
        /// Deletes the chunk with the given 'fourcc' from the mux object.
        /// Parameters:
        ///   mux - (in/out) object from which the chunk is to be deleted
        ///   fourcc - (in) a character array containing the fourcc of the chunk;
        ///                 e.g., "ICCP", "XMP ", "EXIF" etc.
        /// Returns:
        ///   WEBP_MUX_INVALID_ARGUMENT - if mux or fourcc is NULL
        ///                               or if fourcc corresponds to an image chunk.
        ///   WEBP_MUX_NOT_FOUND - If mux does not contain a chunk with the given fourcc.
        ///   WEBP_MUX_OK - on success.
        /// <br/>
        /// WebPMuxError WebPMuxDeleteChunk(WebPMux* mux, const char fourcc[4]);
        /// </summary>
        /// <param name="mux"></param>
        /// <param name="fourcc"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate WebPMuxError WebPMuxDeleteChunk(ref WebPMux mux, [MarshalAs(UnmanagedType.LPArray, SizeConst = 4)] char[] fourcc);

        /// <summary>
        /// Sets the (non-animated) image in the mux object.
        /// Note: Any existing images (including frames) will be removed.
        /// Parameters:
        ///   mux - (in/out) object in which the image is to be set
        ///   bitstream - (in) can be a raw VP8/VP8L bitstream or a single-image
        ///               WebP file (non-animated)
        ///   copy_data - (in) value 1 indicates given data WILL be copied to the mux
        ///               object and value 0 indicates data will NOT be copied.
        /// Returns:
        ///   WEBP_MUX_INVALID_ARGUMENT - if mux is NULL or bitstream is NULL.
        ///   WEBP_MUX_MEMORY_ERROR - on memory allocation error.
        ///   WEBP_MUX_OK - on success.
        /// <br/>
        /// WebPMuxError WebPMuxSetImage(WebPMux* mux, const WebPData* bitstream, int copy_data);
        /// </summary>
        /// <param name="mux"></param>
        /// <param name="bitstream"></param>
        /// <param name="copy_data"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate WebPMuxError WebPMuxSetImage(ref WebPMux mux, ref WebPData bitstream, int copy_data);

        /// <summary>
        /// Adds a frame at the end of the mux object.
        /// Notes: (1) frame.id should be WEBP_CHUNK_ANMF
        ///        (2) For setting a non-animated image, use WebPMuxSetImage() instead.
        ///        (3) Type of frame being pushed must be same as the frames in mux.
        ///        (4) As WebP only supports even offsets, any odd offset will be snapped
        ///            to an even location using: offset &= ~1
        /// Parameters:
        ///   mux - (in/out) object to which the frame is to be added
        ///   frame - (in) frame data.
        ///   copy_data - (in) value 1 indicates given data WILL be copied to the mux
        ///               object and value 0 indicates data will NOT be copied.
        /// Returns:
        ///   WEBP_MUX_INVALID_ARGUMENT - if mux or frame is NULL
        ///                               or if content of 'frame' is invalid.
        ///   WEBP_MUX_MEMORY_ERROR - on memory allocation error.
        ///   WEBP_MUX_OK - on success.
        /// <br/>
        /// WebPMuxError WebPMuxPushFrame(WebPMux* mux, const WebPMuxFrameInfo* frame, int copy_data);
        /// </summary>
        /// <param name="mux"></param>
        /// <param name="frame"></param>
        /// <param name="copy_data"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate WebPMuxError WebPMuxPushFrame(ref WebPMux mux, ref WebPMuxFrameInfo frame, int copy_data);

        /// <summary>
        /// Gets the nth frame from the mux object.
        /// The content of 'frame->bitstream' is allocated using WebPMalloc(), and NOT
        /// owned by the 'mux' object. It MUST be deallocated by the caller by calling
        /// WebPDataClear().
        /// nth=0 has a special meaning - last position.
        /// Parameters:
        ///   mux - (in) object from which the info is to be fetched
        ///   nth - (in) index of the frame in the mux object
        ///   frame - (out) data of the returned frame
        /// Returns:
        ///   WEBP_MUX_INVALID_ARGUMENT - if mux or frame is NULL.
        ///   WEBP_MUX_NOT_FOUND - if there are less than nth frames in the mux object.
        ///   WEBP_MUX_BAD_DATA - if nth frame chunk in mux is invalid.
        ///   WEBP_MUX_MEMORY_ERROR - on memory allocation error.
        ///   WEBP_MUX_OK - on success.
        /// <br/>
        /// WebPMuxError WebPMuxGetFrame(const WebPMux* mux, uint32_t nth, WebPMuxFrameInfo* frame);
        /// </summary>
        /// <param name="mux"></param>
        /// <param name="nth"></param>
        /// <param name="frame"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate WebPMuxError WebPMuxGetFrame(ref WebPMux mux, UInt32 nth, ref WebPMuxFrameInfo frame);

        /// <summary>
        /// Deletes a frame from the mux object.
        /// nth=0 has a special meaning - last position.
        /// Parameters:
        ///   mux - (in/out) object from which a frame is to be deleted
        ///   nth - (in) The position from which the frame is to be deleted
        /// Returns:
        ///   WEBP_MUX_INVALID_ARGUMENT - if mux is NULL.
        ///   WEBP_MUX_NOT_FOUND - If there are less than nth frames in the mux object
        ///                        before deletion.
        ///   WEBP_MUX_OK - on success.
        /// <br/>
        /// WebPMuxError WebPMuxDeleteFrame(WebPMux* mux, uint32_t nth);
        /// </summary>
        /// <param name="mux"></param>
        /// <param name="nth"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate WebPMuxError WebPMuxDeleteFrame(ref WebPMux mux, UInt32 nth);

        /// <summary>
        /// Sets the animation parameters in the mux object. Any existing ANIM chunks
        /// will be removed.
        /// Parameters:
        ///   mux - (in/out) object in which ANIM chunk is to be set/added
        ///   params - (in) animation parameters.
        /// Returns:
        ///   WEBP_MUX_INVALID_ARGUMENT - if mux or params is NULL.
        ///   WEBP_MUX_MEMORY_ERROR - on memory allocation error.
        ///   WEBP_MUX_OK - on success.
        /// <br/>
        /// WebPMuxError WebPMuxSetAnimationParams(WebPMux* mux, const WebPMuxAnimParams* params);
        /// </summary>
        /// <param name="mux"></param>
        /// <param name="params_"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate WebPMuxError WebPMuxSetAnimationParams(ref WebPMux mux, ref WebPMuxAnimParams params_);

        /// <summary>
        /// Gets the animation parameters from the mux object.
        /// Parameters:
        ///   mux - (in) object from which the animation parameters to be fetched
        ///   params - (out) animation parameters extracted from the ANIM chunk
        /// Returns:
        ///   WEBP_MUX_INVALID_ARGUMENT - if mux or params is NULL.
        ///   WEBP_MUX_NOT_FOUND - if ANIM chunk is not present in mux object.
        ///   WEBP_MUX_OK - on success.
        /// <br/>
        /// WebPMuxError WebPMuxGetAnimationParams(const WebPMux* mux, WebPMuxAnimParams* params);
        /// </summary>
        /// <param name="mux"></param>
        /// <param name=""></param>
        /// <param name=""></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate WebPMuxError WebPMuxGetAnimationParams(ref WebPMux mux, ref WebPMuxAnimParams params_);

        /// <summary>
        /// Sets the canvas size for the mux object. The width and height can be
        /// specified explicitly or left as zero (0, 0).
        /// * When width and height are specified explicitly, then this frame bound is
        ///   enforced during subsequent calls to WebPMuxAssemble() and an error is
        ///   reported if any animated frame does not completely fit within the canvas.
        /// * When unspecified (0, 0), the constructed canvas will get the frame bounds
        ///   from the bounding-box over all frames after calling WebPMuxAssemble().
        /// Parameters:
        ///   mux - (in) object to which the canvas size is to be set
        ///   width - (in) canvas width
        ///   height - (in) canvas height
        /// Returns:
        ///   WEBP_MUX_INVALID_ARGUMENT - if mux is NULL; or
        ///                               width or height are invalid or out of bounds
        ///   WEBP_MUX_OK - on success.
        /// <br/>
        /// WebPMuxError WebPMuxSetCanvasSize(WebPMux* mux, int width, int height);
        /// </summary>
        /// <param name="mux"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate WebPMuxError WebPMuxSetCanvasSize(ref WebPMux mux, int width, int height);

        /// <summary>
        /// Gets the canvas size from the mux object.
        /// Note: This method assumes that the VP8X chunk, if present, is up-to-date.
        /// That is, the mux object hasn't been modified since the last call to
        /// WebPMuxAssemble() or WebPMuxCreate().
        /// Parameters:
        ///   mux - (in) object from which the canvas size is to be fetched
        ///   width - (out) canvas width
        ///   height - (out) canvas height
        /// Returns:
        ///   WEBP_MUX_INVALID_ARGUMENT - if mux, width or height is NULL.
        ///   WEBP_MUX_BAD_DATA - if VP8X/VP8/VP8L chunk or canvas size is invalid.
        ///   WEBP_MUX_OK - on success.
        /// <br/>
        /// WebPMuxError WebPMuxGetCanvasSize(const WebPMux* mux, int* width, int* height);
        /// </summary>
        /// <param name="mux"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate WebPMuxError WebPMuxGetCanvasSize(ref WebPMux mux,ref int width,ref int height);

    }
}
