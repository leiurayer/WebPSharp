using System;
using System.Runtime.InteropServices;

namespace WebP.Net.Struct
{
    //    typedef struct Chunk
    //    {
    //        ChunkData data_;
    //        struct Chunk* next_;
    //}Chunk;

    [StructLayout(LayoutKind.Sequential)]
    public struct Chunk
    {
        public ChunkData Data;
        public IntPtr Next;
    }
}
