using System;
using WebPSharp.Enum;
using WebPSharp.Interop;
using WebPSharp.Struct;

namespace WebPSharp
{
    public class LibWebPMux
    {
        private const int WEBP_MUX_ABI_VERSION = 0x0108;

        private static readonly bool UseX86 = IntPtr.Size == 4;

        public static int WebPGetMuxVersion()
        {
            if (UseX86)
            {
                return WebPMux32.WebPGetMuxVersion();
            }
            else
            {
                return WebPMux64.WebPGetMuxVersion();
            }
        }

        public static IntPtr WebPNew()
        {
            if (UseX86)
            {
                return WebPMux32.WebPNewInternal(WEBP_MUX_ABI_VERSION);
            }
            else
            {
                return WebPMux64.WebPNewInternal(WEBP_MUX_ABI_VERSION);
            }
        }

        public static void WebPMuxDelete(ref WebPMux mux)
        {
            if (UseX86)
            {
                WebPMux32.WebPMuxDelete(ref mux);
            }
            else
            {
                WebPMux64.WebPMuxDelete(ref mux);
            }
        }

        public static IntPtr WebPMuxCreate(ref WebPData bitstream, int copyData)
        {
            if (UseX86)
            {
                return WebPMux32.WebPMuxCreateInternal(ref bitstream, copyData, WEBP_MUX_ABI_VERSION);
            }
            else
            {
                return WebPMux64.WebPMuxCreateInternal(ref bitstream, copyData, WEBP_MUX_ABI_VERSION);
            }
        }

        public static WebPMuxError WebPMuxSetChunk(ref WebPMux mux, char[] fourcc, ref WebPData chunkData, int copyData)
        {
            if (UseX86)
            {
                return WebPMux32.WebPMuxSetChunk(ref mux, fourcc, ref chunkData, copyData);
            }
            else
            {
                return WebPMux64.WebPMuxSetChunk(ref mux, fourcc, ref chunkData, copyData);
            }
        }

        public static WebPMuxError WebPMuxSetChunk(ref WebPMux mux, char[] fourcc, ref WebPData chunkData)
        {
            if (UseX86)
            {
                return WebPMux32.WebPMuxSetChunk2(ref mux, fourcc, ref chunkData);
            }
            else
            {
                return WebPMux64.WebPMuxSetChunk2(ref mux, fourcc, ref chunkData);
            }
        }

        public static WebPMuxError WebPMuxDeleteChunk(ref WebPMux mux, char[] fourcc)
        {
            if (UseX86)
            {
                return WebPMux32.WebPMuxDeleteChunk(ref mux, fourcc);
            }
            else
            {
                return WebPMux64.WebPMuxDeleteChunk(ref mux, fourcc);
            }
        }

        public static WebPMuxError WebPMuxSetImage(ref WebPMux mux, ref WebPData bitstream, int copyData)
        {
            if (UseX86)
            {
                return WebPMux32.WebPMuxSetImage(ref mux, ref bitstream, copyData);
            }
            else
            {
                return WebPMux64.WebPMuxSetImage(ref mux, ref bitstream, copyData);
            }
        }

        public static WebPMuxError WebPMuxPushFrame(ref WebPMux mux, ref WebPMuxFrameInfo frame, int copyData)
        {
            if (UseX86)
            {
                return WebPMux32.WebPMuxPushFrame(ref mux, ref frame, copyData);
            }
            else
            {
                return WebPMux64.WebPMuxPushFrame(ref mux, ref frame, copyData);
            }
        }

        public static WebPMuxError WebPMuxGetFrame(ref WebPMux mux, UInt32 nth, ref WebPMuxFrameInfo frame)
        {
            if (UseX86)
            {
                return WebPMux32.WebPMuxGetFrame(ref mux, nth, ref frame);
            }
            else
            {
                UInt64 longNth = nth;
                return WebPMux64.WebPMuxGetFrame(ref mux, longNth, ref frame);
            }
        }

        public static WebPMuxError WebPMuxDeleteFrame(ref WebPMux mux, UInt32 nth)
        {
            if (UseX86)
            {
                return WebPMux32.WebPMuxDeleteFrame(ref mux, nth);
            }
            else
            {
                UInt64 longNth = nth;
                return WebPMux64.WebPMuxDeleteFrame(ref mux, longNth);
            }
        }

        public static WebPMuxError WebPMuxSetAnimationParams(ref WebPMux mux, ref WebPMuxAnimParams params_)
        {
            if (UseX86)
            {
                return WebPMux32.WebPMuxSetAnimationParams(ref mux, ref params_);
            }
            else
            {
                return WebPMux64.WebPMuxSetAnimationParams(ref mux, ref params_);
            }
        }

        public static WebPMuxError WebPMuxGetAnimationParams(ref WebPMux mux, ref WebPMuxAnimParams params_)
        {
            if (UseX86)
            {
                return WebPMux32.WebPMuxGetAnimationParams(ref mux, ref params_);
            }
            else
            {
                return WebPMux64.WebPMuxGetAnimationParams(ref mux, ref params_);
            }
        }

        public static WebPMuxError WebPMuxSetCanvasSize(ref WebPMux mux, int width, int height)
        {
            if (UseX86)
            {
                return WebPMux32.WebPMuxSetCanvasSize(ref mux, width, height);
            }
            else
            {
                return WebPMux64.WebPMuxSetCanvasSize(ref mux, width, height);
            }
        }

        public static WebPMuxError WebPMuxGetCanvasSize(ref WebPMux mux, ref int width, ref int height)
        {
            if (UseX86)
            {
                return WebPMux32.WebPMuxGetCanvasSize(ref mux, ref width, ref height);
            }
            else
            {
                return WebPMux64.WebPMuxGetCanvasSize(ref mux, ref width, ref height);
            }
        }

    }
}
