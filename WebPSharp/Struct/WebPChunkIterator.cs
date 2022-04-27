using System;
using System.Runtime.InteropServices;

namespace WebPSharp.Struct
{
    //struct WebPChunkIterator
    //{
    //    // The current and total number of chunks with the fourcc given to
    //    // WebPDemuxGetChunk().
    //    int chunk_num;
    //    int num_chunks;
    //    WebPData chunk;    // The payload of the chunk.

    //    uint32_t pad[6];   // padding for later use
    //    void* private_;
    //};

    [StructLayout(LayoutKind.Sequential)]
    public struct WebPChunkIterator
    {
        // The current and total number of chunks with the fourcc given to
        // WebPDemuxGetChunk().
        public int ChunkNum;
        public int NumChunks;
        public WebPData Chunk;    // The payload of the chunk.

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public uint[] Pad;   // padding for later use
        public IntPtr Private;
    }
}
