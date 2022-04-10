using System.Runtime.InteropServices;

namespace WebP.Net.Struct
{
    //// Animation parameters.
    //struct WebPMuxAnimParams
    //{
    //    uint32_t bgcolor;  // Background color of the canvas stored (in MSB order) as:
    //                       // Bits 00 to 07: Alpha.
    //                       // Bits 08 to 15: Red.
    //                       // Bits 16 to 23: Green.
    //                       // Bits 24 to 31: Blue.
    //    int loop_count;    // Number of times to repeat the animation [0 = infinite].
    //};

    [StructLayout(LayoutKind.Sequential)]
    public struct WebPMuxAnimParams
    {
        public uint Bgcolor;  // Background color of the canvas stored (in MSB order) as:
                              // Bits 00 to 07: Alpha.
                              // Bits 08 to 15: Red.
                              // Bits 16 to 23: Green.
                              // Bits 24 to 31: Blue.
        public int LoopCount;    // Number of times to repeat the animation [0 = infinite]
    }
}
