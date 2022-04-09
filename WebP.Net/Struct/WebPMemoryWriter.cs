using System;
using System.Runtime.InteropServices;

namespace WebP.Net.Struct
{
    //// WebPMemoryWrite: a special WebPWriterFunction that writes to memory using
    //// the following WebPMemoryWriter object (to be set as a custom_ptr).
    //struct WebPMemoryWriter
    //{
    //    uint8_t* mem;       // final buffer (of size 'max_size', larger than 'size').
    //    size_t size;      // final size
    //    size_t max_size;  // total capacity
    //    uint32_t pad[1];    // padding for later use
    //};

    [StructLayout(LayoutKind.Sequential)]
    public struct WebPMemoryWriter
    {
        IntPtr Mem;       // final buffer (of size 'max_size', larger than 'size').
        uint Size;      // final size
        uint MaxSize;  // total capacity
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        uint[] Pad;    // padding for later use
    }
}
