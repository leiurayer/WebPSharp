namespace WebP.Net.Interop
{
    internal class WebP64
    {
        static WebP64()
        {
            var path = LibPathBootStrapper.LibPath;
            NativeLibraryLoader nl = new NativeLibraryLoader(path);

            #region set WebP decode
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
            #endregion

        }

        #region set WebP decode
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

        #endregion

    }
}
