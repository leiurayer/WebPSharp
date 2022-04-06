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

            nl.FillDelegate(out WebPGetFeaturesInternal);

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

        internal static Delegate64.WebPGetFeaturesInternal WebPGetFeaturesInternal;

        #endregion

    }
}
