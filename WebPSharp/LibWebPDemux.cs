using System;
using WebPSharp.Enum;
using WebPSharp.Interop;
using WebPSharp.Struct;

namespace WebPSharp
{
    public class LibWebPDemux
    {
        private const int WEBP_DEMUX_ABI_VERSION = 0x0107;

        private static readonly bool UseX86 = IntPtr.Size == 4;

        public static int WebPGetDemuxVersion()
        {
            if (UseX86)
            {
                return WebPDemux32.WebPGetDemuxVersion();
            }
            else
            {
                return WebPDemux64.WebPGetDemuxVersion();
            }
        }

        /// <summary>
        /// Parses the full WebP file given by 'data'. For single images the WebP file
        /// header alone or the file header and the chunk header may be absent.
        /// Returns a WebPDemuxer object on successful parse, NULL otherwise.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static IntPtr WebPDemux(ref WebPData data)
        {
            if (UseX86)
            {
                return WebPDemux32.WebPDemuxInternal(ref data, 0, IntPtr.Zero, WEBP_DEMUX_ABI_VERSION);
            }
            else
            {
                return WebPDemux64.WebPDemuxInternal(ref data, 0, IntPtr.Zero, WEBP_DEMUX_ABI_VERSION);
            }
        }

        /// <summary>
        /// Parses the possibly incomplete WebP file given by 'data'.
        /// If 'state' is non-NULL it will be set to indicate the status of the demuxer.
        /// Returns NULL in case of error or if there isn't enough data to start parsing;
        /// and a WebPDemuxer object on successful parse.
        /// Note that WebPDemuxer keeps internal pointers to 'data' memory segment.
        /// If this data is volatile, the demuxer object should be deleted (by calling
        /// WebPDemuxDelete()) and WebPDemuxPartial() called again on the new data.
        /// This is usually an inexpensive operation.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public static IntPtr WebPDemuxPartial(ref WebPData data, ref WebPDemuxState state)
        {
            IntPtr statePtr = Utils.StructToIntPtr(state);

            IntPtr result;
            if (UseX86)
            {
                result = WebPDemux32.WebPDemuxInternal(ref data, 1, statePtr, WEBP_DEMUX_ABI_VERSION);
            }
            else
            {
                result = WebPDemux64.WebPDemuxInternal(ref data, 1, statePtr, WEBP_DEMUX_ABI_VERSION);
            }

            state = Utils.IntPtrToStruct<WebPDemuxState>(statePtr);
            return result;
        }

        public static void WebPDemuxDelete(ref WebPDemuxer dmux)
        {
            if (UseX86)
            {
                WebPDemux32.WebPDemuxDelete(ref dmux);
            }
            else
            {
                WebPDemux64.WebPDemuxDelete(ref dmux);
            }
        }

        public static UInt32 WebPDemuxGetI(ref WebPDemuxer dmux, WebPFormatFeature feature)
        {
            if (UseX86)
            {
                return WebPDemux32.WebPDemuxGetI(ref dmux, feature);
            }
            else
            {
                return (uint)WebPDemux64.WebPDemuxGetI(ref dmux, feature);
            }
        }

        public static int WebPDemuxGetFrame(ref WebPDemuxer dmux, int frameNumber, ref WebPIterator iter)
        {
            if (UseX86)
            {
                return WebPDemux32.WebPDemuxGetFrame(ref dmux, frameNumber, ref iter);
            }
            else
            {
                return WebPDemux64.WebPDemuxGetFrame(ref dmux, frameNumber, ref iter);
            }
        }

        public static int WebPDemuxNextFrame(ref WebPIterator iter)
        {
            if (UseX86)
            {
                return WebPDemux32.WebPDemuxNextFrame(ref iter);
            }
            else
            {
                return WebPDemux64.WebPDemuxNextFrame(ref iter);
            }
        }

        public static int WebPDemuxPrevFrame(ref WebPIterator iter)
        {
            if (UseX86)
            {
                return WebPDemux32.WebPDemuxPrevFrame(ref iter);
            }
            else
            {
                return WebPDemux64.WebPDemuxPrevFrame(ref iter);
            }
        }

        public static void WebPDemuxReleaseIterator(ref WebPIterator iter)
        {
            if (UseX86)
            {
                WebPDemux32.WebPDemuxReleaseIterator(ref iter);
            }
            else
            {
                WebPDemux64.WebPDemuxReleaseIterator(ref iter);
            }
        }

        public static int WebPDemuxGetChunk(ref WebPDemuxer dmux, char[] fourcc, int chunkNumber, ref WebPChunkIterator iter)
        {
            if (UseX86)
            {
                return WebPDemux32.WebPDemuxGetChunk(ref dmux, fourcc, chunkNumber, ref iter);
            }
            else
            {
                return WebPDemux64.WebPDemuxGetChunk(ref dmux, fourcc, chunkNumber, ref iter);
            }
        }

        public static int WebPDemuxNextChunk(ref WebPChunkIterator iter)
        {
            if (UseX86)
            {
                return WebPDemux32.WebPDemuxNextChunk(ref iter);
            }
            else
            {
                return WebPDemux64.WebPDemuxNextChunk(ref iter);
            }
        }

        public static int WebPDemuxPrevChunk(ref WebPChunkIterator iter)
        {
            if (UseX86)
            {
                return WebPDemux32.WebPDemuxPrevChunk(ref iter);
            }
            else
            {
                return WebPDemux64.WebPDemuxPrevChunk(ref iter);
            }
        }

        public static void WebPDemuxReleaseChunkIterator(ref WebPChunkIterator iter)
        {
            if (UseX86)
            {
                WebPDemux32.WebPDemuxReleaseChunkIterator(ref iter);
            }
            else
            {
                WebPDemux64.WebPDemuxReleaseChunkIterator(ref iter);
            }
        }

        public static int WebPAnimDecoderOptionsInitInternal(ref WebPAnimDecoderOptions decOptions)
        {
            if (UseX86)
            {
                return WebPDemux32.WebPAnimDecoderOptionsInitInternal(ref decOptions, WEBP_DEMUX_ABI_VERSION);
            }
            else
            {
                return WebPDemux64.WebPAnimDecoderOptionsInitInternal(ref decOptions, WEBP_DEMUX_ABI_VERSION);
            }
        }

        public static IntPtr WebPAnimDecoderNewInternal(ref WebPData webpData, ref WebPAnimDecoderOptions decOptions)
        {
            if (UseX86)
            {
                return WebPDemux32.WebPAnimDecoderNewInternal(ref webpData, ref decOptions, WEBP_DEMUX_ABI_VERSION);
            }
            else
            {
                return WebPDemux64.WebPAnimDecoderNewInternal(ref webpData, ref decOptions, WEBP_DEMUX_ABI_VERSION);
            }
        }

        public static int WebPAnimDecoderGetInfo(ref WebPAnimDecoder dec, ref WebPAnimInfo info)
        {
            if (UseX86)
            {
                return WebPDemux32.WebPAnimDecoderGetInfo(ref dec, ref info);
            }
            else
            {
                return WebPDemux64.WebPAnimDecoderGetInfo(ref dec, ref info);
            }
        }

        public static int WebPAnimDecoderGetNext(ref WebPAnimDecoder dec, ref IntPtr buf, ref int timestamp)
        {
            if (UseX86)
            {
                return WebPDemux32.WebPAnimDecoderGetNext(ref dec, ref buf, ref timestamp);
            }
            else
            {
                return WebPDemux64.WebPAnimDecoderGetNext(ref dec, ref buf, ref timestamp);
            }
        }

        public static int WebPAnimDecoderHasMoreFrames(ref WebPAnimDecoder dec)
        {
            if (UseX86)
            {
                return WebPDemux32.WebPAnimDecoderHasMoreFrames(ref dec);
            }
            else
            {
                return WebPDemux64.WebPAnimDecoderHasMoreFrames(ref dec);
            }
        }

        public static void WebPAnimDecoderReset(ref WebPAnimDecoder dec)
        {
            if (UseX86)
            {
                WebPDemux32.WebPAnimDecoderReset(ref dec);
            }
            else
            {
                WebPDemux64.WebPAnimDecoderReset(ref dec);
            }
        }

        public static IntPtr WebPAnimDecoderGetDemuxer(ref WebPAnimDecoder dec)
        {
            if (UseX86)
            {
                return WebPDemux32.WebPAnimDecoderGetDemuxer(ref dec);
            }
            else
            {
                return WebPDemux64.WebPAnimDecoderGetDemuxer(ref dec);
            }
        }

        public static void WebPAnimDecoderDelete(ref WebPAnimDecoder dec)
        {
            if (UseX86)
            {
                WebPDemux32.WebPAnimDecoderDelete(ref dec);
            }
            else
            {
                WebPDemux64.WebPAnimDecoderDelete(ref dec);
            }
        }

    }
}
