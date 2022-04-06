using System;
using WebP.Net.Enum;
using WebP.Net.Interop;
using WebP.Net.Struct;

namespace WebP.Net
{
    public class LibWebP
    {
        private const int WEBP_DECODER_ABI_VERSION = 0x0209;

        private static readonly bool UseX86 = IntPtr.Size == 4;

        #region WebP decode

        public static int WebPGetDecoderVersion()
        {
            if (UseX86)
            {
                return WebP32.WebPGetDecoderVersion();
            }
            else
            {
                return WebP64.WebPGetDecoderVersion();
            }
        }

        public static int WebPGetInfo(IntPtr data, UInt32 size, ref int width, ref int height)
        {
            if (UseX86)
            {
                return WebP32.WebPGetInfo(data, size, ref width, ref height);
            }
            else
            {
                UInt64 longSize = size;
                return WebP64.WebPGetInfo(data, longSize, ref width, ref height);
            }
        }

        public static IntPtr WebPDecodeRGBA(IntPtr data, UInt32 size, ref int width, ref int height)
        {
            if (UseX86)
            {
                return WebP32.WebPDecodeRGBA(data, size, ref width, ref height);
            }
            else
            {
                UInt64 longSize = size;
                return WebP64.WebPDecodeRGBA(data, longSize, ref width, ref height);
            }
        }

        public static IntPtr WebPDecodeARGB(IntPtr data, UInt32 size, ref int width, ref int height)
        {
            if (UseX86)
            {
                return WebP32.WebPDecodeARGB(data, size, ref width, ref height);
            }
            else
            {
                UInt64 longSize = size;
                return WebP64.WebPDecodeARGB(data, longSize, ref width, ref height);
            }
        }

        public static IntPtr WebPDecodeBGRA(IntPtr data, UInt32 size, ref int width, ref int height)
        {
            if (UseX86)
            {
                return WebP32.WebPDecodeBGRA(data, size, ref width, ref height);
            }
            else
            {
                UInt64 longSize = size;
                return WebP64.WebPDecodeBGRA(data, longSize, ref width, ref height);
            }
        }

        public static IntPtr WebPDecodeRGB(IntPtr data, UInt32 size, ref int width, ref int height)
        {
            if (UseX86)
            {
                return WebP32.WebPDecodeRGB(data, size, ref width, ref height);
            }
            else
            {
                UInt64 longSize = size;
                return WebP64.WebPDecodeRGB(data, longSize, ref width, ref height);
            }
        }

        public static IntPtr WebPDecodeBGR(IntPtr data, UInt32 size, ref int width, ref int height)
        {
            if (UseX86)
            {
                return WebP32.WebPDecodeBGR(data, size, ref width, ref height);
            }
            else
            {
                UInt64 longSize = size;
                return WebP64.WebPDecodeBGR(data, longSize, ref width, ref height);
            }
        }

        public static IntPtr WebPDecodeYUV(IntPtr data, UInt32 size, ref int width, ref int height,
            ref IntPtr u, ref IntPtr v, ref int stride, ref int uvStride)
        {
            if (UseX86)
            {
                return WebP32.WebPDecodeYUV(data, size, ref width, ref height, ref u, ref v, ref stride, ref uvStride);
            }
            else
            {
                UInt64 longSize = size;
                return WebP64.WebPDecodeYUV(data, longSize, ref width, ref height, ref u, ref v, ref stride, ref uvStride);
            }
        }

        public static IntPtr WebPDecodeRGBAInto(IntPtr data, UInt32 size,
            IntPtr outputBuffer, UInt32 outputBufferSize, int outputStride)
        {
            if (UseX86)
            {
                return WebP32.WebPDecodeRGBAInto(data, size, outputBuffer, outputBufferSize, outputStride);
            }
            else
            {
                UInt64 longSize = size;
                return WebP64.WebPDecodeRGBAInto(data, longSize, outputBuffer, outputBufferSize, outputStride);
            }
        }

        public static IntPtr WebPDecodeARGBInto(IntPtr data, UInt32 size,
            IntPtr outputBuffer, UInt32 outputBufferSize, int outputStride)
        {
            if (UseX86)
            {
                return WebP32.WebPDecodeARGBInto(data, size, outputBuffer, outputBufferSize, outputStride);
            }
            else
            {
                UInt64 longSize = size;
                return WebP64.WebPDecodeARGBInto(data, longSize, outputBuffer, outputBufferSize, outputStride);
            }
        }

        public static IntPtr WebPDecodeBGRAInto(IntPtr data, UInt32 size,
           IntPtr outputBuffer, UInt32 outputBufferSize, int outputStride)
        {
            if (UseX86)
            {
                return WebP32.WebPDecodeBGRAInto(data, size, outputBuffer, outputBufferSize, outputStride);
            }
            else
            {
                UInt64 longSize = size;
                return WebP64.WebPDecodeBGRAInto(data, longSize, outputBuffer, outputBufferSize, outputStride);
            }
        }

        public static IntPtr WebPDecodeRGBInto(IntPtr data, UInt32 size,
          IntPtr outputBuffer, UInt32 outputBufferSize, int outputStride)
        {
            if (UseX86)
            {
                return WebP32.WebPDecodeRGBInto(data, size, outputBuffer, outputBufferSize, outputStride);
            }
            else
            {
                UInt64 longSize = size;
                return WebP64.WebPDecodeRGBInto(data, longSize, outputBuffer, outputBufferSize, outputStride);
            }
        }

        public static IntPtr WebPDecodeBGRInto(IntPtr data, UInt32 size,
          IntPtr outputBuffer, UInt32 outputBufferSize, int outputStride)
        {
            if (UseX86)
            {
                return WebP32.WebPDecodeBGRInto(data, size, outputBuffer, outputBufferSize, outputStride);
            }
            else
            {
                UInt64 longSize = size;
                return WebP64.WebPDecodeBGRInto(data, longSize, outputBuffer, outputBufferSize, outputStride);
            }
        }

        public static IntPtr WebPDecodeYUVInto(IntPtr data, UInt32 size,
            IntPtr luma, UInt32 lumaSize, int lumaStride,
            IntPtr u, UInt32 uSize, int uStride,
            IntPtr v, UInt32 vSize, int vStride)
        {
            if (UseX86)
            {
                return WebP32.WebPDecodeYUVInto(data, size, luma, lumaSize, lumaStride,
                    u, uSize, uStride, v, vSize, vStride);
            }
            else
            {
                UInt64 longSize = size;
                UInt64 longLumaSize = lumaSize;
                UInt64 longUSize = uSize;
                UInt64 longVSize = vSize;
                return WebP64.WebPDecodeYUVInto(data, longSize, luma, longLumaSize, lumaStride,
                    u, longUSize, uStride, v, longVSize, vStride);
            }
        }

        public static VP8StatusCode WebPGetFeatures(IntPtr data, UInt32 size, ref WebPBitstreamFeatures features)
        {
            if (UseX86)
            {
                return WebP32.WebPGetFeaturesInternal(data, size, ref features, WEBP_DECODER_ABI_VERSION);
            }
            else
            {
                UInt64 longSize = size;
                return WebP64.WebPGetFeaturesInternal(data, longSize, ref features, WEBP_DECODER_ABI_VERSION);
            }
        }

        #endregion


    }
}
