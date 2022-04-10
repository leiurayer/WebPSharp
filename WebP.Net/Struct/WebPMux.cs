using System;
using System.Runtime.InteropServices;

namespace WebP.Net.Struct
{
    //// Main mux object. Stores data chunks.
    //struct WebPMux
    //{
    //    WebPMuxImage* images_;
    //    WebPChunk* iccp_;
    //    WebPChunk* exif_;
    //    WebPChunk* xmp_;
    //    WebPChunk* anim_;
    //    WebPChunk* vp8x_;

    //    WebPChunk* unknown_;
    //    int canvas_width_;
    //    int canvas_height_;
    //};

    [StructLayout(LayoutKind.Sequential)]
    public struct WebPMux
    {
        public IntPtr Images;
        public IntPtr Iccp;
        public IntPtr Exif;
        public IntPtr Xmp;
        public IntPtr Anim;
        public IntPtr Vp8x;

        public IntPtr Unknown;
        public int CanvasWidth;
        public int CanvasHeight;
    }
}
