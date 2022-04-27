namespace WebPSharp.Interop
{
    internal class WebPDemux64
    {
        static WebPDemux64()
        {
            var path = DemuxLibPathBootStrapper.LibPath;
            NativeLibraryLoader nl = new NativeLibraryLoader(path);

            nl.FillDelegate(out WebPGetDemuxVersion);
            nl.FillDelegate(out WebPDemuxInternal);
            nl.FillDelegate(out WebPDemuxDelete);
            nl.FillDelegate(out WebPDemuxGetI);
            nl.FillDelegate(out WebPDemuxGetFrame);
            nl.FillDelegate(out WebPDemuxNextFrame);
            nl.FillDelegate(out WebPDemuxPrevFrame);
            nl.FillDelegate(out WebPDemuxReleaseIterator);

            nl.FillDelegate(out WebPDemuxGetChunk);
            nl.FillDelegate(out WebPDemuxNextChunk);
            nl.FillDelegate(out WebPDemuxPrevChunk);
            nl.FillDelegate(out WebPDemuxReleaseChunkIterator);

            nl.FillDelegate(out WebPAnimDecoderOptionsInitInternal);
            nl.FillDelegate(out WebPAnimDecoderNewInternal);
            nl.FillDelegate(out WebPAnimDecoderGetInfo);
            nl.FillDelegate(out WebPAnimDecoderGetNext);
            nl.FillDelegate(out WebPAnimDecoderHasMoreFrames);
            nl.FillDelegate(out WebPAnimDecoderReset);
            nl.FillDelegate(out WebPAnimDecoderGetDemuxer);
            nl.FillDelegate(out WebPAnimDecoderDelete);

        }

        internal static DemuxDelegate64.WebPGetDemuxVersion WebPGetDemuxVersion;
        internal static DemuxDelegate64.WebPDemuxInternal WebPDemuxInternal;
        internal static DemuxDelegate64.WebPDemuxDelete WebPDemuxDelete;
        internal static DemuxDelegate64.WebPDemuxGetI WebPDemuxGetI;
        internal static DemuxDelegate64.WebPDemuxGetFrame WebPDemuxGetFrame;
        internal static DemuxDelegate64.WebPDemuxNextFrame WebPDemuxNextFrame;
        internal static DemuxDelegate64.WebPDemuxPrevFrame WebPDemuxPrevFrame;
        internal static DemuxDelegate64.WebPDemuxReleaseIterator WebPDemuxReleaseIterator;

        internal static DemuxDelegate64.WebPDemuxGetChunk WebPDemuxGetChunk;
        internal static DemuxDelegate64.WebPDemuxNextChunk WebPDemuxNextChunk;
        internal static DemuxDelegate64.WebPDemuxPrevChunk WebPDemuxPrevChunk;
        internal static DemuxDelegate64.WebPDemuxReleaseChunkIterator WebPDemuxReleaseChunkIterator;

        internal static DemuxDelegate64.WebPAnimDecoderOptionsInitInternal WebPAnimDecoderOptionsInitInternal;
        internal static DemuxDelegate64.WebPAnimDecoderNewInternal WebPAnimDecoderNewInternal;
        internal static DemuxDelegate64.WebPAnimDecoderGetInfo WebPAnimDecoderGetInfo;
        internal static DemuxDelegate64.WebPAnimDecoderGetNext WebPAnimDecoderGetNext;
        internal static DemuxDelegate64.WebPAnimDecoderHasMoreFrames WebPAnimDecoderHasMoreFrames;
        internal static DemuxDelegate64.WebPAnimDecoderReset WebPAnimDecoderReset;
        internal static DemuxDelegate64.WebPAnimDecoderGetDemuxer WebPAnimDecoderGetDemuxer;
        internal static DemuxDelegate64.WebPAnimDecoderDelete WebPAnimDecoderDelete;

    }
}
