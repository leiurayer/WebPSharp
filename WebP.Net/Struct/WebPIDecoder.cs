using System;
using System.Runtime.InteropServices;
using WebP.Net.Enum;

namespace WebP.Net.Struct
{
    //struct WebPIDecoder
    //{
    //    DecState state_;         // current decoding state
    //    WebPDecParams params_;   // Params to store output info
    //    int is_lossless_;        // for down-casting 'dec_'.
    //    void* dec_;              // either a VP8Decoder or a VP8LDecoder instance
    //    VP8Io io_;

    //    MemBuffer mem_;          // input memory buffer.
    //    WebPDecBuffer output_;   // output buffer (when no external one is supplied,
    //                             // or if the external one has slow-memory)
    //    WebPDecBuffer* final_output_;  // Slow-memory output to copy to eventually.
    //    size_t chunk_size_;      // Compressed VP8/VP8L size extracted from Header.

    //    int last_mb_y_;          // last row reached for intra-mode decoding
    //};

    [StructLayout(LayoutKind.Sequential)]
    public struct WebPIDecoder
    {
        public DecState State;         // current decoding state
        public WebPDecParams Params;   // Params to store output info
        public int IsLossless;         // for down-casting 'dec_'.
        public IntPtr Dec;             // either a VP8Decoder or a VP8LDecoder instance
        public VP8Io Io;

        public MemBuffer Mem;          // input memory buffer.
        public WebPDecBuffer Output;   // output buffer (when no external one is supplied,
                                       // or if the external one has slow-memory)
        public IntPtr FinalOutput;     // Slow-memory output to copy to eventually.
        public uint ChunkSize;         // Compressed VP8/VP8L size extracted from Header.

        public int Last;          // last row reached for intra-mode decoding
    }
}
