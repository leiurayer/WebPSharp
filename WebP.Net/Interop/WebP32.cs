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

            nl.FillDelegate(out WebPGetFeaturesInternal);

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

        internal static Delegate32.WebPGetFeaturesInternal WebPGetFeaturesInternal;

        #endregion

    }
}
