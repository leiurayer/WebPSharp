using System;
using System.Runtime.InteropServices;

namespace WebPSharp.Struct
{
    //    // MuxImage object. Store a full WebP image (including ANMF chunk, ALPH
    //    // chunk and VP8/VP8L chunk),
    //    typedef struct WebPMuxImage WebPMuxImage;
    //struct WebPMuxImage
    //    {
    //        WebPChunk* header_;      // Corresponds to WEBP_CHUNK_ANMF.
    //        WebPChunk* alpha_;       // Corresponds to WEBP_CHUNK_ALPHA.
    //        WebPChunk* img_;         // Corresponds to WEBP_CHUNK_IMAGE.
    //        WebPChunk* unknown_;     // Corresponds to WEBP_CHUNK_UNKNOWN.
    //        int width_;
    //        int height_;
    //        int has_alpha_;   // Through ALPH chunk or as part of VP8L.
    //        int is_partial_;  // True if only some of the chunks are filled.
    //        WebPMuxImage* next_;
    //    };

    [StructLayout(LayoutKind.Sequential)]
    public struct WebPMuxImage
    {
        public IntPtr Header;      // Corresponds to WEBP_CHUNK_ANMF.
        public IntPtr Alpha;       // Corresponds to WEBP_CHUNK_ALPHA.
        public IntPtr Img;         // Corresponds to WEBP_CHUNK_IMAGE.
        public IntPtr Unknown;     // Corresponds to WEBP_CHUNK_UNKNOWN.
        public int Width;
        public int Height;
        public int HasAlpha;   // Through ALPH chunk or as part of VP8L.
        public int IsPartial;  // True if only some of the chunks are filled.
        public IntPtr Next;
    }
}
