using System.Runtime.InteropServices;

namespace WebP.Net.Struct
{
    // Decoding options
    //struct WebPDecoderOptions
    //{
    //    int bypass_filtering;               // if true, skip the in-loop filtering
    //    int no_fancy_upsampling;            // if true, use faster pointwise upsampler
    //    int use_cropping;                   // if true, cropping is applied _first_
    //    int crop_left, crop_top;            // top-left position for cropping.
    //                                        // Will be snapped to even values.
    //    int crop_width, crop_height;        // dimension of the cropping area
    //    int use_scaling;                    // if true, scaling is applied _afterward_
    //    int scaled_width, scaled_height;    // final resolution
    //    int use_threads;                    // if true, use multi-threaded decoding
    //    int dithering_strength;             // dithering strength (0=Off, 100=full)
    //    int flip;                           // if true, flip output vertically
    //    int alpha_dithering_strength;       // alpha dithering strength in [0..100]

    //    uint32_t pad[5];                    // padding for later use
    //};

    [StructLayout(LayoutKind.Sequential)]
    public struct WebPDecoderOptions
    {
        public int BypassFiltering;               // if true, skip the in-loop filtering
        public int NoFancyUpsampling;             // if true, use faster pointwise upsampler
        public int UseCropping;                   // if true, cropping is applied _first_
        public int CropLeft, CropTop;             // top-left position for cropping.
                                                  // Will be snapped to even values.
        public int CropWidth, cropHeight;         // dimension of the cropping area
        public int UseScaling;                    // if true, scaling is applied _afterward_
        public int ScaledWidth, ScaledHeight;     // final resolution
        public int UseThreads;                    // if true, use multi-threaded decoding
        public int DitheringStrength;             // dithering strength (0=Off, 100=full)
        public int Flip;                          // if true, flip output vertically
        public int AlphaDitheringStrength;        // alpha dithering strength in [0..100]

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public uint[] Pad;                        // padding for later use
    }
}
