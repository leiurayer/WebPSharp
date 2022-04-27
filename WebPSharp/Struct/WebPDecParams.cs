using System;
using System.Runtime.InteropServices;

namespace WebPSharp.Struct
{
    //    typedef int (* OutputFunc) (const VP8Io* const io, WebPDecParams* const p);
    //typedef int (* OutputAlphaFunc) (const VP8Io* const io, WebPDecParams* const p,
    //                               int expected_num_out_lines);
    //typedef int (* OutputRowFunc) (WebPDecParams* const p, int y_pos,
    //                             int max_out_lines);
    public delegate int OutputFunc(ref VP8Io io, ref WebPDecParams p);
    public delegate int OutputAlphaFunc(ref VP8Io io, ref WebPDecParams p, int expected_num_out_lines);
    public delegate int OutputRowFunc(ref WebPDecParams p, int y_pos, int max_out_lines);

    //  struct WebPDecParams
    //  {
    //      WebPDecBuffer* output;             // output buffer.
    //      uint8_t* tmp_y, *tmp_u, *tmp_v;    // cache for the fancy upsampler
    //                                   // or used for tmp rescaling

    //int last_y;                 // coordinate of the line that was last output
    //      const WebPDecoderOptions* options;  // if not NULL, use alt decoding features

    //      WebPRescaler* scaler_y, *scaler_u, *scaler_v, *scaler_a;  // rescalers
    //void* memory;                  // overall scratch memory for the output work.

    //      OutputFunc emit;               // output RGB or YUV samples
    //      OutputAlphaFunc emit_alpha;    // output alpha channel
    //      OutputRowFunc emit_alpha_row;  // output one line of rescaled alpha values
    //  };

    [StructLayout(LayoutKind.Sequential)]
    public struct WebPDecParams
    {
        public IntPtr Output;             // output buffer.
        public IntPtr TmpY;
        public IntPtr TmpU;
        public IntPtr TmpV;               // cache for the fancy upsampler
                                          // or used for tmp rescaling

        public int LastY;                 // coordinate of the line that was last output
        public IntPtr Options;            // if not NULL, use alt decoding features

        public IntPtr ScalerY;
        public IntPtr ScalerU;
        public IntPtr ScalerV;
        public IntPtr ScalerA;            // rescalers
        public IntPtr Memory;             // overall scratch memory for the output work.

        public OutputFunc emit;                // output RGB or YUV samples
        public OutputAlphaFunc emit_alpha;     // output alpha channel
        public OutputRowFunc emit_alpha_row;   // output one line of rescaled alpha values
    }
}
