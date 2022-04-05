using System;
using System.Runtime.InteropServices;
using WebP.Net.Enum;
using WebP.Net.Struct;

namespace WebP.Net.Interop
{
    internal class Delegate32
    {
        #region VP8 decode

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int VP8CheckSignature([MarshalAs(UnmanagedType.LPArray)] byte[] data, UInt32 data_size);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int VP8GetInfo([MarshalAs(UnmanagedType.LPArray)] byte[] data, UInt32 data_size, UInt32 chunk_size, ref int width, ref int height);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int VP8LCheckSignature([MarshalAs(UnmanagedType.LPArray)] byte[] data, UInt32 data_size);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int VP8LGetInfo([MarshalAs(UnmanagedType.LPArray)] byte[] data, UInt32 data_size, ref int width, ref int height, ref int has_alpha);

        #endregion

        #region VP8 dsp
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate int VP8GetCPUInfo(CPUFeature feature);
        #endregion

        #region WebP encode

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate void WebPBlendAlpha(ref WebPPicture pic, uint background_rgb);


        #endregion


    }
}
