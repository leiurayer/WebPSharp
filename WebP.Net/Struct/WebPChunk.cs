using System;
using System.Runtime.InteropServices;

namespace WebP.Net.Struct
{
    //    // Chunk object.
    //    typedef struct WebPChunk WebPChunk;
    //struct WebPChunk
    //    {
    //        uint32_t tag_;
    //        int owner_;  // True if *data_ memory is owned internally.
    //                     // VP8X, ANIM, and other internally created chunks
    //                     // like ANMF are always owned.
    //        WebPData data_;
    //        WebPChunk* next_;
    //    };

    [StructLayout(LayoutKind.Sequential)]
    public struct WebPChunk
    {
        public uint Tag;
        public int Owner;  // True if *data_ memory is owned internally.
                           // VP8X, ANIM, and other internally created chunks
                           // like ANMF are always owned.
        public WebPData Data;
        public IntPtr Next;
    }
}
