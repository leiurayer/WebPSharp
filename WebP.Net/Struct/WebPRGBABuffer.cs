using System;
using System.Runtime.InteropServices;

namespace WebP.Net.Struct
{
    //struct WebPRGBABuffer
    //{    // view as RGBA
    //    uint8_t* rgba;    // pointer to RGBA samples
    //    int stride;       // stride in bytes from one scanline to the next.
    //    size_t size;      // total size of the *rgba buffer.
    //};

    [StructLayout(LayoutKind.Sequential)]
    public struct WebPRGBABuffer
    {
        public IntPtr Rgba;    // pointer to RGBA samples
        public int Stride;     // stride in bytes from one scanline to the next.
        public uint Size;      // total size of the *rgba buffer.
    }
}
