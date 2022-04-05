using System;
using WebP.Net.Interop;

namespace WebP.Net
{
    public class LibWebP
    {
        private static readonly bool UseX86 = IntPtr.Size == 4;

        #region WebP decode

        public static int WebPGetDecoderVersion()
        {
            if (UseX86)
            {
                return WebP32.WebPGetDecoderVersion();
            }
            else
            {
                return WebP64.WebPGetDecoderVersion();
            }
        }

        public static int WebPGetInfo(IntPtr data, UInt32 size, ref int width, ref int height)
        {
            if (UseX86)
            {
                return WebP32.WebPGetInfo(data, size, ref width, ref height);
            }
            else
            {
                UInt64 longSize = size;
                return WebP64.WebPGetInfo(data, longSize, ref width, ref height);
            }
        }

        public static IntPtr WebPDecodeRGBA(IntPtr data, UInt32 size, ref int width, ref int height)
        {
            if (UseX86)
            {
                return WebP32.WebPDecodeRGBA(data, size, ref width, ref height);
            }
            else
            {
                UInt64 longSize = size;
                return WebP64.WebPDecodeRGBA(data, longSize, ref width, ref height);
            }
        }

        public static IntPtr WebPDecodeARGB(IntPtr data, UInt32 size, ref int width, ref int height)
        {
            if (UseX86)
            {
                return WebP32.WebPDecodeARGB(data, size, ref width, ref height);
            }
            else
            {
                UInt64 longSize = size;
                return WebP64.WebPDecodeARGB(data, longSize, ref width, ref height);
            }
        }

        public static IntPtr WebPDecodeBGRA(IntPtr data, UInt32 size, ref int width, ref int height)
        {
            if (UseX86)
            {
                return WebP32.WebPDecodeBGRA(data, size, ref width, ref height);
            }
            else
            {
                UInt64 longSize = size;
                return WebP64.WebPDecodeBGRA(data, longSize, ref width, ref height);
            }
        }

        public static IntPtr WebPDecodeRGB(IntPtr data, UInt32 size, ref int width, ref int height)
        {
            if (UseX86)
            {
                return WebP32.WebPDecodeRGB(data, size, ref width, ref height);
            }
            else
            {
                UInt64 longSize = size;
                return WebP64.WebPDecodeRGB(data, longSize, ref width, ref height);
            }
        }

        public static IntPtr WebPDecodeBGR(IntPtr data, UInt32 size, ref int width, ref int height)
        {
            if (UseX86)
            {
                return WebP32.WebPDecodeBGR(data, size, ref width, ref height);
            }
            else
            {
                UInt64 longSize = size;
                return WebP64.WebPDecodeBGR(data, longSize, ref width, ref height);
            }
        }

        #endregion




    }
}
