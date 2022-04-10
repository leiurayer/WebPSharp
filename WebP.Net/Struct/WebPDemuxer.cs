using System;
using System.Runtime.InteropServices;
using WebP.Net.Enum;

namespace WebP.Net.Struct
{
    //struct WebPDemuxer
    //{
    //    MemBuffer mem_;
    //    WebPDemuxState state_;
    //    int is_ext_format_;
    //    uint32_t feature_flags_;
    //    int canvas_width_, canvas_height_;
    //    int loop_count_;
    //    uint32_t bgcolor_;
    //    int num_frames_;
    //    Frame* frames_;
    //    Frame** frames_tail_;
    //    Chunk* chunks_;  // non-image chunks
    //    Chunk** chunks_tail_;
    //};

    [StructLayout(LayoutKind.Sequential)]
    public struct WebPDemuxer
    {
        public MemBuffer Mem;
        public WebPDemuxState State;
        public int IsExtFormat;
        public uint FeatureFlags;
        public int CanvasWidth, CanvasHeight;
        public int LoopCount;
        public uint Bgcolor;
        public int NumFrames;
        public IntPtr Frames_;
        public IntPtr FramesTail;
        public IntPtr Chunks;  // non-image chunks
        public IntPtr ChunksTail;
    }
}
