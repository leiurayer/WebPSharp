using System;
using System.Runtime.InteropServices;
using WebP.Net.Enum;

namespace WebP.Net.Struct
{
    //struct WebPIterator
    //{
    //    int frame_num;
    //    int num_frames;          // equivalent to WEBP_FF_FRAME_COUNT.
    //    int x_offset, y_offset;  // offset relative to the canvas.
    //    int width, height;       // dimensions of this frame.
    //    int duration;            // display duration in milliseconds.
    //    WebPMuxAnimDispose dispose_method;  // dispose method for the frame.
    //    int complete;   // true if 'fragment' contains a full frame. partial images
    //                    // may still be decoded with the WebP incremental decoder.
    //    WebPData fragment;  // The frame given by 'frame_num'. Note for historical
    //                        // reasons this is called a fragment.
    //    int has_alpha;      // True if the frame contains transparency.
    //    WebPMuxAnimBlend blend_method;  // Blend operation for the frame.

    //    uint32_t pad[2];         // padding for later use.
    //    void* private_;          // for internal use only.
    //};

    [StructLayout(LayoutKind.Sequential)]
    public struct WebPIterator
    {
        public int FrameNum;
        public int NumFrames;          // equivalent to WEBP_FF_FRAME_COUNT.
        public int XOffset, YOffset;  // offset relative to the canvas.
        public int Width, Height;       // dimensions of this frame.
        public int Duration;            // display duration in milliseconds.
        public WebPMuxAnimDispose DisposeMethod;  // dispose method for the frame.
        public int Complete;   // true if 'fragment' contains a full frame. partial images
                               // may still be decoded with the WebP incremental decoder.
        public WebPData Fragment;  // The frame given by 'frame_num'. Note for historical
                                   // reasons this is called a fragment.
        public int HasAlpha;      // True if the frame contains transparency.
        public WebPMuxAnimBlend BlendMethod;  // Blend operation for the frame.

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] Pad;         // padding for later use.
        public IntPtr Private;          // for internal use only.
    }
}
