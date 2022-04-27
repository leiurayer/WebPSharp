using System.Runtime.InteropServices;

namespace WebPSharp.Struct
{
    //// Main object storing the configuration for advanced decoding.
    //struct WebPDecoderConfig
    //{
    //    WebPBitstreamFeatures input;  // Immutable bitstream features (optional)
    //    WebPDecBuffer output;         // Output buffer (can point to external mem)
    //    WebPDecoderOptions options;   // Decoding options
    //};

    [StructLayout(LayoutKind.Sequential)]
    public struct WebPDecoderConfig
    {
        public WebPBitstreamFeatures Input;  // Immutable bitstream features (optional)
        public WebPDecBuffer Output;         // Output buffer (can point to external mem)
        public WebPDecoderOptions Options;   // Decoding options
    }
}
