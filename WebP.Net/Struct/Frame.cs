using System;
using System.Runtime.InteropServices;
using WebP.Net.Enum;

namespace WebP.Net.Struct
{
    //    typedef struct Frame
    //    {
    //        int x_offset_, y_offset_;
    //        int width_, height_;
    //        int has_alpha_;
    //        int duration_;
    //        WebPMuxAnimDispose dispose_method_;
    //        WebPMuxAnimBlend blend_method_;
    //        int frame_num_;
    //        int complete_;   // img_components_ contains a full image.
    //        ChunkData img_components_[2];  // 0=VP8{,L} 1=ALPH
    //        struct Frame* next_;
    //}Frame;

    [StructLayout(LayoutKind.Sequential)]
    public struct Frame
    {
        public int XOffset, YOffset;
        public int Width, Height;
        public int HasAlpha;
        public int Duration;
        public WebPMuxAnimDispose DisposeMethod;
        public WebPMuxAnimBlend BlendMethod;
        public int FrameNum;
        public int Complete;   // img_components_ contains a full image.
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public ChunkData[] ImgComponents;  // 0=VP8{,L} 1=ALPH
        public IntPtr Next;
    }
}
