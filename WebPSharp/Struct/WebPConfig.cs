using System.Runtime.InteropServices;
using WebPSharp.Enum;

namespace WebPSharp.Struct
{
    // Compression parameters.
    //struct WebPConfig
    //{
    //    int lossless;           // Lossless encoding (0=lossy(default), 1=lossless).
    //    float quality;          // between 0 and 100. For lossy, 0 gives the smallest
    //                            // size and 100 the largest. For lossless, this
    //                            // parameter is the amount of effort put into the
    //                            // compression: 0 is the fastest but gives larger
    //                            // files compared to the slowest, but best, 100.
    //    int method;             // quality/speed trade-off (0=fast, 6=slower-better)

    //    WebPImageHint image_hint;  // Hint for image type (lossless only for now).

    //    int target_size;        // if non-zero, set the desired target size in bytes.
    //                            // Takes precedence over the 'compression' parameter.
    //    float target_PSNR;      // if non-zero, specifies the minimal distortion to
    //                            // try to achieve. Takes precedence over target_size.
    //    int segments;           // maximum number of segments to use, in [1..4]
    //    int sns_strength;       // Spatial Noise Shaping. 0=off, 100=maximum.
    //    int filter_strength;    // range: [0 = off .. 100 = strongest]
    //    int filter_sharpness;   // range: [0 = off .. 7 = least sharp]
    //    int filter_type;        // filtering type: 0 = simple, 1 = strong (only used
    //                            // if filter_strength > 0 or autofilter > 0)
    //    int autofilter;         // Auto adjust filter's strength [0 = off, 1 = on]
    //    int alpha_compression;  // Algorithm for encoding the alpha plane (0 = none,
    //                            // 1 = compressed with WebP lossless). Default is 1.
    //    int alpha_filtering;    // Predictive filtering method for alpha plane.
    //                            //  0: none, 1: fast, 2: best. Default if 1.
    //    int alpha_quality;      // Between 0 (smallest size) and 100 (lossless).
    //                            // Default is 100.
    //    int pass;               // number of entropy-analysis passes (in [1..10]).

    //    int show_compressed;    // if true, export the compressed picture back.
    //                            // In-loop filtering is not applied.
    //    int preprocessing;      // preprocessing filter:
    //                            // 0=none, 1=segment-smooth, 2=pseudo-random dithering
    //    int partitions;         // log2(number of token partitions) in [0..3]. Default
    //                            // is set to 0 for easier progressive decoding.
    //    int partition_limit;    // quality degradation allowed to fit the 512k limit
    //                            // on prediction modes coding (0: no degradation,
    //                            // 100: maximum possible degradation).
    //    int emulate_jpeg_size;  // If true, compression parameters will be remapped
    //                            // to better match the expected output size from
    //                            // JPEG compression. Generally, the output size will
    //                            // be similar but the degradation will be lower.
    //    int thread_level;       // If non-zero, try and use multi-threaded encoding.
    //    int low_memory;         // If set, reduce memory usage (but increase CPU use).

    //    int near_lossless;      // Near lossless encoding [0 = max loss .. 100 = off
    //                            // (default)].
    //    int exact;              // if non-zero, preserve the exact RGB values under
    //                            // transparent area. Otherwise, discard this invisible
    //                            // RGB information for better compression. The default
    //                            // value is 0.

    //    int use_delta_palette;  // reserved for future lossless feature
    //    int use_sharp_yuv;      // if needed, use sharp (and slow) RGB->YUV conversion

    //    int qmin;               // minimum permissible quality factor
    //    int qmax;               // maximum permissible quality factor
    //};

    [StructLayout(LayoutKind.Sequential)]
    public struct WebPConfig
    {
        public int Lossless;           // Lossless encoding (0=lossy(default), 1=lossless).
        public float Quality;          // between 0 and 100. For lossy, 0 gives the smallest
                                       // size and 100 the largest. For lossless, this
                                       // parameter is the amount of effort put into the
                                       // compression: 0 is the fastest but gives larger
                                       // files compared to the slowest, but best, 100.
        public int Method;             // quality/speed trade-off (0=fast, 6=slower-better)

        public WebPImageHint ImageHint;  // Hint for image type (lossless only for now).

        public int TargetSize;        // if non-zero, set the desired target size in bytes.
                                      // Takes precedence over the 'compression' parameter.
        public float TargetPSNR;      // if non-zero, specifies the minimal distortion to
                                      // try to achieve. Takes precedence over target_size.
        public int Segments;           // maximum number of segments to use, in [1..4]
        public int SnsStrength;       // Spatial Noise Shaping. 0=off, 100=maximum.
        public int FilterStrength;    // range: [0 = off .. 100 = strongest]
        public int FilterSharpness;   // range: [0 = off .. 7 = least sharp]
        public int FilterType;        // filtering type: 0 = simple, 1 = strong (only used
                                      // if filter_strength > 0 or autofilter > 0)
        public int AutoFilter;         // Auto adjust filter's strength [0 = off, 1 = on]
        public int AlphaCompression;  // Algorithm for encoding the alpha plane (0 = none,
                                      // 1 = compressed with WebP lossless). Default is 1.
        public int AlphaFiltering;    // Predictive filtering method for alpha plane.
                                      //  0: none, 1: fast, 2: best. Default if 1.
        public int AlphaQuality;      // Between 0 (smallest size) and 100 (lossless).
                                      // Default is 100.
        public int Pass;               // number of entropy-analysis passes (in [1..10]).

        public int ShowCompressed;    // if true, export the compressed picture back.
                                      // In-loop filtering is not applied.
        public int Preprocessing;      // preprocessing filter:
                                       // 0=none, 1=segment-smooth, 2=pseudo-random dithering
        public int Partitions;         // log2(number of token partitions) in [0..3]. Default
                                       // is set to 0 for easier progressive decoding.
        public int PartitionLimit;    // quality degradation allowed to fit the 512k limit
                                      // on prediction modes coding (0: no degradation,
                                      // 100: maximum possible degradation).
        public int EmulateJpegSize;  // If true, compression parameters will be remapped
                                     // to better match the expected output size from
                                     // JPEG compression. Generally, the output size will
                                     // be similar but the degradation will be lower.
        public int ThreadLevel;       // If non-zero, try and use multi-threaded encoding.
        public int LowMemory;         // If set, reduce memory usage (but increase CPU use).

        public int NearLossless;      // Near lossless encoding [0 = max loss .. 100 = off
                                      // (default)].
        public int Exact;              // if non-zero, preserve the exact RGB values under
                                       // transparent area. Otherwise, discard this invisible
                                       // RGB information for better compression. The default
                                       // value is 0.

        public int UseDeltaPalette;  // reserved for future lossless feature
        public int UseSharpYuv;      // if needed, use sharp (and slow) RGB->YUV conversion

        public int Qmin;               // minimum permissible quality factor
        public int Qmax;               // maximum permissible quality factor
    }
}
