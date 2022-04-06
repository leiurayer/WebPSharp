using System.Runtime.InteropServices;

namespace WebP.Net.Struct
{
    //// Features gathered from the bitstream
    //struct WebPBitstreamFeatures
    //{
    //    int width;          // Width in pixels, as read from the bitstream.
    //    int height;         // Height in pixels, as read from the bitstream.
    //    int has_alpha;      // True if the bitstream contains an alpha channel.
    //    int has_animation;  // True if the bitstream is an animation.
    //    int format;         // 0 = undefined (/mixed), 1 = lossy, 2 = lossless

    //    uint32_t pad[5];    // padding for later use
    //};

    [StructLayout(LayoutKind.Sequential)]
    public struct WebPBitstreamFeatures
    {
        public int Width;          // Width in pixels, as read from the bitstream.
        public int Height;         // Height in pixels, as read from the bitstream.
        public int HasAlpha;      // True if the bitstream contains an alpha channel.
        public int HasAnimation;  // True if the bitstream is an animation.
        public int Format;         // 0 = undefined (/mixed), 1 = lossy, 2 = lossless

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public uint[] Pad;    // padding for later use
    }
}
