namespace WebP.Net.Interop
{
    internal class WebPDemux32
    {
        static WebPDemux32()
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

        internal static DemuxDelegate32.WebPGetDemuxVersion WebPGetDemuxVersion;
        internal static DemuxDelegate32.WebPDemuxInternal WebPDemuxInternal;
        internal static DemuxDelegate32.WebPDemuxDelete WebPDemuxDelete;
        internal static DemuxDelegate32.WebPDemuxGetI WebPDemuxGetI;
        internal static DemuxDelegate32.WebPDemuxGetFrame WebPDemuxGetFrame;
        internal static DemuxDelegate32.WebPDemuxNextFrame WebPDemuxNextFrame;
        internal static DemuxDelegate32.WebPDemuxPrevFrame WebPDemuxPrevFrame;
        internal static DemuxDelegate32.WebPDemuxReleaseIterator WebPDemuxReleaseIterator;

        internal static DemuxDelegate32.WebPDemuxGetChunk WebPDemuxGetChunk;
        internal static DemuxDelegate32.WebPDemuxNextChunk WebPDemuxNextChunk;
        internal static DemuxDelegate32.WebPDemuxPrevChunk WebPDemuxPrevChunk;
        internal static DemuxDelegate32.WebPDemuxReleaseChunkIterator WebPDemuxReleaseChunkIterator;

        internal static DemuxDelegate32.WebPAnimDecoderOptionsInitInternal WebPAnimDecoderOptionsInitInternal;
        internal static DemuxDelegate32.WebPAnimDecoderNewInternal WebPAnimDecoderNewInternal;
        internal static DemuxDelegate32.WebPAnimDecoderGetInfo WebPAnimDecoderGetInfo;
        internal static DemuxDelegate32.WebPAnimDecoderGetNext WebPAnimDecoderGetNext;
        internal static DemuxDelegate32.WebPAnimDecoderHasMoreFrames WebPAnimDecoderHasMoreFrames;
        internal static DemuxDelegate32.WebPAnimDecoderReset WebPAnimDecoderReset;
        internal static DemuxDelegate32.WebPAnimDecoderGetDemuxer WebPAnimDecoderGetDemuxer;
        internal static DemuxDelegate32.WebPAnimDecoderDelete WebPAnimDecoderDelete;

    }
}
