using System;
using System.Runtime.InteropServices;

namespace WebP.Net.Struct
{
    //    typedef int (* VP8IoPutHook) (const VP8Io* io);
    //typedef int (* VP8IoSetupHook) (VP8Io* io);
    //typedef void (* VP8IoTeardownHook) (const VP8Io* io);
    public delegate int VP8IoPutHook(ref VP8Io io);
    public delegate int VP8IoSetupHook(ref VP8Io io);
    public delegate int VP8IoTeardownHook(ref VP8Io io);

    //  struct VP8Io
    //  {
    //      // set by VP8GetHeaders()
    //      int width, height;         // picture dimensions, in pixels (invariable).
    //                                 // These are the original, uncropped dimensions.
    //                                 // The actual area passed to put() is stored
    //                                 // in mb_w / mb_h fields.

    //      // set before calling put()
    //      int mb_y;                  // position of the current rows (in pixels)
    //      int mb_w;                  // number of columns in the sample
    //      int mb_h;                  // number of rows in the sample
    //      const uint8_t* y, *u, *v;  // rows to copy (in yuv420 format)
    //int y_stride;              // row stride for luma
    //      int uv_stride;             // row stride for chroma

    //      void* opaque;              // user data

    //      // called when fresh samples are available. Currently, samples are in
    //      // YUV420 format, and can be up to width x 24 in size (depending on the
    //      // in-loop filtering level, e.g.). Should return false in case of error
    //      // or abort request. The actual size of the area to update is mb_w x mb_h
    //      // in size, taking cropping into account.
    //      VP8IoPutHook put;

    //      // called just before starting to decode the blocks.
    //      // Must return false in case of setup error, true otherwise. If false is
    //      // returned, teardown() will NOT be called. But if the setup succeeded
    //      // and true is returned, then teardown() will always be called afterward.
    //      VP8IoSetupHook setup;

    //      // Called just after block decoding is finished (or when an error occurred
    //      // during put()). Is NOT called if setup() failed.
    //      VP8IoTeardownHook teardown;

    //      // this is a recommendation for the user-side yuv->rgb converter. This flag
    //      // is set when calling setup() hook and can be overwritten by it. It then
    //      // can be taken into consideration during the put() method.
    //      int fancy_upsampling;

    //      // Input buffer.
    //      size_t data_size;
    //      const uint8_t* data;

    //      // If true, in-loop filtering will not be performed even if present in the
    //      // bitstream. Switching off filtering may speed up decoding at the expense
    //      // of more visible blocking. Note that output will also be non-compliant
    //      // with the VP8 specifications.
    //      int bypass_filtering;

    //      // Cropping parameters.
    //      int use_cropping;
    //      int crop_left, crop_right, crop_top, crop_bottom;

    //      // Scaling parameters.
    //      int use_scaling;
    //      int scaled_width, scaled_height;

    //      // If non NULL, pointer to the alpha data (if present) corresponding to the
    //      // start of the current row (That is: it is pre-offset by mb_y and takes
    //      // cropping into account).
    //      const uint8_t* a;
    //  };

    [StructLayout(LayoutKind.Sequential)]
    public struct VP8Io
    {
        // set by VP8GetHeaders()
        public int Width, Height;         // picture dimensions, in pixels (invariable).
                                          // These are the original, uncropped dimensions.
                                          // The actual area passed to put() is stored
                                          // in mb_w / mb_h fields.

        // set before calling put()
        public int mbY;                  // position of the current rows (in pixels)
        public int mbW;                  // number of columns in the sample
        public int mbH;                  // number of rows in the sample
        public IntPtr Y, U, V;  // rows to copy (in yuv420 format)
        public int YStride;              // row stride for luma
        public int UVStride;             // row stride for chroma

        public IntPtr Opaque;              // user data

        // called when fresh samples are available. Currently, samples are in
        // YUV420 format, and can be up to width x 24 in size (depending on the
        // in-loop filtering level, e.g.). Should return false in case of error
        // or abort request. The actual size of the area to update is mb_w x mb_h
        // in size, taking cropping into account.
        public VP8IoPutHook Put;

        // called just before starting to decode the blocks.
        // Must return false in case of setup error, true otherwise. If false is
        // returned, teardown() will NOT be called. But if the setup succeeded
        // and true is returned, then teardown() will always be called afterward.
        public VP8IoSetupHook Setup;

        // Called just after block decoding is finished (or when an error occurred
        // during put()). Is NOT called if setup() failed.
        public VP8IoTeardownHook Teardown;

        // this is a recommendation for the user-side yuv->rgb converter. This flag
        // is set when calling setup() hook and can be overwritten by it. It then
        // can be taken into consideration during the put() method.
        public int FancyUpsampling;

        // Input buffer.
        public uint DataSize;
        public IntPtr Data;

        // If true, in-loop filtering will not be performed even if present in the
        // bitstream. Switching off filtering may speed up decoding at the expense
        // of more visible blocking. Note that output will also be non-compliant
        // with the VP8 specifications.
        public int BypassFiltering;

        // Cropping parameters.
        public int UseCropping;
        public int CropLeft, CropRight, CropTop, CropBottom;

        // Scaling parameters.
        public int UseScaling;
        public int ScaledWidth, ScaledHeight;

        // If non NULL, pointer to the alpha data (if present) corresponding to the
        // start of the current row (That is: it is pre-offset by mb_y and takes
        // cropping into account).
        public IntPtr A;
    }
}
