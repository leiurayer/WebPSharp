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

        // maximum width/height allowed (inclusive), in pixels
        private const int WEBP_MAX_DIMENSION = 16383;

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

        public static int WebPConfigInit(ref WebPConfig config)
        {
            if (UseX86)
            {
                return WebP32.WebPConfigInitInternal(ref config, WebPPreset.WEBP_PRESET_DEFAULT, 75.0f, WEBP_ENCODER_ABI_VERSION);
            }
            else
            {
                return WebP64.WebPConfigInitInternal(ref config, WebPPreset.WEBP_PRESET_DEFAULT, 75.0f, WEBP_ENCODER_ABI_VERSION);
            }
        }

        public static int WebPConfigPreset(ref WebPConfig config, WebPPreset preset, float quality)
        {
            if (UseX86)
            {
                return WebP32.WebPConfigInitInternal(ref config, preset, quality, WEBP_ENCODER_ABI_VERSION);
            }
            else
            {
                return WebP64.WebPConfigInitInternal(ref config, preset, quality, WEBP_ENCODER_ABI_VERSION);
            }
        }

        public static int WebPConfigLosslessPreset(ref WebPConfig config, int level)
        {
            if (UseX86)
            {
                return WebP32.WebPConfigLosslessPreset(ref config, level);
            }
            else
            {
                return WebP64.WebPConfigLosslessPreset(ref config, level);
            }
        }

        public static int WebPValidateConfig(ref WebPConfig config)
        {
            if (UseX86)
            {
                return WebP32.WebPValidateConfig(ref config);
            }
            else
            {
                return WebP64.WebPValidateConfig(ref config);
            }
        }

        public static void WebPMemoryWriterInit(ref WebPMemoryWriter writer)
        {
            if (UseX86)
            {
                WebP32.WebPMemoryWriterInit(ref writer);
            }
            else
            {
                WebP64.WebPMemoryWriterInit(ref writer);
            }
        }

        public static void WebPMemoryWriterClear(ref WebPMemoryWriter writer)
        {
            if (UseX86)
            {
                WebP32.WebPMemoryWriterClear(ref writer);
            }
            else
            {
                WebP64.WebPMemoryWriterClear(ref writer);
            }
        }

        public static int WebPMemoryWrite(IntPtr data, UInt32 dataSize, ref WebPPicture picture)
        {
            if (UseX86)
            {
                return WebP32.WebPMemoryWrite(data, dataSize, ref picture);
            }
            else
            {
                UInt64 longSize = dataSize;
                return WebP64.WebPMemoryWrite(data, longSize, ref picture);
            }
        }

        public static int WebPPictureInit(ref WebPPicture picture)
        {
            if (UseX86)
            {
                return WebP32.WebPPictureInitInternal(ref picture, WEBP_ENCODER_ABI_VERSION);
            }
            else
            {
                return WebP64.WebPPictureInitInternal(ref picture, WEBP_ENCODER_ABI_VERSION);
            }
        }

        public static int WebPPictureAlloc(ref WebPPicture picture)
        {
            if (UseX86)
            {
                return WebP32.WebPPictureAlloc(ref picture);
            }
            else
            {
                return WebP64.WebPPictureAlloc(ref picture);
            }
        }

        public static void WebPPictureFree(ref WebPPicture picture)
        {
            if (UseX86)
            {
                WebP32.WebPPictureFree(ref picture);
            }
            else
            {
                WebP64.WebPPictureFree(ref picture);
            }
        }

        public static int WebPPictureCopy(ref WebPPicture src, ref WebPPicture dst)
        {
            if (UseX86)
            {
                return WebP32.WebPPictureCopy(ref src, ref dst);
            }
            else
            {
                return WebP64.WebPPictureCopy(ref src, ref dst);
            }
        }

        public static int WebPPlaneDistortion(IntPtr src, UInt32 srcStride, IntPtr reference, UInt32 refStride,
           int width, int height, UInt32 xStep, int type,
           ref float distortion, ref float result)
        {
            if (UseX86)
            {
                return WebP32.WebPPlaneDistortion(src, srcStride, reference, refStride,
                    width, height, xStep, type,
                    ref distortion, ref result);
            }
            else
            {
                UInt64 longSrcStride = srcStride;
                UInt64 longRefStride = refStride;
                UInt64 longXStep = xStep;
                return WebP64.WebPPlaneDistortion(src, longSrcStride, reference, longRefStride,
                    width, height, longXStep, type,
                    ref distortion, ref result);
            }
        }

        public static int WebPPictureDistortion(ref WebPPicture src, ref WebPPicture reference, int metric_type, ref float[] result)
        {
            if (UseX86)
            {
                return WebP32.WebPPictureDistortion(ref src, ref reference, metric_type, result);
            }
            else
            {
                return WebP64.WebPPictureDistortion(ref src, ref reference, metric_type, result);
            }
        }

        public static int WebPPictureCrop(ref WebPPicture picture, int left, int top, int width, int height)
        {
            if (UseX86)
            {
                return WebP32.WebPPictureCrop(ref picture, left, top, width, height);
            }
            else
            {
                return WebP64.WebPPictureCrop(ref picture, left, top, width, height);
            }
        }

        public static int WebPPictureView(ref WebPPicture src, int left, int top, int width, int height, ref WebPPicture dst)
        {
            if (UseX86)
            {
                return WebP32.WebPPictureView(ref src, left, top, width, height, ref dst);
            }
            else
            {
                return WebP64.WebPPictureView(ref src, left, top, width, height, ref dst);
            }
        }

        public static int WebPPictureIsView(ref WebPPicture picture)
        {
            if (UseX86)
            {
                return WebP32.WebPPictureIsView(ref picture);
            }
            else
            {
                return WebP64.WebPPictureIsView(ref picture);
            }
        }

        public static int WebPPictureRescale(ref WebPPicture pic, int width, int height)
        {
            if (UseX86)
            {
                return WebP32.WebPPictureRescale(ref pic, width, height);
            }
            else
            {
                return WebP64.WebPPictureRescale(ref pic, width, height);
            }
        }

        public static int WebPPictureImportRGB(ref WebPPicture picture, IntPtr rgb, int rgbStride)
        {
            if (UseX86)
            {
                return WebP32.WebPPictureImportRGB(ref picture, rgb, rgbStride);
            }
            else
            {
                return WebP64.WebPPictureImportRGB(ref picture, rgb, rgbStride);
            }
        }

        public static int WebPPictureImportRGBA(ref WebPPicture picture, IntPtr rgba, int rgbaStride)
        {
            if (UseX86)
            {
                return WebP32.WebPPictureImportRGBA(ref picture, rgba, rgbaStride);
            }
            else
            {
                return WebP64.WebPPictureImportRGBA(ref picture, rgba, rgbaStride);
            }
        }

        public static int WebPPictureImportRGBX(ref WebPPicture picture, IntPtr rgbx, int rgbxStride)
        {
            if (UseX86)
            {
                return WebP32.WebPPictureImportRGBX(ref picture, rgbx, rgbxStride);
            }
            else
            {
                return WebP64.WebPPictureImportRGBX(ref picture, rgbx, rgbxStride);
            }
        }

        public static int WebPPictureImportBGR(ref WebPPicture picture, IntPtr bgr, int bgrStride)
        {
            if (UseX86)
            {
                return WebP32.WebPPictureImportBGR(ref picture, bgr, bgrStride);
            }
            else
            {
                return WebP64.WebPPictureImportBGR(ref picture, bgr, bgrStride);
            }
        }

        public static int WebPPictureImportBGRA(ref WebPPicture picture, IntPtr bgra, int bgraStride)
        {
            if (UseX86)
            {
                return WebP32.WebPPictureImportBGRA(ref picture, bgra, bgraStride);
            }
            else
            {
                return WebP64.WebPPictureImportBGRA(ref picture, bgra, bgraStride);
            }
        }

        public static int WebPPictureImportBGRX(ref WebPPicture picture, IntPtr bgrx, int bgrxStride)
        {
            if (UseX86)
            {
                return WebP32.WebPPictureImportBGRX(ref picture, bgrx, bgrxStride);
            }
            else
            {
                return WebP64.WebPPictureImportBGRX(ref picture, bgrx, bgrxStride);
            }
        }

        public static int WebPPictureARGBToYUVA(ref WebPPicture picture, WebPEncCSP colorspace)
        {
            if (UseX86)
            {
                return WebP32.WebPPictureARGBToYUVA(ref picture, colorspace);
            }
            else
            {
                return WebP64.WebPPictureARGBToYUVA(ref picture, colorspace);
            }
        }

        public static int WebPPictureARGBToYUVADithered(ref WebPPicture picture, WebPEncCSP colorspace, float dithering)
        {
            if (UseX86)
            {
                return WebP32.WebPPictureARGBToYUVADithered(ref picture, colorspace, dithering);
            }
            else
            {
                return WebP64.WebPPictureARGBToYUVADithered(ref picture, colorspace, dithering);
            }
        }

        public static int WebPPictureSharpARGBToYUVA(ref WebPPicture picture)
        {
            if (UseX86)
            {
                return WebP32.WebPPictureSharpARGBToYUVA(ref picture);
            }
            else
            {
                return WebP64.WebPPictureSharpARGBToYUVA(ref picture);
            }
        }

        public static int WebPPictureSmartARGBToYUVA(ref WebPPicture picture)
        {
            if (UseX86)
            {
                return WebP32.WebPPictureSmartARGBToYUVA(ref picture);
            }
            else
            {
                return WebP64.WebPPictureSmartARGBToYUVA(ref picture);
            }
        }

        public static int WebPPictureYUVAToARGB(ref WebPPicture picture)
        {
            if (UseX86)
            {
                return WebP32.WebPPictureYUVAToARGB(ref picture);
            }
            else
            {
                return WebP64.WebPPictureYUVAToARGB(ref picture);
            }
        }

        public static void WebPCleanupTransparentArea(ref WebPPicture picture)
        {
            if (UseX86)
            {
                WebP32.WebPCleanupTransparentArea(ref picture);
            }
            else
            {
                WebP64.WebPCleanupTransparentArea(ref picture);
            }
        }

        public static int WebPPictureHasTransparency(ref WebPPicture picture)
        {
            if (UseX86)
            {
                return WebP32.WebPPictureHasTransparency(ref picture);
            }
            else
            {
                return WebP64.WebPPictureHasTransparency(ref picture);
            }
        }

        public static void WebPBlendAlpha(ref WebPPicture pic, UInt32 backgroundRgb)
        {
            if (UseX86)
            {
                WebP32.WebPBlendAlpha(ref pic, backgroundRgb);
            }
            else
            {
                UInt64 longRgb = backgroundRgb;
                WebP64.WebPBlendAlpha(ref pic, longRgb);
            }
        }

        public static int WebPEncode(ref WebPConfig config, ref WebPPicture picture)
        {
            if (UseX86)
            {
                return WebP32.WebPEncode(ref config, ref picture);
            }
            else
            {
                return WebP64.WebPEncode(ref config, ref picture);
            }
        }

        #endregion

        #region utils

        public static IntPtr WebPSafeMalloc(UInt64 nmemb, UInt32 size)
        {
            if (UseX86)
            {
                return WebP32.WebPSafeMalloc(nmemb, size);
            }
            else
            {
                UInt64 longSize = size;
                return WebP64.WebPSafeMalloc(nmemb, longSize);
            }
        }

        public static IntPtr WebPSafeCalloc(UInt64 nmemb, UInt32 size)
        {
            if (UseX86)
            {
                return WebP32.WebPSafeCalloc(nmemb, size);
            }
            else
            {
                UInt64 longSize = size;
                return WebP64.WebPSafeCalloc(nmemb, longSize);
            }
        }

        public static void WebPSafeFree(IntPtr ptr)
        {
            if (UseX86)
            {
                WebP32.WebPSafeFree(ptr);
            }
            else
            {
                WebP64.WebPSafeFree(ptr);
            }
        }

        public static void WebPCopyPlane(IntPtr src, int srcStride, IntPtr dst, int dstStride, int width, int height)
        {
            if (UseX86)
            {
                WebP32.WebPCopyPlane(src, srcStride, dst, dstStride, width, height);
            }
            else
            {
                WebP64.WebPCopyPlane(src, srcStride, dst, dstStride, width, height);
            }
        }

        public static void WebPCopyPixels(ref WebPPicture src, ref WebPPicture dst)
        {
            if (UseX86)
            {
                WebP32.WebPCopyPixels(ref src, ref dst);
            }
            else
            {
                WebP64.WebPCopyPixels(ref src, ref dst);
            }
        }

        public static int WebPGetColorPalette(ref WebPPicture pic, IntPtr palette)
        {
            if (UseX86)
            {
                return WebP32.WebPGetColorPalette(ref pic, palette);
            }
            else
            {
                return WebP64.WebPGetColorPalette(ref pic, palette);
            }
        }

        #endregion

        #region types

        public static IntPtr WebPMalloc(UInt32 size)
        {
            if (UseX86)
            {
                return WebP32.WebPMalloc(size);
            }
            else
            {
                UInt64 longSize = size;
                return WebP64.WebPMalloc(longSize);
            }
        }

        public static void WebPFree(IntPtr ptr)
        {
            if (UseX86)
            {
                WebP32.WebPFree(ptr);
            }
            else
            {
                WebP64.WebPFree(ptr);
            }
        }

        #endregion



    }
}
