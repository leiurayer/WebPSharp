using System;
using System.Runtime.InteropServices;

namespace WebP.Net.Struct
{
    //// Data type used to describe 'raw' data, e.g., chunk data
    //// (ICC profile, metadata) and WebP compressed image data.
    //// 'bytes' memory must be allocated using WebPMalloc() and such.
    //struct WebPData
    //{
    //    const uint8_t* bytes;
    //    size_t size;
    //};

    [StructLayout(LayoutKind.Sequential)]
    public struct WebPData
    {
        public IntPtr bytes;
        public uint size;
    }
}
