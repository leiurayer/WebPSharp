namespace WebPSharp.Interop
{
    internal class WebPMux64
    {
        static WebPMux64()
        {
            var path = MuxLibPathBootStrapper.LibPath;
            NativeLibraryLoader nl = new NativeLibraryLoader(path);

            nl.FillDelegate(out WebPGetMuxVersion);
            nl.FillDelegate(out WebPNewInternal);
            nl.FillDelegate(out WebPMuxDelete);
            nl.FillDelegate(out WebPMuxCreateInternal);
            nl.FillDelegate(out WebPMuxSetChunk);
            nl.FillDelegate(out WebPMuxSetChunk2);
            nl.FillDelegate(out WebPMuxDeleteChunk);

            nl.FillDelegate(out WebPMuxSetImage);
            nl.FillDelegate(out WebPMuxPushFrame);
            nl.FillDelegate(out WebPMuxGetFrame);
            nl.FillDelegate(out WebPMuxDeleteFrame);

            nl.FillDelegate(out WebPMuxSetAnimationParams);
            nl.FillDelegate(out WebPMuxGetAnimationParams);
            nl.FillDelegate(out WebPMuxSetCanvasSize);
            nl.FillDelegate(out WebPMuxGetCanvasSize);

        }

        internal static MuxDelegate64.WebPGetMuxVersion WebPGetMuxVersion;
        internal static MuxDelegate64.WebPNewInternal WebPNewInternal;
        internal static MuxDelegate64.WebPMuxDelete WebPMuxDelete;
        internal static MuxDelegate64.WebPMuxCreateInternal WebPMuxCreateInternal;
        internal static MuxDelegate64.WebPMuxSetChunk WebPMuxSetChunk;
        internal static MuxDelegate64.WebPMuxSetChunk2 WebPMuxSetChunk2;
        internal static MuxDelegate64.WebPMuxDeleteChunk WebPMuxDeleteChunk;

        internal static MuxDelegate64.WebPMuxSetImage WebPMuxSetImage;
        internal static MuxDelegate64.WebPMuxPushFrame WebPMuxPushFrame;
        internal static MuxDelegate64.WebPMuxGetFrame WebPMuxGetFrame;
        internal static MuxDelegate64.WebPMuxDeleteFrame WebPMuxDeleteFrame;

        internal static MuxDelegate64.WebPMuxSetAnimationParams WebPMuxSetAnimationParams;
        internal static MuxDelegate64.WebPMuxGetAnimationParams WebPMuxGetAnimationParams;
        internal static MuxDelegate64.WebPMuxSetCanvasSize WebPMuxSetCanvasSize;
        internal static MuxDelegate64.WebPMuxGetCanvasSize WebPMuxGetCanvasSize;

    }
}
