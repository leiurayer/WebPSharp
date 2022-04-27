using System;
using System.Runtime.InteropServices;
using WebPSharp.Enum;

namespace WebPSharp.Struct
{
    //    // Output buffer
    //    struct WebPDecBuffer
    //    {
    //        WEBP_CSP_MODE colorspace;  // Colorspace.
    //        int width, height;         // Dimensions.
    //        int is_external_memory;    // If non-zero, 'internal_memory' pointer is not
    //                                   // used. If value is '2' or more, the external
    //                                   // memory is considered 'slow' and multiple
    //                                   // read/write will be avoided.
    //        union {
    //    WebPRGBABuffer RGBA;
    //        WebPYUVABuffer YUVA;
    //    }
    //    u;                       // Nameless union of buffer parameters.
    //  uint32_t pad[4];     // padding for later use

    //    uint8_t* private_memory;   // Internally allocated memory (only when
    //                               // is_external_memory is 0). Should not be used
    //                               // externally, but accessed via the buffer union.
    //};

    [StructLayout(LayoutKind.Sequential)]
    public struct WebPDecBuffer
    {
        public WEBP_CSP_MODE Colorspace;                            // Colorspace.
        public int Width, Height;                                   // Dimensions.
        public int IsExternalMemory;                                // If non-zero, 'internal_memory' pointer is not

        public Anonymous_b5071054_b6f3_11ec_b909_0242ac120002 u;    // Nameless union of buffer parameters.

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public uint[] Pad;                                          // padding for later use

        public IntPtr PrivateMemory;                                // Internally allocated memory (only when
                                                                    // is_external_memory is 0). Should not be used
                                                                    // externally, but accessed via the buffer union.
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_b5071054_b6f3_11ec_b909_0242ac120002
    {
        [FieldOffset(0)]
        public WebPRGBABuffer RGBA;

        [FieldOffset(0)]
        public WebPYUVABuffer YUVA;
    }
}
