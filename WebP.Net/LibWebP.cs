using System;
using WebP.Net.Enum;
using WebP.Net.Interop;
using WebP.Net.Struct;

namespace WebP.Net
{
    public class LibWebP
    {
        private const int WEBP_DECODER_ABI_VERSION = 0x0209;
        private const int WEBP_ENCODER_ABI_VERSION = 0x020f;

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

        public static int WebPInitDecBuffer(ref WebPDecBuffer buffer)
        {
            if (UseX86)
            {
                return WebP32.WebPInitDecBufferInternal(ref buffer, WEBP_DECODER_ABI_VERSION);
            }
            else
            {
                return WebP64.WebPInitDecBufferInternal(ref buffer, WEBP_DECODER_ABI_VERSION);
            }
        }

        public static void WebPFreeDecBuffer(ref WebPDecBuffer buffer)
        {
            if (UseX86)
            {
                WebP32.WebPFreeDecBuffer(ref buffer);
            }
            else
            {
                WebP64.WebPFreeDecBuffer(ref buffer);
            }
        }

        public static IntPtr WebPINewDecoder(ref WebPDecBuffer outputBuffer)
        {
            if (UseX86)
            {
                return WebP32.WebPINewDecoder(ref outputBuffer);
            }
            else
            {
                return WebP64.WebPINewDecoder(ref outputBuffer);
            }
        }

        public static IntPtr WebPINewRGB(WEBP_CSP_MODE csp, IntPtr outputBuffer, UInt32 outputBufferSize, int outputStride)
        {
            if (UseX86)
            {
                return WebP32.WebPINewRGB(csp, outputBuffer, outputBufferSize, outputStride);
            }
            else
            {
                UInt64 longSize = outputBufferSize;
                return WebP64.WebPINewRGB(csp, outputBuffer, longSize, outputStride);
            }
        }

        public static IntPtr WebPINewYUVA(IntPtr luma, UInt32 lumaSize, int lumaStride,
            IntPtr u, UInt32 uSize, int uStride,
            IntPtr v, UInt32 vSize, int vStride,
            IntPtr a, UInt32 aSize, int aStride)
        {
            if (UseX86)
            {
                return WebP32.WebPINewYUVA(luma, lumaSize, lumaStride,
                    u, uSize, uStride,
                    v, vSize, vStride,
                    a, aSize, aStride);
            }
            else
            {
                UInt64 longLumaSize = lumaSize;
                UInt64 longUSize = uSize;
                UInt64 longVSize = vSize;
                UInt64 longASize = aSize;
                return WebP64.WebPINewYUVA(luma, longLumaSize, lumaStride,
                    u, longUSize, uStride,
                    v, longVSize, vStride,
                    a, longASize, aStride);
            }
        }

        public static IntPtr WebPINewYUV(IntPtr luma, UInt32 lumaSize, int lumaStride,
            IntPtr u, UInt32 uSize, int uStride,
            IntPtr v, UInt32 vSize, int vStride)
        {
            if (UseX86)
            {
                return WebP32.WebPINewYUV(luma, lumaSize, lumaStride,
                    u, uSize, uStride,
                    v, vSize, vStride);
            }
            else
            {
                UInt64 longLumaSize = lumaSize;
                UInt64 longUSize = uSize;
                UInt64 longVSize = vSize;
                return WebP64.WebPINewYUV(luma, longLumaSize, lumaStride,
                    u, longUSize, uStride,
                    v, longVSize, vStride);
            }
        }

        public static void WebPIDelete(ref WebPIDecoder idec)
        {
            if (UseX86)
            {
                WebP32.WebPIDelete(ref idec);
            }
            else
            {
                WebP64.WebPIDelete(ref idec);
            }
        }

        public static VP8StatusCode WebPIAppend(ref WebPIDecoder idec, IntPtr data, UInt32 dataSize)
        {
            if (UseX86)
            {
                return WebP32.WebPIAppend(ref idec, data, dataSize);
            }
            else
            {
                UInt64 longSize = dataSize;
                return WebP64.WebPIAppend(ref idec, data, longSize);
            }
        }

        public static VP8StatusCode WebPIUpdate(ref WebPIDecoder idec, IntPtr data, UInt32 dataSize)
        {
            if (UseX86)
            {
                return WebP32.WebPIUpdate(ref idec, data, dataSize);
            }
            else
            {
                UInt64 longSize = dataSize;
                return WebP64.WebPIUpdate(ref idec, data, longSize);
            }
        }

        public static IntPtr WebPIDecGetRGB(ref WebPIDecoder idec, ref int lastY, ref int width, ref int height, ref int stride)
        {
            if (UseX86)
            {
                return WebP32.WebPIDecGetRGB(ref idec, ref lastY, ref width, ref height, ref stride);
            }
            else
            {
                return WebP64.WebPIDecGetRGB(ref idec, ref lastY, ref width, ref height, ref stride);
            }
        }

        public static IntPtr WebPIDecGetYUVA(ref WebPIDecoder idec, ref int lastY,
            IntPtr u, IntPtr v, IntPtr a,
            ref int width, ref int height, ref int stride, ref int uvStride, ref int aStride)
        {
            if (UseX86)
            {
                return WebP32.WebPIDecGetYUVA(ref idec, ref lastY, u, v, a,
                    ref width, ref height, ref stride, ref uvStride, ref aStride);
            }
            else
            {
                return WebP64.WebPIDecGetYUVA(ref idec, ref lastY, u, v, a,
                    ref width, ref height, ref stride, ref uvStride, ref aStride);
            }
        }

        public static IntPtr WebPIDecodedArea(ref WebPIDecoder idec, ref int left, ref int top, ref int width, ref int height)
        {
            if (UseX86)
            {
                return WebP32.WebPIDecodedArea(ref idec, ref left, ref top, ref width, ref height);
            }
            else
            {
                return WebP64.WebPIDecodedArea(ref idec, ref left, ref top, ref width, ref height);
            }
        }

        public static VP8StatusCode WebPGetFeatures(IntPtr data, UInt32 dataSize, ref WebPBitstreamFeatures features)
        {
            if (UseX86)
            {
                return WebP32.WebPGetFeaturesInternal(data, dataSize, ref features, WEBP_DECODER_ABI_VERSION);
            }
            else
            {
                UInt64 longSize = dataSize;
                return WebP64.WebPGetFeaturesInternal(data, longSize, ref features, WEBP_DECODER_ABI_VERSION);
            }
        }

        public static int WebPInitDecoderConfig(ref WebPDecoderConfig config)
        {
            if (UseX86)
            {
                return WebP32.WebPInitDecoderConfigInternal(ref config, WEBP_DECODER_ABI_VERSION);
            }
            else
            {
                return WebP64.WebPInitDecoderConfigInternal(ref config, WEBP_DECODER_ABI_VERSION);
            }
        }

        public static IntPtr WebPIDecode(IntPtr data, UInt32 dataSize, ref WebPDecoderConfig config)
        {
            if (UseX86)
            {
                return WebP32.WebPIDecode(data, dataSize, ref config);
            }
            else
            {
                UInt64 longSize = dataSize;
                return WebP64.WebPIDecode(data, longSize, ref config);
            }
        }

        public static VP8StatusCode WebPDecode(IntPtr data, UInt32 dataSize, ref WebPDecoderConfig config)
        {
            if (UseX86)
            {
                return WebP32.WebPDecode(data, dataSize, ref config);
            }
            else
            {
                UInt64 longSize = dataSize;
                return WebP64.WebPDecode(data, longSize, ref config);
            }
        }

        #endregion

        #region WebP encode

        public static int WebPGetEncoderVersion()
        {
            if (UseX86)
            {
                return WebP32.WebPGetEncoderVersion();
            }
            else
            {
                return WebP64.WebPGetEncoderVersion();
            }
        }

        public static UInt32 WebPEncodeRGB(IntPtr rgb,
                                 int width, int height, int stride,
                                 float qualityFactor, IntPtr output)
        {
            if (UseX86)
            {
                return WebP32.WebPEncodeRGB(rgb, width, height, stride, qualityFactor, output);
            }
            else
            {
                return (uint)WebP64.WebPEncodeRGB(rgb, width, height, stride, qualityFactor, output);
            }
        }

        public static UInt32 WebPEncodeBGR(IntPtr bgr,
                           int width, int height, int stride,
                           float qualityFactor, IntPtr output)
        {
            if (UseX86)
            {
                return WebP32.WebPEncodeBGR(bgr, width, height, stride, qualityFactor, output);
            }
            else
            {
                return (uint)WebP64.WebPEncodeBGR(bgr, width, height, stride, qualityFactor, output);
            }
        }

        public static UInt32 WebPEncodeRGBA(IntPtr rgba,
                           int width, int height, int stride,
                           float qualityFactor, IntPtr output)
        {
            if (UseX86)
            {
                return WebP32.WebPEncodeRGBA(rgba, width, height, stride, qualityFactor, output);
            }
            else
            {
                return (uint)WebP64.WebPEncodeRGBA(rgba, width, height, stride, qualityFactor, output);
            }
        }

        public static UInt32 WebPEncodeBGRA(IntPtr bgra,
                          int width, int height, int stride,
                          float qualityFactor, IntPtr output)
        {
            if (UseX86)
            {
                return WebP32.WebPEncodeBGRA(bgra, width, height, stride, qualityFactor, output);
            }
            else
            {
                return (uint)WebP64.WebPEncodeBGRA(bgra, width, height, stride, qualityFactor, output);
            }
        }

        public static UInt32 WebPEncodeLosslessRGB(IntPtr rgb,
                          int width, int height, int stride, IntPtr output)
        {
            if (UseX86)
            {
                return WebP32.WebPEncodeLosslessRGB(rgb, width, height, stride, output);
            }
            else
            {
                return (uint)WebP64.WebPEncodeLosslessRGB(rgb, width, height, stride, output);
            }
        }

        public static UInt32 WebPEncodeLosslessBGR(IntPtr bgr,
                           int width, int height, int stride, IntPtr output)
        {
            if (UseX86)
            {
                return WebP32.WebPEncodeLosslessBGR(bgr, width, height, stride, output);
            }
            else
            {
                return (uint)WebP64.WebPEncodeLosslessBGR(bgr, width, height, stride, output);
            }
        }

        public static UInt32 WebPEncodeLosslessRGBA(IntPtr rgba,
                           int width, int height, int stride, IntPtr output)
        {
            if (UseX86)
            {
                return WebP32.WebPEncodeLosslessRGBA(rgba, width, height, stride, output);
            }
            else
            {
                return (uint)WebP64.WebPEncodeLosslessRGBA(rgba, width, height, stride, output);
            }
        }

        public static UInt32 WebPEncodeLosslessBGRA(IntPtr bgra,
                          int width, int height, int stride, IntPtr output)
        {
            if (UseX86)
            {
                return WebP32.WebPEncodeLosslessBGRA(bgra, width, height, stride, output);
            }
            else
            {
                return (uint)WebP64.WebPEncodeLosslessBGRA(bgra, width, height, stride, output);
            }
        }

        #endregion

    }
}
