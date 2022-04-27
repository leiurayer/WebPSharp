using System.Runtime.InteropServices;

namespace WebPSharp.Struct
{
    //// Global information about the animation..
    //struct WebPAnimInfo
    //{
    //    uint32_t canvas_width;
    //    uint32_t canvas_height;
    //    uint32_t loop_count;
    //    uint32_t bgcolor;
    //    uint32_t frame_count;
    //    uint32_t pad[4];   // padding for later use
    //};

    [StructLayout(LayoutKind.Sequential)]
    public struct WebPAnimInfo
    {
        public uint CanvasWidth;
        public uint CanvasHeight;
        public uint LoopCount;
        public uint Bgcolor;
        public uint FrameCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public uint[] Pad;   // padding for later use
    }
}
