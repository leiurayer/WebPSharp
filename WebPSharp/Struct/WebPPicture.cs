using System;
using System.Runtime.InteropServices;
using WebPSharp.Enum;

namespace WebPSharp.Struct
{

    //// Signature for output function. Should return true if writing was successful.
    //// data/data_size is the segment of data to write, and 'picture' is for
    //// reference (and so one can make use of picture->custom_ptr).
    //typedef int (* WebPWriterFunction) (const uint8_t* data, size_t data_size,
    //                              const WebPPicture* picture);
    public delegate int WebPWriterFunction(IntPtr data, uint data_size, ref WebPPicture picture);

    //// Progress hook, called from time to time to report progress. It can return
    //// false to request an abort of the encoding process, or true otherwise if
    //// everything is OK.
    //typedef int (* WebPProgressHook) (int percent, const WebPPicture* picture);
    public delegate int WebPProgressHook(int percent, ref WebPPicture picture);

    //  // Main exchange structure (input samples, output bytes, statistics)
    //  //
    //  // Once WebPPictureInit() has been called, it's ok to make all the INPUT fields
    //  // (use_argb, y/u/v, argb, ...) point to user-owned data, even if
    //  // WebPPictureAlloc() has been called. Depending on the value use_argb,
    //  // it's guaranteed that either *argb or *y/*u/*v content will be kept untouched.
    //  struct WebPPicture
    //  {
    //      //   INPUT
    //      //////////////
    //      // Main flag for encoder selecting between ARGB or YUV input.
    //      // It is recommended to use ARGB input (*argb, argb_stride) for lossless
    //      // compression, and YUV input (*y, *u, *v, etc.) for lossy compression
    //      // since these are the respective native colorspace for these formats.
    //      int use_argb;

    //      // YUV input (mostly used for input to lossy compression)
    //      WebPEncCSP colorspace;     // colorspace: should be YUV420 for now (=Y'CbCr).
    //      int width, height;         // dimensions (less or equal to WEBP_MAX_DIMENSION)
    //      uint8_t* y, *u, *v;        // pointers to luma/chroma planes.
    //int y_stride, uv_stride;   // luma/chroma strides.
    //      uint8_t* a;                // pointer to the alpha plane
    //      int a_stride;              // stride of the alpha plane
    //      uint32_t pad1[2];          // padding for later use

    //      // ARGB input (mostly used for input to lossless compression)
    //      uint32_t* argb;            // Pointer to argb (32 bit) plane.
    //      int argb_stride;           // This is stride in pixels units, not bytes.
    //      uint32_t pad2[3];          // padding for later use

    //      //   OUTPUT
    //      ///////////////
    //      // Byte-emission hook, to store compressed bytes as they are ready.
    //      WebPWriterFunction writer;  // can be NULL
    //      void* custom_ptr;           // can be used by the writer.

    //      // map for extra information (only for lossy compression mode)
    //      int extra_info_type;    // 1: intra type, 2: segment, 3: quant
    //                              // 4: intra-16 prediction mode,
    //                              // 5: chroma prediction mode,
    //                              // 6: bit cost, 7: distortion
    //      uint8_t* extra_info;    // if not NULL, points to an array of size
    //                              // ((width + 15) / 16) * ((height + 15) / 16) that
    //                              // will be filled with a macroblock map, depending
    //                              // on extra_info_type.

    //      //   STATS AND REPORTS
    //      ///////////////////////////
    //      // Pointer to side statistics (updated only if not NULL)
    //      WebPAuxStats* stats;

    //      // Error code for the latest error encountered during encoding
    //      WebPEncodingError error_code;

    //      // If not NULL, report progress during encoding.
    //      WebPProgressHook progress_hook;

    //      void* user_data;        // this field is free to be set to any value and
    //                              // used during callbacks (like progress-report e.g.).

    //      uint32_t pad3[3];       // padding for later use

    //      // Unused for now
    //      uint8_t* pad4, *pad5;
    //uint32_t pad6[8];       // padding for later use

    //      // PRIVATE FIELDS
    //      ////////////////////
    //      void* memory_;          // row chunk of memory for yuva planes
    //      void* memory_argb_;     // and for argb too.
    //      void* pad7[2];          // padding for later use
    //  };

    [StructLayout(LayoutKind.Sequential)]
    public struct WebPPicture
    {
        public int UseArgb;

        // YUV input (mostly used for input to lossy compression)
        public WebPEncCSP Colorspace;     // colorspace: should be YUV420 for now (=Y'CbCr).
        public int Width, Height;         // dimensions (less or equal to WEBP_MAX_DIMENSION)
        public IntPtr Y, U, V;        // pointers to luma/chroma planes.
        public int YStride, UVStride;   // luma/chroma strides.
        public IntPtr a;                // pointer to the alpha plane
        public int AStride;              // stride of the alpha plane
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] Pad1;          // padding for later use

        // ARGB input (mostly used for input to lossless compression)
        public IntPtr Argb;            // Pointer to argb (32 bit) plane.
        public int ArgbStride;           // This is stride in pixels units, not bytes.
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public uint[] Pad2;          // padding for later use

        //   OUTPUT
        ///////////////
        // Byte-emission hook, to store compressed bytes as they are ready.
        public WebPWriterFunction Writer;  // can be NULL
        public IntPtr CustomPtr;           // can be used by the writer.

        // map for extra information (only for lossy compression mode)
        public int ExtraInfoType;    // 1: intra type, 2: segment, 3: quant
                                     // 4: intra-16 prediction mode,
                                     // 5: chroma prediction mode,
                                     // 6: bit cost, 7: distortion
        public IntPtr ExtraInfo;    // if not NULL, points to an array of size
                                    // ((width + 15) / 16) * ((height + 15) / 16) that
                                    // will be filled with a macroblock map, depending
                                    // on extra_info_type.

        //   STATS AND REPORTS
        ///////////////////////////
        // Pointer to side statistics (updated only if not NULL)
        public IntPtr Stats;

        // Error code for the latest error encountered during encoding
        public WebPEncodingError ErrorCode;

        // If not NULL, report progress during encoding.
        public WebPProgressHook ProgressHook;

        public IntPtr UserData;        // this field is free to be set to any value and
                                       // used during callbacks (like progress-report e.g.).

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public uint[] Pad3;       // padding for later use

        // Unused for now
        public IntPtr Pad4, Pad5;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public uint[] Pad6;       // padding for later use

        // PRIVATE FIELDS
        ////////////////////
        public IntPtr Memory;          // row chunk of memory for yuva planes
        public IntPtr MemoryArgb;     // and for argb too.
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public IntPtr[] Pad7;          // padding for later use
    }
}
