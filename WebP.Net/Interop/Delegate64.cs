using System;
using System.Runtime.InteropServices;
using WebP.Net.Enum;
using WebP.Net.Struct;

namespace WebP.Net.Interop
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


        #endregion


    }
}
