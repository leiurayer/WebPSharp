using System;
using System.Runtime.InteropServices;
using WebPSharp.Enum;

namespace WebPSharp.Struct
{
    //    // storage for partition #0 and partial data (in a rolling fashion)
    //    typedef struct {
    //  MemBufferMode mode_;  // Operation mode
    //    size_t start_;        // start location of the data to be decoded
    //    size_t end_;          // end location
    //    size_t buf_size_;     // size of the allocated buffer
    //    uint8_t* buf_;        // We don't own this buffer in case WebPIUpdate()

    //    size_t part0_size_;         // size of partition #0
    //    const uint8_t* part0_buf_;  // buffer to store partition #0
    //}
    //MemBuffer;

    [StructLayout(LayoutKind.Sequential)]
    public struct MemBuffer
    {
        public MemBufferMode Mode;  // Operation mode
        public uint Start;          // start location of the data to be decoded
        public uint End;            // end location
        public uint BufSize;        // size of the allocated buffer
        public IntPtr Buf;          // We don't own this buffer in case WebPIUpdate()

        public uint Part0Size;      // size of partition #0
        public IntPtr Part0Buf;     // buffer to store partition #0
    }
}
