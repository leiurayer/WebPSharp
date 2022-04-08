namespace WebP.Net.Interop
{
    internal class WebP32
    {
        static WebP32()
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

        #endregion

    }
}
