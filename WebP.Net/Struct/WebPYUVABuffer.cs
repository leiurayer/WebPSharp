using System;
using System.Runtime.InteropServices;

namespace WebP.Net.Struct
{
    //  struct WebPYUVABuffer
    //  {              // view as YUVA
    //      uint8_t* y, *u, *v, *a;     // pointer to luma, chroma U/V, alpha samples
    //int y_stride;               // luma stride
    //      int u_stride, v_stride;     // chroma strides
    //      int a_stride;               // alpha stride
    //      size_t y_size;              // luma plane size
    //      size_t u_size, v_size;      // chroma planes size
    //      size_t a_size;              // alpha-plane size
    //  };

    [StructLayout(LayoutKind.Sequential)]
    public struct WebPYUVABuffer
    {
        public IntPtr y;
        public IntPtr u;
        public IntPtr v;
        public IntPtr a;                 // pointer to luma, chroma U/V, alpha samples
        public int YStride;              // luma stride
        public int UStride, VStride;     // chroma strides
        public int AStride;              // alpha stride

        public uint YSize;               // luma plane size
        public uint USize, VSize;        // chroma planes size
        public uint ASize;               // alpha-plane size
    }
}
