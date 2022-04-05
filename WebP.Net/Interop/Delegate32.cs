using System;
using System.Runtime.InteropServices;

namespace WebP.Net.Interop
{
    internal class Delegate32
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
        internal delegate int WebPGetInfo(IntPtr data, UInt32 data_size, ref int width, ref int height);

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
        internal delegate IntPtr WebPDecodeRGBA(IntPtr data, UInt32 data_size, ref int width, ref int height);

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
        internal delegate IntPtr WebPDecodeARGB(IntPtr data, UInt32 data_size, ref int width, ref int height);

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
        internal delegate IntPtr WebPDecodeBGRA(IntPtr data, UInt32 data_size, ref int width, ref int height);

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
        internal delegate IntPtr WebPDecodeRGB(IntPtr data, UInt32 data_size, ref int width, ref int height);

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
        internal delegate IntPtr WebPDecodeBGR(IntPtr data, UInt32 data_size, ref int width, ref int height);


        #endregion


        //#region VP8 decode

        //[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        //internal delegate int VP8CheckSignature([MarshalAs(UnmanagedType.LPArray)] byte[] data, UInt32 data_size);

        //[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        //internal delegate int VP8GetInfo([MarshalAs(UnmanagedType.LPArray)] byte[] data, UInt32 data_size, UInt32 chunk_size, ref int width, ref int height);

        //[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        //internal delegate int VP8LCheckSignature([MarshalAs(UnmanagedType.LPArray)] byte[] data, UInt32 data_size);

        //[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        //internal delegate int VP8LGetInfo([MarshalAs(UnmanagedType.LPArray)] byte[] data, UInt32 data_size, ref int width, ref int height, ref int has_alpha);

        //#endregion

        //#region VP8 dsp
        //[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        //internal delegate int VP8GetCPUInfo(CPUFeature feature);
        //#endregion

        //#region WebP encode

        //[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        //internal delegate void WebPBlendAlpha(ref WebPPicture pic, uint background_rgb);

        //#endregion

    }
}
