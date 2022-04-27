using System;
using System.Runtime.InteropServices;
using WebPSharp.Enum;
using WebPSharp.Struct;

namespace WebPSharp.Interop
{
    internal class Delegate64
    {
        #region WebP decode

        /// <summary>
        /// Return the decoder's version number, packed in hexadecimal using 8bits for
        /// each of major/minor/revision. E.g: v2.5.7 is 0x020507.
        /// <br/>
        /// int WebPGetDecoderVersion(void);
        /// </summary>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int WebPGetDecoderVersion();

        /// <summary>
        /// Retrieve basic header information: width, height.
        /// <br/>
        /// int WebPGetInfo(const uint8_t* data, size_t data_size, int* width, int* height);
        /// </summary>
        /// <param name="data"></param>
        /// <param name="data_size"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int WebPGetInfo(IntPtr data, UInt64 data_size, ref int width, ref int height);

        /// <summary>
        /// Decodes WebP images pointed to by 'data' and returns RGBA samples, along
        /// with the dimensions in *width and *height. The ordering of samples in
        /// memory is R, G, B, A, R, G, B, A... in scan order (endian-independent).
        /// The returned pointer should be deleted calling WebPFree().
        /// Returns NULL in case of error.
        /// <br/>
        /// uint8_t* WebPDecodeRGBA(const uint8_t* data, size_t data_size, int* width, int* height);
        /// </summary>
        /// <param name="data"></param>
        /// <param name="data_size"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate IntPtr WebPDecodeRGBA(IntPtr data, UInt64 data_size, ref int width, ref int height);

        /// <summary>
        /// Same as WebPDecodeRGBA, but returning A, R, G, B, A, R, G, B... ordered data.
        /// <br/>
        /// uint8_t* WebPDecodeARGB(const uint8_t* data, size_t data_size, int* width, int* height);
        /// </summary>
        /// <param name="data"></param>
        /// <param name="data_size"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate IntPtr WebPDecodeARGB(IntPtr data, UInt64 data_size, ref int width, ref int height);

        /// <summary>
        /// Same as WebPDecodeRGBA, but returning B, G, R, A, B, G, R, A... ordered data.
        /// <br/>
        /// uint8_t* WebPDecodeBGRA(const uint8_t* data, size_t data_size, int* width, int* height);
        /// </summary>
        /// <param name="data"></param>
        /// <param name="data_size"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate IntPtr WebPDecodeBGRA(IntPtr data, UInt64 data_size, ref int width, ref int height);

        /// <summary>
        /// Same as WebPDecodeRGBA, but returning R, G, B, R, G, B... ordered data.
        /// If the bitstream contains transparency, it is ignored.
        /// <br/>
        /// uint8_t* WebPDecodeRGB(const uint8_t* data, size_t data_size, int* width, int* height);
        /// </summary>
        /// <param name="data"></param>
        /// <param name="data_size"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate IntPtr WebPDecodeRGB(IntPtr data, UInt64 data_size, ref int width, ref int height);

        /// <summary>
        /// Same as WebPDecodeRGB, but returning B, G, R, B, G, R... ordered data.
        /// <br/>
        /// uint8_t* WebPDecodeBGR(const uint8_t* data, size_t data_size, int* width, int* height);
        /// </summary>
        /// <param name="data"></param>
        /// <param name="data_size"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate IntPtr WebPDecodeBGR(IntPtr data, UInt64 data_size, ref int width, ref int height);

        /// <summary>
        /// Decode WebP images pointed to by 'data' to Y'UV format(*). The pointer
        /// returned is the Y samples buffer. Upon return, *u and *v will point to
        /// the U and V chroma data. These U and V buffers need NOT be passed to
        /// WebPFree(), unlike the returned Y luma one. The dimension of the U and V
        /// planes are both (*width + 1) / 2 and (*height + 1)/ 2.
        /// Upon return, the Y buffer has a stride returned as '*stride', while U and V
        /// have a common stride returned as '*uv_stride'.
        /// Return NULL in case of error.
        /// (*) Also named Y'CbCr. See: https://en.wikipedia.org/wiki/YCbCr
        /// <br/>
        /// uint8_t* WebPDecodeYUV(const uint8_t* data, size_t data_size, int* width, int* height,
        ///                        uint8_t** u, uint8_t** v, int* stride, int* uv_stride);
        /// </summary>
        /// <param name="data"></param>
        /// <param name="data_size"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="u"></param>
        /// <param name="v"></param>
        /// <param name="stride"></param>
        /// <param name="uv_stride"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate IntPtr WebPDecodeYUV(IntPtr data, UInt64 data_size, ref int width, ref int height,
            ref IntPtr u, ref IntPtr v, ref int stride, ref int uv_stride);

        /// <summary>
        /// This function is variant of the above one, that decode the image
        /// directly into a pre-allocated buffer 'output_buffer'. The maximum storage
        /// available in this buffer is indicated by 'output_buffer_size'. If this
        /// storage is not sufficient (or an error occurred), NULL is returned.
        /// Otherwise, output_buffer is returned, for convenience.
        /// The parameter 'output_stride' specifies the distance (in bytes)
        /// between scanlines. Hence, output_buffer_size is expected to be at least
        /// output_stride x picture-height.
        /// <br/>
        /// uint8_t* WebPDecodeRGBAInto(const uint8_t* data, size_t data_size,
        ///                             uint8_t* output_buffer, size_t output_buffer_size, int output_stride);
        /// </summary>
        /// <param name="data"></param>
        /// <param name="data_size"></param>
        /// <param name="output_buffer"></param>
        /// <param name="output_buffer_size"></param>
        /// <param name="output_stride"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate IntPtr WebPDecodeRGBAInto(IntPtr data, UInt64 data_size,
            IntPtr output_buffer, UInt64 output_buffer_size, int output_stride);

        /// <summary>
        /// Same as WebPDecodeRGBAInto.
        /// <br/>
        /// uint8_t* WebPDecodeARGBInto(const uint8_t* data, size_t data_size,
        ///                             uint8_t* output_buffer, size_t output_buffer_size, int output_stride);
        /// </summary>
        /// <param name="data"></param>
        /// <param name="data_size"></param>
        /// <param name="output_buffer"></param>
        /// <param name="output_buffer_size"></param>
        /// <param name="output_stride"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate IntPtr WebPDecodeARGBInto(IntPtr data, UInt64 data_size,
          IntPtr output_buffer, UInt64 output_buffer_size, int output_stride);

        /// <summary>
        /// Same as WebPDecodeRGBAInto.
        /// <br/>
        /// uint8_t* WebPDecodeBGRAInto(const uint8_t* data, size_t data_size,
        ///                             uint8_t* output_buffer, size_t output_buffer_size, int output_stride);
        /// </summary>
        /// <param name="data"></param>
        /// <param name="data_size"></param>
        /// <param name="output_buffer"></param>
        /// <param name="output_buffer_size"></param>
        /// <param name="output_stride"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate IntPtr WebPDecodeBGRAInto(IntPtr data, UInt64 data_size,
            IntPtr output_buffer, UInt64 output_buffer_size, int output_stride);

        /// <summary>
        /// Same as WebPDecodeRGBAInto.
        /// But only RGB and BGR variants.
        /// Here too the transparency information, if present,
        /// will be dropped and ignored.
        /// <br/>
        /// uint8_t* WebPDecodeRGBInto(const uint8_t* data, size_t data_size,
        ///                            uint8_t* output_buffer, size_t output_buffer_size, int output_stride);
        /// </summary>
        /// <param name="data"></param>
        /// <param name="data_size"></param>
        /// <param name="output_buffer"></param>
        /// <param name="output_buffer_size"></param>
        /// <param name="output_stride"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate IntPtr WebPDecodeRGBInto(IntPtr data, UInt64 data_size,
           IntPtr output_buffer, UInt64 output_buffer_size, int output_stride);

        /// <summary>
        /// Same as WebPDecodeRGBAInto.
        /// But only RGB and BGR variants.
        /// Here too the transparency information, if present,
        /// will be dropped and ignored.
        /// <br/>
        /// uint8_t* WebPDecodeBGRInto(const uint8_t* data, size_t data_size,
        ///                            uint8_t* output_buffer, size_t output_buffer_size, int output_stride);
        /// </summary>
        /// <param name="data"></param>
        /// <param name="data_size"></param>
        /// <param name="output_buffer"></param>
        /// <param name="output_buffer_size"></param>
        /// <param name="output_stride"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate IntPtr WebPDecodeBGRInto(IntPtr data, UInt64 data_size,
            IntPtr output_buffer, UInt64 output_buffer_size, int output_stride);

        /// <summary>
        /// WebPDecodeYUVInto() is a variant of WebPDecodeYUV() that operates directly
        /// into pre-allocated luma/chroma plane buffers. This function requires the
        /// strides to be passed: one for the luma plane and one for each of the
        /// chroma ones. The size of each plane buffer is passed as 'luma_size',
        /// 'u_size' and 'v_size' respectively.
        /// Pointer to the luma plane ('*luma') is returned or NULL if an error occurred
        /// during decoding (or because some buffers were found to be too small).
        /// <br/>
        /// uint8_t* WebPDecodeYUVInto(const uint8_t* data, size_t data_size,
        ///                            uint8_t* luma, size_t luma_size, int luma_stride,
        ///                            uint8_t* u, size_t u_size, int u_stride,
        ///                            uint8_t* v, size_t v_size, int v_stride);
        /// </summary>
        /// <param name="data"></param>
        /// <param name="data_size"></param>
        /// <param name="luma"></param>
        /// <param name="luma_size"></param>
        /// <param name="luma_stride"></param>
        /// <param name="u"></param>
        /// <param name="u_size"></param>
        /// <param name="u_stride"></param>
        /// <param name="v"></param>
        /// <param name="v_size"></param>
        /// <param name="v_stride"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate IntPtr WebPDecodeYUVInto(IntPtr data, UInt64 data_size,
            IntPtr luma, UInt64 luma_size, int luma_stride,
            IntPtr u, UInt64 u_size, int u_stride,
            IntPtr v, UInt64 v_size, int v_stride);

        /// <summary>
        /// Internal, version-checked, entry point
        /// Initialize the structure as empty. Must be called before any other use.
        /// Returns false in case of version mismatch.
        /// <br/>
        /// int WebPInitDecBufferInternal(WebPDecBuffer*, int);
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int WebPInitDecBufferInternal(ref WebPDecBuffer buffer, int version);

        /// <summary>
        /// Free any memory associated with the buffer. Must always be called last.
        /// Note: doesn't free the 'buffer' structure itself.
        /// <br/>
        /// void WebPFreeDecBuffer(WebPDecBuffer* buffer);
        /// </summary>
        /// <param name="buffer"></param>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate void WebPFreeDecBuffer(ref WebPDecBuffer buffer);

        /// <summary>
        /// Creates a new incremental decoder with the supplied buffer parameter.
        /// This output_buffer can be passed NULL, in which case a default output buffer
        /// is used (with MODE_RGB). Otherwise, an internal reference to 'output_buffer'
        /// is kept, which means that the lifespan of 'output_buffer' must be larger than
        /// that of the returned WebPIDecoder object.
        /// The supplied 'output_buffer' content MUST NOT be changed between calls to
        /// WebPIAppend() or WebPIUpdate() unless 'output_buffer.is_external_memory' is
        /// not set to 0. In such a case, it is allowed to modify the pointers, size and
        /// stride of output_buffer.u.RGBA or output_buffer.u.YUVA, provided they remain
        /// within valid bounds.
        /// All other fields of WebPDecBuffer MUST remain constant between calls.
        /// Returns NULL if the allocation failed.
        /// <br/>
        /// WebPIDecoder* WebPINewDecoder(WebPDecBuffer* output_buffer);
        /// </summary>
        /// <param name="output_buffer"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate IntPtr WebPINewDecoder(ref WebPDecBuffer output_buffer);

        /// <summary>
        /// This function allocates and initializes an incremental-decoder object, which
        /// will output the RGB/A samples specified by 'csp' into a preallocated
        /// buffer 'output_buffer'. The size of this buffer is at least
        /// 'output_buffer_size' and the stride (distance in bytes between two scanlines)
        /// is specified by 'output_stride'.
        /// Additionally, output_buffer can be passed NULL in which case the output
        /// buffer will be allocated automatically when the decoding starts. The
        /// colorspace 'csp' is taken into account for allocating this buffer. All other
        /// parameters are ignored.
        /// Returns NULL if the allocation failed, or if some parameters are invalid.
        /// <br/>
        /// WebPIDecoder* WebPINewRGB(WEBP_CSP_MODE csp, uint8_t* output_buffer, size_t output_buffer_size, int output_stride);
        /// </summary>
        /// <param name="csp"></param>
        /// <param name="output_buffer"></param>
        /// <param name="output_buffer_size"></param>
        /// <param name="output_stride"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate IntPtr WebPINewRGB(WEBP_CSP_MODE csp, IntPtr output_buffer, UInt64 output_buffer_size, int output_stride);

        /// <summary>
        /// This function allocates and initializes an incremental-decoder object, which
        /// will output the raw luma/chroma samples into a preallocated planes if
        /// supplied. The luma plane is specified by its pointer 'luma', its size
        /// 'luma_size' and its stride 'luma_stride'. Similarly, the chroma-u plane
        /// is specified by the 'u', 'u_size' and 'u_stride' parameters, and the chroma-v
        /// plane by 'v' and 'v_size'. And same for the alpha-plane. The 'a' pointer
        /// can be pass NULL in case one is not interested in the transparency plane.
        /// Conversely, 'luma' can be passed NULL if no preallocated planes are supplied.
        /// In this case, the output buffer will be automatically allocated (using
        /// MODE_YUVA) when decoding starts. All parameters are then ignored.
        /// Returns NULL if the allocation failed or if a parameter is invalid.
        /// <br/>
        /// WebPIDecoder* WebPINewYUVA(uint8_t* luma, size_t luma_size, int luma_stride,
        ///                            uint8_t* u, size_t u_size, int u_stride,
        ///                            uint8_t* v, size_t v_size, int v_stride,
        ///                            uint8_t* a, size_t a_size, int a_stride);
        /// </summary>
        /// <param name="luma"></param>
        /// <param name="luma_size"></param>
        /// <param name="luma_stride"></param>
        /// <param name="u"></param>
        /// <param name="u_size"></param>
        /// <param name="u_stride"></param>
        /// <param name="v"></param>
        /// <param name="v_size"></param>
        /// <param name="v_stride"></param>
        /// <param name="a"></param>
        /// <param name="a_size"></param>
        /// <param name="a_stride"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate IntPtr WebPINewYUVA(IntPtr luma, UInt64 luma_size, int luma_stride,
            IntPtr u, UInt64 u_size, int u_stride,
            IntPtr v, UInt64 v_size, int v_stride,
            IntPtr a, UInt64 a_size, int a_stride);

        /// <summary>
        /// Deprecated version of the above, without the alpha plane.
        /// Kept for backward compatibility.
        /// <br/>
        /// WebPIDecoder* WebPINewYUV(uint8_t* luma, size_t luma_size, int luma_stride,
        ///                           uint8_t* u, size_t u_size, int u_stride,
        ///                           uint8_t* v, size_t v_size, int v_stride);
        /// </summary>
        /// <param name="luma"></param>
        /// <param name="luma_size"></param>
        /// <param name="luma_stride"></param>
        /// <param name="u"></param>
        /// <param name="u_size"></param>
        /// <param name="u_stride"></param>
        /// <param name="v"></param>
        /// <param name="v_size"></param>
        /// <param name="v_stride"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate IntPtr WebPINewYUV(IntPtr luma, UInt64 luma_size, int luma_stride,
            IntPtr u, UInt64 u_size, int u_stride,
            IntPtr v, UInt64 v_size, int v_stride);

        /// <summary>
        /// Deletes the WebPIDecoder object and associated memory. Must always be called
        /// if WebPINewDecoder, WebPINewRGB or WebPINewYUV succeeded.
        /// <br/>
        /// void WebPIDelete(WebPIDecoder* idec);
        /// </summary>
        /// <param name="idec"></param>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate void WebPIDelete(ref WebPIDecoder idec);

        /// <summary>
        /// Copies and decodes the next available data. Returns VP8_STATUS_OK when
        /// the image is successfully decoded. Returns VP8_STATUS_SUSPENDED when more
        /// data is expected. Returns error in other cases.
        /// <br/>
        /// VP8StatusCode WebPIAppend(WebPIDecoder* idec, const uint8_t* data, size_t data_size);
        /// </summary>
        /// <param name="idec"></param>
        /// <param name="data"></param>
        /// <param name="data_size"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate VP8StatusCode WebPIAppend(ref WebPIDecoder idec, IntPtr data, UInt64 data_size);

        /// <summary>
        /// A variant of the above function to be used when data buffer contains
        /// partial data from the beginning. In this case data buffer is not copied
        /// to the internal memory.
        /// Note that the value of the 'data' pointer can change between calls to
        /// WebPIUpdate, for instance when the data buffer is resized to fit larger data.
        /// <br/>
        /// VP8StatusCode WebPIUpdate(WebPIDecoder* idec, const uint8_t* data, size_t data_size);
        /// </summary>
        /// <param name="idec"></param>
        /// <param name="data"></param>
        /// <param name="data_size"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate VP8StatusCode WebPIUpdate(ref WebPIDecoder idec, IntPtr data, UInt64 data_size);

        /// <summary>
        /// Returns the RGB/A image decoded so far. Returns NULL if output params
        /// are not initialized yet. The RGB/A output type corresponds to the colorspace
        /// specified during call to WebPINewDecoder() or WebPINewRGB().
        /// *last_y is the index of last decoded row in raster scan order. Some pointers
        /// (*last_y, *width etc.) can be NULL if corresponding information is not
        /// needed. The values in these pointers are only valid on successful (non-NULL)
        /// return.
        /// <br/>
        /// uint8_t* WebPIDecGetRGB(const WebPIDecoder* idec, int* last_y, int* width, int* height, int* stride);
        /// </summary>
        /// <param name="idec"></param>
        /// <param name="last_y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="stride"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate IntPtr WebPIDecGetRGB(ref WebPIDecoder idec, ref int last_y, ref int width, ref int height, ref int stride);

        /// <summary>
        /// Same as above function to get a YUVA image. Returns pointer to the luma
        /// plane or NULL in case of error. If there is no alpha information
        /// the alpha pointer '*a' will be returned NULL.
        /// <br/>
        /// uint8_t* WebPIDecGetYUVA(const WebPIDecoder* idec, int* last_y,
        ///                          uint8_t** u, uint8_t** v, uint8_t** a,
        ///                          int* width, int* height, int* stride, int* uv_stride, int* a_stride);
        /// </summary>
        /// <param name="idec"></param>
        /// <param name="last_y"></param>
        /// <param name="u"></param>
        /// <param name="v"></param>
        /// <param name="a"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="stride"></param>
        /// <param name="uv_stride"></param>
        /// <param name="a_stride"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate IntPtr WebPIDecGetYUVA(ref WebPIDecoder idec, ref int last_y,
            IntPtr u, IntPtr v, IntPtr a,
            ref int width, ref int height, ref int stride, ref int uv_stride, ref int a_stride);

        /// <summary>
        /// Generic call to retrieve information about the displayable area.
        /// If non NULL, the left/right/width/height pointers are filled with the visible
        /// rectangular area so far.
        /// Returns NULL in case the incremental decoder object is in an invalid state.
        /// Otherwise returns the pointer to the internal representation. This structure
        /// is read-only, tied to WebPIDecoder's lifespan and should not be modified.
        /// <br/>
        /// const WebPDecBuffer* WebPIDecodedArea(const WebPIDecoder* idec, int* left, int* top, int* width, int* height);
        /// </summary>
        /// <param name="idec"></param>
        /// <param name="left"></param>
        /// <param name="top"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate IntPtr WebPIDecodedArea(ref WebPIDecoder idec, ref int left, ref int top, ref int width, ref int height);

        /// <summary>
        /// Retrieve features from the bitstream. The *features structure is filled
        /// with information gathered from the bitstream.
        /// Returns VP8_STATUS_OK when the features are successfully retrieved. Returns
        /// VP8_STATUS_NOT_ENOUGH_DATA when more data is needed to retrieve the
        /// features from headers. Returns error in other cases.
        /// <br/>
        /// VP8StatusCode WebPGetFeatures(const uint8_t* data, size_t data_size, WebPBitstreamFeatures* features);
        /// </summary>
        /// <param name="data"></param>
        /// <param name="data_size"></param>
        /// <param name="features"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate VP8StatusCode WebPGetFeaturesInternal(IntPtr data, UInt64 data_size, ref WebPBitstreamFeatures features, int version);

        /// <summary>
        /// Internal, version-checked, entry point
        /// <br/>
        /// Initialize the configuration as empty. This function must always be
        /// called first, unless WebPGetFeatures() is to be called.
        /// Returns false in case of mismatched version.
        /// <br/>
        /// int WebPInitDecoderConfigInternal(WebPDecoderConfig* config, int version);
        /// </summary>
        /// <param name="config"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int WebPInitDecoderConfigInternal(ref WebPDecoderConfig config, int version);

        /// <summary>
        /// Instantiate a new incremental decoder object with the requested
        /// configuration. The bitstream can be passed using 'data' and 'data_size'
        /// parameter, in which case the features will be parsed and stored into
        /// config->input. Otherwise, 'data' can be NULL and no parsing will occur.
        /// Note that 'config' can be NULL too, in which case a default configuration
        /// is used. If 'config' is not NULL, it must outlive the WebPIDecoder object
        /// as some references to its fields will be used. No internal copy of 'config'
        /// is made.
        /// The return WebPIDecoder object must always be deleted calling WebPIDelete().
        /// Returns NULL in case of error (and config->status will then reflect
        /// the error condition, if available).
        /// <br/>
        /// WebPIDecoder* WebPIDecode(const uint8_t* data, size_t data_size, WebPDecoderConfig* config);
        /// </summary>
        /// <param name="data"></param>
        /// <param name="data_size"></param>
        /// <param name="config"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate IntPtr WebPIDecode(IntPtr data, UInt64 data_size, ref WebPDecoderConfig config);

        /// <summary>
        /// Non-incremental version. This version decodes the full data at once, taking
        /// 'config' into account. Returns decoding status (which should be VP8_STATUS_OK
        /// if the decoding was successful). Note that 'config' cannot be NULL.
        /// <br/>
        /// VP8StatusCode WebPDecode(const uint8_t* data, size_t data_size, WebPDecoderConfig* config);
        /// </summary>
        /// <param name="data"></param>
        /// <param name="data_size"></param>
        /// <param name="config"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate VP8StatusCode WebPDecode(IntPtr data, UInt64 data_size, ref WebPDecoderConfig config);

        #endregion

        #region WebP encode

        /// <summary>
        /// Return the encoder's version number, packed in hexadecimal using 8bits for
        /// each of major/minor/revision. E.g: v2.5.7 is 0x020507.
        /// <br/>
        /// int WebPGetEncoderVersion(void);
        /// </summary>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int WebPGetEncoderVersion();

        /// <summary>
        /// Returns the size of the compressed data (pointed to by *output), or 0 if
        /// an error occurred. The compressed data must be released by the caller
        /// using the call 'WebPFree(*output)'.
        /// These functions compress using the lossy format, and the quality_factor
        /// can go from 0 (smaller output, lower quality) to 100 (best quality,
        /// larger output).
        /// <br/>
        /// size_t WebPEncodeRGB(const uint8_t* rgb,
        ///                      int width, int height, int stride,
        ///                      float quality_factor, uint8_t** output);
        /// </summary>
        /// <param name="rgb"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="stride"></param>
        /// <param name="quality_factor"></param>
        /// <param name="output"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate UInt64 WebPEncodeRGB(IntPtr rgb,
                                 int width, int height, int stride,
                                 float quality_factor, IntPtr output);

        /// <summary>
        /// Same as WebPEncodeRGB
        /// <br/>
        /// size_t WebPEncodeBGR(const uint8_t* bgr,
        ///                      int width, int height, int stride,
        ///                      float quality_factor, uint8_t** output);
        /// </summary>
        /// <param name="bgr"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="stride"></param>
        /// <param name="quality_factor"></param>
        /// <param name="output"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate UInt64 WebPEncodeBGR(IntPtr bgr,
                           int width, int height, int stride,
                           float quality_factor, IntPtr output);

        /// <summary>
        /// Same as WebPEncodeRGB
        /// <br/>
        /// size_t WebPEncodeRGBA(const uint8_t* rgba,
        ///                       int width, int height, int stride,
        ///                       float quality_factor, uint8_t** output);
        /// </summary>
        /// <param name="rgba"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="stride"></param>
        /// <param name="quality_factor"></param>
        /// <param name="output"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate UInt64 WebPEncodeRGBA(IntPtr rgba,
                           int width, int height, int stride,
                           float quality_factor, IntPtr output);

        /// <summary>
        /// Same as WebPEncodeRGB
        /// <br/>
        /// size_t WebPEncodeBGRA(const uint8_t* bgra,
        ///                       int width, int height, int stride,
        ///                       float quality_factor, uint8_t** output);
        /// </summary>
        /// <param name="bgra"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="stride"></param>
        /// <param name="quality_factor"></param>
        /// <param name="output"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate UInt64 WebPEncodeBGRA(IntPtr bgra,
                           int width, int height, int stride,
                           float quality_factor, IntPtr output);

        /// <summary>
        /// These functions are the equivalent of the above, but compressing in a
        /// lossless manner. Files are usually larger than lossy format, but will
        /// not suffer any compression loss.
        /// Note these functions, like the lossy versions, use the library's default
        /// settings. For lossless this means 'exact' is disabled. RGB values in
        /// transparent areas will be modified to improve compression. To avoid this,
        /// use WebPEncode() and set WebPConfig::exact to 1.
        /// <br/>
        /// size_t WebPEncodeLosslessRGB(const uint8_t* rgb,
        ///                              int width, int height, int stride, uint8_t** output);
        /// </summary>
        /// <param name="bgra"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="stride"></param>
        /// <param name="output"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate UInt64 WebPEncodeLosslessRGB(IntPtr rgb,
                           int width, int height, int stride, IntPtr output);

        /// <summary>
        /// Same as WebPEncodeLosslessRGB
        /// <br/>
        /// size_t WebPEncodeLosslessBGR(const uint8_t* bgr,
        ///                              int width, int height, int stride, uint8_t** output);
        /// </summary>
        /// <param name="bgr"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="stride"></param>
        /// <param name="output"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate UInt64 WebPEncodeLosslessBGR(IntPtr bgr,
                           int width, int height, int stride, IntPtr output);

        /// <summary>
        /// Same as WebPEncodeLosslessRGB
        /// <br/>
        /// size_t WebPEncodeLosslessRGBA(const uint8_t* rgba,
        ///                               int width, int height, int stride, uint8_t** output);
        /// </summary>
        /// <param name="rgba"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="stride"></param>
        /// <param name="output"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate UInt64 WebPEncodeLosslessRGBA(IntPtr rgba,
                           int width, int height, int stride, IntPtr output);

        /// <summary>
        /// Same as WebPEncodeLosslessRGB
        /// <br/>
        /// size_t WebPEncodeLosslessBGRA(const uint8_t* bgra,
        ///                               int width, int height, int stride, uint8_t** output);
        /// </summary>
        /// <param name="bgra"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="stride"></param>
        /// <param name="output"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate UInt64 WebPEncodeLosslessBGRA(IntPtr bgra,
                           int width, int height, int stride, IntPtr output);

        /// <summary>
        /// Internal, version-checked, entry point
        /// <br/>
        /// Should always be called, to initialize a fresh WebPConfig structure before
        /// modification. Returns false in case of version mismatch. WebPConfigInit()
        /// must have succeeded before using the 'config' object.
        /// Note that the default values are lossless=0 and quality=75.
        /// <br/>
        /// int WebPConfigInitInternal(WebPConfig* config, WebPPreset preset, float quality, int version);
        /// </summary>
        /// <param name="config"></param>
        /// <param name="preset"></param>
        /// <param name="quality"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int WebPConfigInitInternal(ref WebPConfig config, WebPPreset preset, float quality, int version);

        /// <summary>
        /// Activate the lossless compression mode with the desired efficiency level
        /// between 0 (fastest, lowest compression) and 9 (slower, best compression).
        /// A good default level is '6', providing a fair tradeoff between compression
        /// speed and final compressed size.
        /// This function will overwrite several fields from config: 'method', 'quality'
        /// and 'lossless'. Returns false in case of parameter error.
        /// <br/>
        /// int WebPConfigLosslessPreset(WebPConfig* config, int level);
        /// </summary>
        /// <param name="config"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int WebPConfigLosslessPreset(ref WebPConfig config, int level);

        /// <summary>
        /// Returns true if 'config' is non-NULL and all configuration parameters are
        /// within their valid ranges.
        /// <br/>
        /// int WebPValidateConfig(const WebPConfig* config);
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int WebPValidateConfig(ref WebPConfig config);

        /// <summary>
        /// The following must be called first before any use.
        /// <br/>
        /// void WebPMemoryWriterInit(WebPMemoryWriter* writer);
        /// </summary>
        /// <param name="writer"></param>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate void WebPMemoryWriterInit(ref WebPMemoryWriter writer);

        /// <summary>
        /// The following must be called to deallocate writer->mem memory. The 'writer'
        /// object itself is not deallocated.
        /// <br/>
        /// void WebPMemoryWriterClear(WebPMemoryWriter* writer);
        /// </summary>
        /// <param name="writer"></param>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate void WebPMemoryWriterClear(ref WebPMemoryWriter writer);

        /// <summary>
        /// The custom writer to be used with WebPMemoryWriter as custom_ptr. Upon
        /// completion, writer.mem and writer.size will hold the coded data.
        /// writer.mem must be freed by calling WebPMemoryWriterClear.
        /// <br/>
        /// int WebPMemoryWrite(const uint8_t* data, size_t data_size, const WebPPicture* picture);
        /// </summary>
        /// <param name="data"></param>
        /// <param name="data_size"></param>
        /// <param name=""></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int WebPMemoryWrite(IntPtr data, UInt64 data_size, ref WebPPicture picture);

        /// <summary>
        /// Internal, version-checked, entry point
        /// <br/>
        /// Should always be called, to initialize the structure. Returns false in case
        /// of version mismatch. WebPPictureInit() must have succeeded before using the
        /// 'picture' object.
        /// Note that, by default, use_argb is false and colorspace is WEBP_YUV420.
        /// <br/>
        /// int WebPPictureInitInternal(WebPPicture* picture, int version);
        /// </summary>
        /// <param name="picture"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int WebPPictureInitInternal(ref WebPPicture picture, int version);

        /// <summary>
        /// Convenience allocation / deallocation based on picture->width/height:
        /// Allocate y/u/v buffers as per colorspace/width/height specification.
        /// Note! This function will free the previous buffer if needed.
        /// Returns false in case of memory error.
        /// <br/>
        /// int WebPPictureAlloc(WebPPicture* picture);
        /// </summary>
        /// <param name="picture"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int WebPPictureAlloc(ref WebPPicture picture);

        /// <summary>
        /// Release the memory allocated by WebPPictureAlloc() or WebPPictureImport*().
        /// Note that this function does _not_ free the memory used by the 'picture'
        /// object itself.
        /// Besides memory (which is reclaimed) all other fields of 'picture' are
        /// preserved.
        /// <br/>
        /// void WebPPictureFree(WebPPicture* picture);
        /// </summary>
        /// <param name="picture"></param>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate void WebPPictureFree(ref WebPPicture picture);

        /// <summary>
        /// Copy the pixels of *src into *dst, using WebPPictureAlloc. Upon return, *dst
        /// will fully own the copied pixels (this is not a view). The 'dst' picture need
        /// not be initialized as its content is overwritten.
        /// Returns false in case of memory allocation error.
        /// <br/>
        /// int WebPPictureCopy(const WebPPicture* src, WebPPicture* dst);
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int WebPPictureCopy(ref WebPPicture src, ref WebPPicture dst);

        /// <summary>
        /// Compute the single distortion for packed planes of samples.
        /// 'src' will be compared to 'ref', and the raw distortion stored into
        /// '*distortion'. The refined metric (log(MSE), log(1 - ssim),...' will be
        /// stored in '*result'.
        /// 'x_step' is the horizontal stride (in bytes) between samples.
        /// 'src/ref_stride' is the byte distance between rows.
        /// Returns false in case of error (bad parameter, memory allocation error, ...).
        /// <br/>
        /// int WebPPlaneDistortion(const uint8_t* src, size_t src_stride,
        ///                         const uint8_t* ref, size_t ref_stride,
        ///                         int width, int height,
        ///                         size_t x_step,
        ///                         int type,   // 0 = PSNR, 1 = SSIM, 2 = LSIM
        ///                         float* distortion, float* result);
        /// </summary>
        /// <param name="src"></param>
        /// <param name="src_stride"></param>
        /// <param name="ref_"></param>
        /// <param name="ref_stride"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="x_step"></param>
        /// <param name="type">0 = PSNR, 1 = SSIM, 2 = LSIM</param>
        /// <param name="distortion"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int WebPPlaneDistortion(IntPtr src, UInt64 src_stride, IntPtr reference, UInt64 ref_stride,
            int width, int height, UInt64 x_step, int type,
            ref float distortion, ref float result);

        /// <summary>
        /// Compute PSNR, SSIM or LSIM distortion metric between two pictures. Results
        /// are in dB, stored in result[] in the B/G/R/A/All order. The distortion is
        /// always performed using ARGB samples. Hence if the input is YUV(A), the
        /// picture will be internally converted to ARGB (just for the measurement).
        /// Warning: this function is rather CPU-intensive.
        /// <br/>
        /// int WebPPictureDistortion(const WebPPicture* src, const WebPPicture* ref,
        ///                           int metric_type,           // 0 = PSNR, 1 = SSIM, 2 = LSIM
        ///                           float result[5]);
        /// </summary>
        /// <param name="src"></param>
        /// <param name="ref_"></param>
        /// <param name="metric_type"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int WebPPictureDistortion(ref WebPPicture src, ref WebPPicture reference, int metric_type,
            [MarshalAs(UnmanagedType.LPArray, SizeConst = 5)] float[] result);

        /// <summary>
        /// self-crops a picture to the rectangle defined by top/left/width/height.
        /// Returns false in case of memory allocation error, or if the rectangle is
        /// outside of the source picture.
        /// The rectangle for the view is defined by the top-left corner pixel
        /// coordinates (left, top) as well as its width and height. This rectangle
        /// must be fully be comprised inside the 'src' source picture. If the source
        /// picture uses the YUV420 colorspace, the top and left coordinates will be
        /// snapped to even values.
        /// <br/>
        /// int WebPPictureCrop(WebPPicture* picture, int left, int top, int width, int height);
        /// </summary>
        /// <param name="picture"></param>
        /// <param name="left"></param>
        /// <param name="top"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int WebPPictureCrop(ref WebPPicture picture, int left, int top, int width, int height);

        /// <summary>
        /// Extracts a view from 'src' picture into 'dst'. The rectangle for the view
        /// is defined by the top-left corner pixel coordinates (left, top) as well
        /// as its width and height. This rectangle must be fully be comprised inside
        /// the 'src' source picture. If the source picture uses the YUV420 colorspace,
        /// the top and left coordinates will be snapped to even values.
        /// Picture 'src' must out-live 'dst' picture. Self-extraction of view is allowed
        /// ('src' equal to 'dst') as a mean of fast-cropping (but note that doing so,
        /// the original dimension will be lost). Picture 'dst' need not be initialized
        /// with WebPPictureInit() if it is different from 'src', since its content will
        /// be overwritten.
        /// Returns false in case of memory allocation error or invalid parameters.
        /// <br/>
        /// int WebPPictureView(const WebPPicture* src, int left, int top, int width, int height, WebPPicture* dst);
        /// </summary>
        /// <param name="src"></param>
        /// <param name="left"></param>
        /// <param name="top"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="dst"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int WebPPictureView(ref WebPPicture src, int left, int top, int width, int height, ref WebPPicture dst);

        /// <summary>
        /// Returns true if the 'picture' is actually a view and therefore does
        /// not own the memory for pixels.
        /// <br/>
        /// int WebPPictureIsView(const WebPPicture* picture);
        /// </summary>
        /// <param name="picture"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int WebPPictureIsView(ref WebPPicture picture);

        /// <summary>
        /// Rescale a picture to new dimension width x height.
        /// If either 'width' or 'height' (but not both) is 0 the corresponding
        /// dimension will be calculated preserving the aspect ratio.
        /// No gamma correction is applied.
        /// Returns false in case of error (invalid parameter or insufficient memory).
        /// <br/>
        /// int WebPPictureRescale(WebPPicture* pic, int width, int height);
        /// </summary>
        /// <param name="pic"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int WebPPictureRescale(ref WebPPicture pic, int width, int height);

        /// <summary>
        /// Colorspace conversion function to import RGB samples.
        /// Previous buffer will be free'd, if any.
        /// *rgb buffer should have a size of at least height * rgb_stride.
        /// Returns false in case of memory error.
        /// <br/>
        /// int WebPPictureImportRGB(WebPPicture* picture, const uint8_t* rgb, int rgb_stride);
        /// </summary>
        /// <param name="picture"></param>
        /// <param name="rgb"></param>
        /// <param name="rgb_stride"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int WebPPictureImportRGB(ref WebPPicture picture, IntPtr rgb, int rgb_stride);

        /// <summary>
        /// Same, but for RGBA buffer.
        /// <br/>
        /// int WebPPictureImportRGBA(WebPPicture* picture, const uint8_t* rgba, int rgba_stride);
        /// </summary>
        /// <param name="picture"></param>
        /// <param name="rgba"></param>
        /// <param name="rgba_stride"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int WebPPictureImportRGBA(ref WebPPicture picture, IntPtr rgba, int rgba_stride);

        /// <summary>
        /// Same, but for RGBA buffer. Imports the RGB direct from the 32-bit format
        /// input buffer ignoring the alpha channel. Avoids needing to copy the data
        /// to a temporary 24-bit RGB buffer to import the RGB only.
        /// <br/>
        /// int WebPPictureImportRGBX(WebPPicture* picture, const uint8_t* rgbx, int rgbx_stride);
        /// </summary>
        /// <param name="picture"></param>
        /// <param name="rgbx"></param>
        /// <param name="rgbx_stride"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int WebPPictureImportRGBX(ref WebPPicture picture, IntPtr rgbx, int rgbx_stride);

        /// <summary>
        /// Variants of the above, but taking BGR(A|X) input.
        /// <br/>
        /// int WebPPictureImportBGR(WebPPicture* picture, const uint8_t* bgr, int bgr_stride);
        /// </summary>
        /// <param name="picture"></param>
        /// <param name="bgr"></param>
        /// <param name="bgr_stride"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int WebPPictureImportBGR(ref WebPPicture picture, IntPtr bgr, int bgr_stride);

        /// <summary>
        /// int WebPPictureImportBGRA(WebPPicture* picture, const uint8_t* bgra, int bgra_stride);
        /// </summary>
        /// <param name="picture"></param>
        /// <param name="bgra"></param>
        /// <param name="bgra_stride"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int WebPPictureImportBGRA(ref WebPPicture picture, IntPtr bgra, int bgra_stride);

        /// <summary>
        /// int WebPPictureImportBGRX(WebPPicture* picture, const uint8_t* bgrx, int bgrx_stride);
        /// </summary>
        /// <param name="picture"></param>
        /// <param name="bgrx"></param>
        /// <param name="bgrx_stride"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int WebPPictureImportBGRX(ref WebPPicture picture, IntPtr bgrx, int bgrx_stride);

        /// <summary>
        /// Converts picture->argb data to the YUV420A format. The 'colorspace'
        /// parameter is deprecated and should be equal to WEBP_YUV420.
        /// Upon return, picture->use_argb is set to false. The presence of real
        /// non-opaque transparent values is detected, and 'colorspace' will be
        /// adjusted accordingly. Note that this method is lossy.
        /// Returns false in case of error.
        /// <br/>
        /// int WebPPictureARGBToYUVA(WebPPicture* picture, WebPEncCSP /*colorspace = WEBP_YUV420*/);
        /// </summary>
        /// <param name="picture"></param>
        /// <param name=""></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int WebPPictureARGBToYUVA(ref WebPPicture picture, WebPEncCSP colorspace);

        /// <summary>
        /// Same as WebPPictureARGBToYUVA(), but the conversion is done using
        /// pseudo-random dithering with a strength 'dithering' between
        /// 0.0 (no dithering) and 1.0 (maximum dithering). This is useful
        /// for photographic picture.
        /// <br/>
        /// int WebPPictureARGBToYUVADithered(WebPPicture* picture, WebPEncCSP colorspace, float dithering);
        /// </summary>
        /// <param name="picture"></param>
        /// <param name="colorspace"></param>
        /// <param name="dithering"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int WebPPictureARGBToYUVADithered(ref WebPPicture picture, WebPEncCSP colorspace, float dithering);

        /// <summary>
        /// Performs 'sharp' RGBA->YUVA420 downsampling and colorspace conversion.
        /// Downsampling is handled with extra care in case of color clipping. This
        /// method is roughly 2x slower than WebPPictureARGBToYUVA() but produces better
        /// and sharper YUV representation.
        /// Returns false in case of error.
        /// <br/>
        /// int WebPPictureSharpARGBToYUVA(WebPPicture* picture);
        /// </summary>
        /// <param name="picture"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int WebPPictureSharpARGBToYUVA(ref WebPPicture picture);

        /// <summary>
        /// kept for backward compatibility:
        /// <br/>
        /// int WebPPictureSmartARGBToYUVA(WebPPicture* picture);
        /// </summary>
        /// <param name="picture"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int WebPPictureSmartARGBToYUVA(ref WebPPicture picture);

        /// <summary>
        /// Converts picture->yuv to picture->argb and sets picture->use_argb to true.
        /// The input format must be YUV_420 or YUV_420A. The conversion from YUV420 to
        /// ARGB incurs a small loss too.
        /// Note that the use of this colorspace is discouraged if one has access to the
        /// raw ARGB samples, since using YUV420 is comparatively lossy.
        /// Returns false in case of error.
        /// <br/>
        /// int WebPPictureYUVAToARGB(WebPPicture* picture);
        /// </summary>
        /// <param name="picture"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int WebPPictureYUVAToARGB(ref WebPPicture picture);

        /// <summary>
        /// Helper function: given a width x height plane of RGBA or YUV(A) samples
        /// clean-up or smoothen the YUV or RGB samples under fully transparent area,
        /// to help compressibility (no guarantee, though).
        /// <br/>
        /// void WebPCleanupTransparentArea(WebPPicture* picture);
        /// </summary>
        /// <param name="picture"></param>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate void WebPCleanupTransparentArea(ref WebPPicture picture);

        /// <summary>
        /// Scan the picture 'picture' for the presence of non fully opaque alpha values.
        /// Returns true in such case. Otherwise returns false (indicating that the
        /// alpha plane can be ignored altogether e.g.).
        /// <br/>
        /// int WebPPictureHasTransparency(const WebPPicture* picture);
        /// </summary>
        /// <param name="picture"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int WebPPictureHasTransparency(ref WebPPicture picture);

        /// <summary>
        /// Remove the transparency information (if present) by blending the color with
        /// the background color 'background_rgb' (specified as 24bit RGB triplet).
        /// After this call, all alpha values are reset to 0xff.
        /// <br/>
        /// void WebPBlendAlpha(WebPPicture* pic, uint32_t background_rgb);
        /// </summary>
        /// <param name="pic"></param>
        /// <param name="background_rgb"></param>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate void WebPBlendAlpha(ref WebPPicture pic, UInt64 background_rgb);

        /// <summary>
        /// Main encoding call, after config and picture have been initialized.
        /// 'picture' must be less than 16384x16384 in dimension (cf WEBP_MAX_DIMENSION),
        /// and the 'config' object must be a valid one.
        /// Returns false in case of error, true otherwise.
        /// In case of error, picture->error_code is updated accordingly.
        /// 'picture' can hold the source samples in both YUV(A) or ARGB input, depending
        /// on the value of 'picture->use_argb'. It is highly recommended to use
        /// the former for lossy encoding, and the latter for lossless encoding
        /// (when config.lossless is true). Automatic conversion from one format to
        /// another is provided but they both incur some loss.
        /// <br/>
        /// int WebPEncode(const WebPConfig* config, WebPPicture* picture);
        /// </summary>
        /// <param name="config"></param>
        /// <param name="picture"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int WebPEncode(ref WebPConfig config, ref WebPPicture picture);

        #endregion

        #region utils

        /// <summary>
        /// size-checking safe malloc/calloc: verify that the requested size is not too
        /// large, or return NULL. You don't need to call these for constructs like
        /// malloc(sizeof(foo)), but only if there's picture-dependent size involved
        /// somewhere (like: malloc(num_pixels * sizeof(*something))). That's why this
        /// safe malloc() borrows the signature from calloc(), pointing at the dangerous
        /// underlying multiply involved.
        /// <br/>
        /// void* WebPSafeMalloc(uint64_t nmemb, size_t size);
        /// </summary>
        /// <param name="nmemb"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate IntPtr WebPSafeMalloc(UInt64 nmemb, UInt64 size);

        /// <summary>
        /// Note that WebPSafeCalloc() expects the second argument type to be 'size_t'
        /// in order to favor the "calloc(num_foo, sizeof(foo))" pattern.
        /// <br/>
        /// void* WebPSafeCalloc(uint64_t nmemb, size_t size);
        /// </summary>
        /// <param name="nmemb"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate IntPtr WebPSafeCalloc(UInt64 nmemb, UInt64 size);

        /// <summary>
        /// Companion deallocation function to the above allocations.
        /// <br/>
        /// void WebPSafeFree(void* const ptr);
        /// </summary>
        /// <param name="ptr"></param>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate void WebPSafeFree(IntPtr ptr);

        /// <summary>
        /// Copy width x height pixels from 'src' to 'dst' honoring the strides.
        /// <br/>
        /// void WebPCopyPlane(const uint8_t* src, int src_stride, uint8_t* dst, int dst_stride, int width, int height);
        /// </summary>
        /// <param name="src"></param>
        /// <param name="src_stride"></param>
        /// <param name="dst"></param>
        /// <param name="dst_stride"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate void WebPCopyPlane(IntPtr src, int src_stride, IntPtr dst, int dst_stride, int width, int height);

        /// <summary>
        /// Copy ARGB pixels from 'src' to 'dst' honoring strides. 'src' and 'dst' are
        /// assumed to be already allocated and using ARGB data.
        /// <br/>
        /// void WebPCopyPixels(const struct WebPPicture* const src, struct WebPPicture* const dst);
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate void WebPCopyPixels(ref WebPPicture src, ref WebPPicture dst);

        /// <summary>
        /// Returns count of unique colors in 'pic', assuming pic->use_argb is true.
        /// If the unique color count is more than MAX_PALETTE_SIZE, returns
        /// MAX_PALETTE_SIZE+1.
        /// If 'palette' is not NULL and number of unique colors is less than or equal to
        /// MAX_PALETTE_SIZE, also outputs the actual unique colors into 'palette'.
        /// Note: 'palette' is assumed to be an array already allocated with at least
        /// MAX_PALETTE_SIZE elements.
        /// <br/>
        /// int WebPGetColorPalette(const struct WebPPicture* const pic, uint32_t* const palette);
        /// </summary>
        /// <param name="pic"></param>
        /// <param name="palette"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int WebPGetColorPalette(ref WebPPicture pic, IntPtr palette);

        #endregion

        #region types

        /// <summary>
        /// Allocates 'size' bytes of memory. Returns NULL upon error. Memory
        /// must be deallocated by calling WebPFree(). This function is made available
        /// by the core 'libwebp' library.
        /// <br/>
        /// void* WebPMalloc(size_t size);
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate IntPtr WebPMalloc(UInt64 size);

        /// <summary>
        /// Releases memory returned by the WebPDecode*() functions (from decode.h).
        /// <br/>
        /// void WebPFree(void* ptr);
        /// </summary>
        /// <param name="ptr"></param>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate void WebPFree(IntPtr ptr);

        #endregion

    }
}
