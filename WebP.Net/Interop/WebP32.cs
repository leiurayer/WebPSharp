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
        #endregion

    }
}
