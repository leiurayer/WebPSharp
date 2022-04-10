using System;
using System.Runtime.InteropServices;

namespace WebP.Net.Struct
{
    //typedef void (* BlendRowFunc) (uint32_t* const, const uint32_t* const, int);
    public delegate void BlendRowFunc(IntPtr src, IntPtr dst, int num_pixels);

    //struct WebPAnimDecoder
    //{
    //    WebPDemuxer* demux_;             // Demuxer created from given WebP bitstream.
    //    WebPDecoderConfig config_;       // Decoder config.
    //                                     // Note: we use a pointer to a function blending multiple pixels at a time to
    //                                     // allow possible inlining of per-pixel blending function.
    //    BlendRowFunc blend_func_;        // Pointer to the chose blend row function.
    //    WebPAnimInfo info_;              // Global info about the animation.
    //    uint8_t* curr_frame_;            // Current canvas (not disposed).
    //    uint8_t* prev_frame_disposed_;   // Previous canvas (properly disposed).
    //    int prev_frame_timestamp_;       // Previous frame timestamp (milliseconds).
    //    WebPIterator prev_iter_;         // Iterator object for previous frame.
    //    int prev_frame_was_keyframe_;    // True if previous frame was a keyframe.
    //    int next_frame_;                 // Index of the next frame to be decoded
    //                                     // (starting from 1).
    //};

    [StructLayout(LayoutKind.Sequential)]
    public struct WebPAnimDecoder
    {
        public IntPtr Demux;             // Demuxer created from given WebP bitstream.
        public WebPDecoderConfig Config;       // Decoder config.
                                               // Note: we use a pointer to a function blending multiple pixels at a time to
                                               // allow possible inlining of per-pixel blending function.
        public BlendRowFunc BlendFunc;        // Pointer to the chose blend row function.
        public WebPAnimInfo Info;              // Global info about the animation.
        public IntPtr CurrFrame;            // Current canvas (not disposed).
        public IntPtr PrevFrameDisposed;   // Previous canvas (properly disposed).
        public int PrevFrameTimestamp;       // Previous frame timestamp (milliseconds).
        public WebPIterator PrevIter;         // Iterator object for previous frame.
        public int PrevFrameWasKeyframe;    // True if previous frame was a keyframe.
        public int NextFrame;                 // Index of the next frame to be decoded
                                              // (starting from 1).
    }
}
