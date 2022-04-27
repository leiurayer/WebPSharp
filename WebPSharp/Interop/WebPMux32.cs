namespace WebPSharp.Interop
{
    internal class WebPMux32
    {
        static WebPMux32()
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

        internal static MuxDelegate32.WebPGetMuxVersion WebPGetMuxVersion;
        internal static MuxDelegate32.WebPNewInternal WebPNewInternal;
        internal static MuxDelegate32.WebPMuxDelete WebPMuxDelete;
        internal static MuxDelegate32.WebPMuxCreateInternal WebPMuxCreateInternal;
        internal static MuxDelegate32.WebPMuxSetChunk WebPMuxSetChunk;
        internal static MuxDelegate32.WebPMuxSetChunk2 WebPMuxSetChunk2;
        internal static MuxDelegate32.WebPMuxDeleteChunk WebPMuxDeleteChunk;

        internal static MuxDelegate32.WebPMuxSetImage WebPMuxSetImage;
        internal static MuxDelegate32.WebPMuxPushFrame WebPMuxPushFrame;
        internal static MuxDelegate32.WebPMuxGetFrame WebPMuxGetFrame;
        internal static MuxDelegate32.WebPMuxDeleteFrame WebPMuxDeleteFrame;

        internal static MuxDelegate32.WebPMuxSetAnimationParams WebPMuxSetAnimationParams;
        internal static MuxDelegate32.WebPMuxGetAnimationParams WebPMuxGetAnimationParams;
        internal static MuxDelegate32.WebPMuxSetCanvasSize WebPMuxSetCanvasSize;
        internal static MuxDelegate32.WebPMuxGetCanvasSize WebPMuxGetCanvasSize;

    }
}
