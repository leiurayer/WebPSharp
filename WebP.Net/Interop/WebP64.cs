namespace WebP.Net.Interop
{
    internal class WebP64
    {
        static WebP64()
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
        internal static Delegate64.WebPGetDecoderVersion WebPGetDecoderVersion;
        internal static Delegate64.WebPGetInfo WebPGetInfo;
        internal static Delegate64.WebPDecodeRGBA WebPDecodeRGBA;
        internal static Delegate64.WebPDecodeRGBA WebPDecodeARGB;
        internal static Delegate64.WebPDecodeRGBA WebPDecodeBGRA;
        internal static Delegate64.WebPDecodeRGBA WebPDecodeRGB;
        internal static Delegate64.WebPDecodeRGBA WebPDecodeBGR;
        internal static Delegate64.WebPDecodeYUV WebPDecodeYUV;

        internal static Delegate64.WebPDecodeRGBAInto WebPDecodeRGBAInto;
        internal static Delegate64.WebPDecodeARGBInto WebPDecodeARGBInto;
        internal static Delegate64.WebPDecodeBGRAInto WebPDecodeBGRAInto;
        internal static Delegate64.WebPDecodeRGBInto WebPDecodeRGBInto;
        internal static Delegate64.WebPDecodeBGRInto WebPDecodeBGRInto;
        internal static Delegate64.WebPDecodeYUVInto WebPDecodeYUVInto;

        internal static Delegate64.WebPInitDecBufferInternal WebPInitDecBufferInternal;
        internal static Delegate64.WebPFreeDecBuffer WebPFreeDecBuffer;

        internal static Delegate64.WebPINewDecoder WebPINewDecoder;
        internal static Delegate64.WebPINewRGB WebPINewRGB;
        internal static Delegate64.WebPINewYUVA WebPINewYUVA;
        internal static Delegate64.WebPINewYUV WebPINewYUV;

        internal static Delegate64.WebPIDelete WebPIDelete;
        internal static Delegate64.WebPIAppend WebPIAppend;
        internal static Delegate64.WebPIUpdate WebPIUpdate;

        internal static Delegate64.WebPIDecGetRGB WebPIDecGetRGB;
        internal static Delegate64.WebPIDecGetYUVA WebPIDecGetYUVA;
        internal static Delegate64.WebPIDecodedArea WebPIDecodedArea;

        internal static Delegate64.WebPGetFeaturesInternal WebPGetFeaturesInternal;
        internal static Delegate64.WebPInitDecoderConfigInternal WebPInitDecoderConfigInternal;

        internal static Delegate64.WebPIDecode WebPIDecode;
        internal static Delegate64.WebPDecode WebPDecode;
        #endregion

        #region WebP encode
        internal static Delegate64.WebPGetEncoderVersion WebPGetEncoderVersion;

        internal static Delegate64.WebPEncodeRGB WebPEncodeRGB;
        internal static Delegate64.WebPEncodeBGR WebPEncodeBGR;
        internal static Delegate64.WebPEncodeRGBA WebPEncodeRGBA;
        internal static Delegate64.WebPEncodeBGRA WebPEncodeBGRA;

        internal static Delegate64.WebPEncodeLosslessRGB WebPEncodeLosslessRGB;
        internal static Delegate64.WebPEncodeLosslessBGR WebPEncodeLosslessBGR;
        internal static Delegate64.WebPEncodeLosslessRGBA WebPEncodeLosslessRGBA;
        internal static Delegate64.WebPEncodeLosslessBGRA WebPEncodeLosslessBGRA;

        internal static Delegate64.WebPConfigInitInternal WebPConfigInitInternal;
        internal static Delegate64.WebPConfigLosslessPreset WebPConfigLosslessPreset;
        internal static Delegate64.WebPValidateConfig WebPValidateConfig;
        internal static Delegate64.WebPMemoryWriterInit WebPMemoryWriterInit;
        internal static Delegate64.WebPMemoryWriterClear WebPMemoryWriterClear;
        internal static Delegate64.WebPMemoryWrite WebPMemoryWrite;
        internal static Delegate64.WebPPictureInitInternal WebPPictureInitInternal;

        internal static Delegate64.WebPPictureAlloc WebPPictureAlloc;
        internal static Delegate64.WebPPictureFree WebPPictureFree;
        internal static Delegate64.WebPPictureCopy WebPPictureCopy;
        internal static Delegate64.WebPPlaneDistortion WebPPlaneDistortion;
        internal static Delegate64.WebPPictureDistortion WebPPictureDistortion;
        internal static Delegate64.WebPPictureCrop WebPPictureCrop;
        internal static Delegate64.WebPPictureView WebPPictureView;
        internal static Delegate64.WebPPictureIsView WebPPictureIsView;
        internal static Delegate64.WebPPictureRescale WebPPictureRescale;

        internal static Delegate64.WebPPictureImportRGB WebPPictureImportRGB;
        internal static Delegate64.WebPPictureImportRGBA WebPPictureImportRGBA;
        internal static Delegate64.WebPPictureImportRGBX WebPPictureImportRGBX;
        internal static Delegate64.WebPPictureImportBGR WebPPictureImportBGR;
        internal static Delegate64.WebPPictureImportBGRA WebPPictureImportBGRA;
        internal static Delegate64.WebPPictureImportBGRX WebPPictureImportBGRX;
        internal static Delegate64.WebPPictureARGBToYUVA WebPPictureARGBToYUVA;
        internal static Delegate64.WebPPictureARGBToYUVADithered WebPPictureARGBToYUVADithered;
        internal static Delegate64.WebPPictureSharpARGBToYUVA WebPPictureSharpARGBToYUVA;
        internal static Delegate64.WebPPictureSmartARGBToYUVA WebPPictureSmartARGBToYUVA;
        internal static Delegate64.WebPPictureYUVAToARGB WebPPictureYUVAToARGB;
        internal static Delegate64.WebPCleanupTransparentArea WebPCleanupTransparentArea;
        internal static Delegate64.WebPPictureHasTransparency WebPPictureHasTransparency;
        internal static Delegate64.WebPBlendAlpha WebPBlendAlpha;

        internal static Delegate64.WebPEncode WebPEncode;
        #endregion

        #region utils
        internal static Delegate64.WebPSafeMalloc WebPSafeMalloc;
        internal static Delegate64.WebPSafeCalloc WebPSafeCalloc;
        internal static Delegate64.WebPSafeFree WebPSafeFree;

        internal static Delegate64.WebPCopyPlane WebPCopyPlane;
        internal static Delegate64.WebPCopyPixels WebPCopyPixels;
        internal static Delegate64.WebPGetColorPalette WebPGetColorPalette;
        #endregion

        #region types
        internal static Delegate64.WebPMalloc WebPMalloc;
        internal static Delegate64.WebPFree WebPFree;
        #endregion

    }
}
