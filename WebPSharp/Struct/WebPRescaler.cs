using System;
using System.Runtime.InteropServices;

namespace WebPSharp.Struct
{
    //    // Structure used for on-the-fly rescaling
    //    typedef uint32_t rescaler_t;   // type for side-buffer
    //    struct WebPRescaler
    //    {
    //        int x_expand;               // true if we're expanding in the x direction
    //        int y_expand;               // true if we're expanding in the y direction
    //        int num_channels;           // bytes to jump between pixels
    //        uint32_t fx_scale;          // fixed-point scaling factors
    //        uint32_t fy_scale;          // ''
    //        uint32_t fxy_scale;         // ''
    //        int y_accum;                // vertical accumulator
    //        int y_add, y_sub;           // vertical increments
    //        int x_add, x_sub;           // horizontal increments
    //        int src_width, src_height;  // source dimensions
    //        int dst_width, dst_height;  // destination dimensions
    //        int src_y, dst_y;           // row counters for input and output
    //        uint8_t* dst;
    //        int dst_stride;
    //        rescaler_t* irow, *frow;    // work buffer
    //};

    [StructLayout(LayoutKind.Sequential)]
    public struct WebPRescaler
    {
        public int XExpand;               // true if we're expanding in the x direction
        public int YExpand;               // true if we're expanding in the y direction
        public int NumChannels;           // bytes to jump between pixels
        public uint FxScale;          // fixed-point scaling factors
        public uint FyScale;          // ''
        public uint FxyScale;         // ''
        public int YAccum;                // vertical accumulator
        public int YAdd, YSub;           // vertical increments
        public int XAdd, XSub;           // horizontal increments
        public int SrcWidth, SrcHeight;  // source dimensions
        public int DstWidth, DstHeight;  // destination dimensions
        public int SrcY, dstY;           // row counters for input and output
        public IntPtr Dst;
        public int DstStride;
        public IntPtr Irow, Frow;    // work buffer
    }
}
