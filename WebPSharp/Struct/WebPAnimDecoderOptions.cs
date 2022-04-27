using System.Runtime.InteropServices;
using WebPSharp.Enum;

namespace WebPSharp.Struct
{
    //// Global options.
    //struct WebPAnimDecoderOptions
    //{
    //    // Output colorspace. Only the following modes are supported:
    //    // MODE_RGBA, MODE_BGRA, MODE_rgbA and MODE_bgrA.
    //    WEBP_CSP_MODE color_mode;
    //    int use_threads;           // If true, use multi-threaded decoding.
    //    uint32_t padding[7];       // Padding for later use.
    //};


    [StructLayout(LayoutKind.Sequential)]
    public struct WebPAnimDecoderOptions
    {
        // Output colorspace. Only the following modes are supported:
        // MODE_RGBA, MODE_BGRA, MODE_rgbA and MODE_bgrA.
        public WEBP_CSP_MODE ColorMode;
        public int UseThreads;           // If true, use multi-threaded decoding.
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
        public uint[] Padding;       // Padding for later use.
    }
}
