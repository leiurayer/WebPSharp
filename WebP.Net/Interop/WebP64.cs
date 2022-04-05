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
        #endregion

    }
}
