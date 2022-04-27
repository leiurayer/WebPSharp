using System.Runtime.InteropServices;
using WebPSharp.Enum;

namespace WebPSharp.Struct
{
    //// Encapsulates data about a single frame.
    //struct WebPMuxFrameInfo
    //{
    //    WebPData bitstream;  // image data: can be a raw VP8/VP8L bitstream
    //                         // or a single-image WebP file.
    //    int x_offset;   // x-offset of the frame.
    //    int y_offset;   // y-offset of the frame.
    //    int duration;   // duration of the frame (in milliseconds).

    //    WebPChunkId id;         // frame type: should be one of WEBP_CHUNK_ANMF
    //                            // or WEBP_CHUNK_IMAGE
    //    WebPMuxAnimDispose dispose_method;  // Disposal method for the frame.
    //    WebPMuxAnimBlend blend_method;    // Blend operation for the frame.
    //    uint32_t pad[1];     // padding for later use
    //};

    [StructLayout(LayoutKind.Sequential)]
    public struct WebPMuxFrameInfo
    {
        public WebPData Bitstream;  // image data: can be a raw VP8/VP8L bitstream
                                    // or a single-image WebP file.
        public int XOffset;   // x-offset of the frame.
        public int YOffset;   // y-offset of the frame.
        public int Duration;   // duration of the frame (in milliseconds).

        public WebPChunkId id;         // frame type: should be one of WEBP_CHUNK_ANMF
                                       // or WEBP_CHUNK_IMAGE
        public WebPMuxAnimDispose DisposeMethod;  // Disposal method for the frame.
        public WebPMuxAnimBlend BlendMethod;    // Blend operation for the frame.

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public uint[] Pad;     // padding for later use
    }
}
