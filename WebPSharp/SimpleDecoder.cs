using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using WebPSharp.Enum;
using WebPSharp.Exception;
using WebPSharp.Struct;

namespace WebPSharp
{
    public class SimpleDecoder
    {
        private readonly IntPtr data = IntPtr.Zero;
        private readonly uint length = 0;

        public SimpleDecoder(string file)
        {
            byte[] bytes = File.ReadAllBytes(file);

            data = Marshal.UnsafeAddrOfPinnedArrayElement(bytes, 0);
            length = (uint)bytes.LongLength;
        }

        public SimpleDecoder(byte[] bytes)
        {
            data = Marshal.UnsafeAddrOfPinnedArrayElement(bytes, 0);
            length = (uint)bytes.LongLength;
        }

        /// <summary>
        /// Get WebP decoder version.
        /// </summary>
        /// <returns></returns>
        public string GetDecoderVersion()
        {
            int version = LibWebP.WebPGetDecoderVersion();

            var revision = version % 256;
            var minor = (version >> 8) % 256;
            var major = (version >> 16) % 256;
            return major + "." + minor + "." + revision;
        }

        /// <summary>
        /// Get features of WebP image.
        /// </summary>
        /// <param name="features"></param>
        /// <returns></returns>
        public VP8StatusCode GetFeatures(ref WebPBitstreamFeatures features)
        {
            return LibWebP.WebPGetFeatures(data, length, ref features);
        }

        /// <summary>
        /// Get bitmap form WebP image.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="WebPException"></exception>
        public Bitmap WebPtoBitmap()
        {
            WebPBitstreamFeatures features = new WebPBitstreamFeatures();
            return WebPtoBitmap(ref features);
        }

        /// <summary>
        /// Get bitmap form WebP image.
        /// </summary>
        /// <param name="features"></param>
        /// <returns></returns>
        /// <exception cref="WebPException"></exception>
        public Bitmap WebPtoBitmap(ref WebPBitstreamFeatures features)
        {
            VP8StatusCode code = GetFeatures(ref features);
            if (code != VP8StatusCode.VP8_STATUS_OK)
            {
                throw new WebPException("Failed to get features with error: " + code);
            }

            int width = features.Width;
            int height = features.Height;

            bool success = false;
            Bitmap bitmap = null;
            BitmapData bitmapData = null;

            try
            {
                if (features.HasAlpha == 0)
                {
                    //Allocate canvas
                    bitmap = new Bitmap(width, height, PixelFormat.Format24bppRgb);
                    //Lock surface for writing
                    bitmapData = bitmap.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

                    IntPtr info = LibWebP.WebPDecodeBGRInto(data, length, bitmapData.Scan0, (uint)(bitmapData.Stride * bitmapData.Height), bitmapData.Stride);
                    if (bitmapData.Scan0 != info)
                    {
                        throw new WebPException("Failed to decode WebP image with error: " + (long)info);
                    }
                }
                else
                {
                    //Allocate canvas
                    bitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb);
                    //Lock surface for writing
                    bitmapData = bitmap.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

                    IntPtr info = LibWebP.WebPDecodeBGRAInto(data, length, bitmapData.Scan0, (uint)(bitmapData.Stride * bitmapData.Height), bitmapData.Stride);
                    if (bitmapData.Scan0 != info)
                    {
                        throw new WebPException("Failed to decode WebP image with error: " + (long)info);
                    }
                }
                success = true;
            }
            finally
            {
                //Unlock surface
                if (bitmap != null && bitmapData != null)
                {
                    bitmap.UnlockBits(bitmapData);
                }

                //Dispose of bitmap if anything went wrong
                if (!success && bitmap != null)
                {
                    bitmap.Dispose();
                }
            }

            return bitmap;
        }


    }
}
