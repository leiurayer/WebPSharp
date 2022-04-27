namespace WebPSharp.Interop
{
    internal class WebP32
    {
        static WebP32()
        {
            var path = LibPathBootStrapper.LibPath;
            NativeLibraryLoader nl = new NativeLibraryLoader(path);

            #region WebP decode
            nl.FillDelegate(out WebPGetDecoderVersion);
            nl.FillDelegate(out WebPGetInfo);
            nl.FillDelegate(out WebPDecodeRGBA);
            nl.FillDelegate(out WebPDecodeARGB);
            nl.FillDelegate(out WebPDecodeBGRA);
            nl.FillDelegate(out WebPDecodeRGB);
            nl.FillDelegate(out WebPDecodeBGR);
            nl.FillDelegate(out WebPDecodeYUV);

            nl.FillDelegate(out WebPDecodeRGBAInto);
            nl.FillDelegate(out WebPDecodeARGBInto);
            nl.FillDelegate(out WebPDecodeBGRAInto);
            nl.FillDelegate(out WebPDecodeRGBInto);
            nl.FillDelegate(out WebPDecodeBGRInto);
            nl.FillDelegate(out WebPDecodeYUVInto);

            nl.FillDelegate(out WebPInitDecBufferInternal);
            nl.FillDelegate(out WebPFreeDecBuffer);

            nl.FillDelegate(out WebPINewDecoder);
            nl.FillDelegate(out WebPINewRGB);
            nl.FillDelegate(out WebPINewYUVA);
            nl.FillDelegate(out WebPINewYUV);

            nl.FillDelegate(out WebPIDelete);
            nl.FillDelegate(out WebPIAppend);
            nl.FillDelegate(out WebPIUpdate);

            nl.FillDelegate(out WebPIDecGetRGB);
            nl.FillDelegate(out WebPIDecGetYUVA);
            nl.FillDelegate(out WebPIDecodedArea);

            nl.FillDelegate(out WebPGetFeaturesInternal);
            nl.FillDelegate(out WebPInitDecoderConfigInternal);

            nl.FillDelegate(out WebPIDecode);
            nl.FillDelegate(out WebPDecode);
            #endregion

            #region WebP encode
            nl.FillDelegate(out WebPGetEncoderVersion);

            nl.FillDelegate(out WebPEncodeRGB);
            nl.FillDelegate(out WebPEncodeBGR);
            nl.FillDelegate(out WebPEncodeRGBA);
            nl.FillDelegate(out WebPEncodeBGRA);

            nl.FillDelegate(out WebPEncodeLosslessRGB);
            nl.FillDelegate(out WebPEncodeLosslessBGR);
            nl.FillDelegate(out WebPEncodeLosslessRGBA);
            nl.FillDelegate(out WebPEncodeLosslessBGRA);

            nl.FillDelegate(out WebPConfigInitInternal);
            nl.FillDelegate(out WebPConfigLosslessPreset);
            nl.FillDelegate(out WebPValidateConfig);
            nl.FillDelegate(out WebPMemoryWriterInit);
            nl.FillDelegate(out WebPMemoryWriterClear);
            nl.FillDelegate(out WebPMemoryWrite);
            nl.FillDelegate(out WebPPictureInitInternal);

            nl.FillDelegate(out WebPPictureAlloc);
            nl.FillDelegate(out WebPPictureFree);
            nl.FillDelegate(out WebPPictureCopy);
            nl.FillDelegate(out WebPPlaneDistortion);
            nl.FillDelegate(out WebPPictureDistortion);
            nl.FillDelegate(out WebPPictureCrop);
            nl.FillDelegate(out WebPPictureView);
            nl.FillDelegate(out WebPPictureIsView);
            nl.FillDelegate(out WebPPictureRescale);

            nl.FillDelegate(out WebPPictureImportRGB);
            nl.FillDelegate(out WebPPictureImportRGBA);
            nl.FillDelegate(out WebPPictureImportRGBX);
            nl.FillDelegate(out WebPPictureImportBGR);
            nl.FillDelegate(out WebPPictureImportBGRA);
            nl.FillDelegate(out WebPPictureImportBGRX);
            nl.FillDelegate(out WebPPictureARGBToYUVA);
            nl.FillDelegate(out WebPPictureARGBToYUVADithered);
            nl.FillDelegate(out WebPPictureSharpARGBToYUVA);
            nl.FillDelegate(out WebPPictureSmartARGBToYUVA);
            nl.FillDelegate(out WebPPictureYUVAToARGB);
            nl.FillDelegate(out WebPCleanupTransparentArea);
            nl.FillDelegate(out WebPPictureHasTransparency);
            nl.FillDelegate(out WebPBlendAlpha);

            nl.FillDelegate(out WebPEncode);
            #endregion

            #region utils
            nl.FillDelegate(out WebPSafeMalloc);
            nl.FillDelegate(out WebPSafeCalloc);
            nl.FillDelegate(out WebPSafeFree);

            nl.FillDelegate(out WebPCopyPlane);
            nl.FillDelegate(out WebPCopyPixels);
            nl.FillDelegate(out WebPGetColorPalette);
            #endregion

            #region types
            nl.FillDelegate(out WebPMalloc);
            nl.FillDelegate(out WebPFree);
            #endregion

        }

        #region WebP decode
        internal static Delegate32.WebPGetDecoderVersion WebPGetDecoderVersion;
        internal static Delegate32.WebPGetInfo WebPGetInfo;
        internal static Delegate32.WebPDecodeRGBA WebPDecodeRGBA;
        internal static Delegate32.WebPDecodeRGBA WebPDecodeARGB;
        internal static Delegate32.WebPDecodeRGBA WebPDecodeBGRA;
        internal static Delegate32.WebPDecodeRGBA WebPDecodeRGB;
        internal static Delegate32.WebPDecodeRGBA WebPDecodeBGR;
        internal static Delegate32.WebPDecodeYUV WebPDecodeYUV;

        internal static Delegate32.WebPDecodeRGBAInto WebPDecodeRGBAInto;
        internal static Delegate32.WebPDecodeARGBInto WebPDecodeARGBInto;
        internal static Delegate32.WebPDecodeBGRAInto WebPDecodeBGRAInto;
        internal static Delegate32.WebPDecodeRGBInto WebPDecodeRGBInto;
        internal static Delegate32.WebPDecodeBGRInto WebPDecodeBGRInto;
        internal static Delegate32.WebPDecodeYUVInto WebPDecodeYUVInto;

        internal static Delegate32.WebPInitDecBufferInternal WebPInitDecBufferInternal;
        internal static Delegate32.WebPFreeDecBuffer WebPFreeDecBuffer;

        internal static Delegate32.WebPINewDecoder WebPINewDecoder;
        internal static Delegate32.WebPINewRGB WebPINewRGB;
        internal static Delegate32.WebPINewYUVA WebPINewYUVA;
        internal static Delegate32.WebPINewYUV WebPINewYUV;

        internal static Delegate32.WebPIDelete WebPIDelete;
        internal static Delegate32.WebPIAppend WebPIAppend;
        internal static Delegate32.WebPIUpdate WebPIUpdate;

        internal static Delegate32.WebPIDecGetRGB WebPIDecGetRGB;
        internal static Delegate32.WebPIDecGetYUVA WebPIDecGetYUVA;
        internal static Delegate32.WebPIDecodedArea WebPIDecodedArea;

        internal static Delegate32.WebPGetFeaturesInternal WebPGetFeaturesInternal;
        internal static Delegate32.WebPInitDecoderConfigInternal WebPInitDecoderConfigInternal;

        internal static Delegate32.WebPIDecode WebPIDecode;
        internal static Delegate32.WebPDecode WebPDecode;
        #endregion

        #region WebP encode
        internal static Delegate32.WebPGetEncoderVersion WebPGetEncoderVersion;

        internal static Delegate32.WebPEncodeRGB WebPEncodeRGB;
        internal static Delegate32.WebPEncodeBGR WebPEncodeBGR;
        internal static Delegate32.WebPEncodeRGBA WebPEncodeRGBA;
        internal static Delegate32.WebPEncodeBGRA WebPEncodeBGRA;

        internal static Delegate32.WebPEncodeLosslessRGB WebPEncodeLosslessRGB;
        internal static Delegate32.WebPEncodeLosslessBGR WebPEncodeLosslessBGR;
        internal static Delegate32.WebPEncodeLosslessRGBA WebPEncodeLosslessRGBA;
        internal static Delegate32.WebPEncodeLosslessBGRA WebPEncodeLosslessBGRA;

        internal static Delegate32.WebPConfigInitInternal WebPConfigInitInternal;
        internal static Delegate32.WebPConfigLosslessPreset WebPConfigLosslessPreset;
        internal static Delegate32.WebPValidateConfig WebPValidateConfig;
        internal static Delegate32.WebPMemoryWriterInit WebPMemoryWriterInit;
        internal static Delegate32.WebPMemoryWriterClear WebPMemoryWriterClear;
        internal static Delegate32.WebPMemoryWrite WebPMemoryWrite;
        internal static Delegate32.WebPPictureInitInternal WebPPictureInitInternal;

        internal static Delegate32.WebPPictureAlloc WebPPictureAlloc;
        internal static Delegate32.WebPPictureFree WebPPictureFree;
        internal static Delegate32.WebPPictureCopy WebPPictureCopy;
        internal static Delegate32.WebPPlaneDistortion WebPPlaneDistortion;
        internal static Delegate32.WebPPictureDistortion WebPPictureDistortion;
        internal static Delegate32.WebPPictureCrop WebPPictureCrop;
        internal static Delegate32.WebPPictureView WebPPictureView;
        internal static Delegate32.WebPPictureIsView WebPPictureIsView;
        internal static Delegate32.WebPPictureRescale WebPPictureRescale;

        internal static Delegate32.WebPPictureImportRGB WebPPictureImportRGB;
        internal static Delegate32.WebPPictureImportRGBA WebPPictureImportRGBA;
        internal static Delegate32.WebPPictureImportRGBX WebPPictureImportRGBX;
        internal static Delegate32.WebPPictureImportBGR WebPPictureImportBGR;
        internal static Delegate32.WebPPictureImportBGRA WebPPictureImportBGRA;
        internal static Delegate32.WebPPictureImportBGRX WebPPictureImportBGRX;
        internal static Delegate32.WebPPictureARGBToYUVA WebPPictureARGBToYUVA;
        internal static Delegate32.WebPPictureARGBToYUVADithered WebPPictureARGBToYUVADithered;
        internal static Delegate32.WebPPictureSharpARGBToYUVA WebPPictureSharpARGBToYUVA;
        internal static Delegate32.WebPPictureSmartARGBToYUVA WebPPictureSmartARGBToYUVA;
        internal static Delegate32.WebPPictureYUVAToARGB WebPPictureYUVAToARGB;
        internal static Delegate32.WebPCleanupTransparentArea WebPCleanupTransparentArea;
        internal static Delegate32.WebPPictureHasTransparency WebPPictureHasTransparency;
        internal static Delegate32.WebPBlendAlpha WebPBlendAlpha;

        internal static Delegate32.WebPEncode WebPEncode;
        #endregion

        #region utils
        internal static Delegate32.WebPSafeMalloc WebPSafeMalloc;
        internal static Delegate32.WebPSafeCalloc WebPSafeCalloc;
        internal static Delegate32.WebPSafeFree WebPSafeFree;

        internal static Delegate32.WebPCopyPlane WebPCopyPlane;
        internal static Delegate32.WebPCopyPixels WebPCopyPixels;
        internal static Delegate32.WebPGetColorPalette WebPGetColorPalette;
        #endregion

        #region types
        internal static Delegate32.WebPMalloc WebPMalloc;
        internal static Delegate32.WebPFree WebPFree;
        #endregion

    }
}
