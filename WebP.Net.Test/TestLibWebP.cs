using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using WebP.Net.Enum;
using WebP.Net.Struct;

namespace WebP.Net.Test
{
    [TestClass]
    public class TestLibWebP
    {
        private readonly List<Image> ImageList = new List<Image>
        {
            new Image { Name = "Gallery/WebP Gallery/1.webp", Width = 550, Height = 368, HasAlpha = 0, HasAnimation = 0, Format = 1 },
            new Image { Name = "Gallery/WebP Gallery/2.webp", Width = 550, Height = 404, HasAlpha = 0, HasAnimation = 0, Format = 1 },
            new Image { Name = "Gallery/WebP Gallery/3.webp", Width = 1280, Height = 720, HasAlpha = 0, HasAnimation = 0, Format = 1 },
            new Image { Name = "Gallery/WebP Gallery/4.webp", Width = 1024, Height = 772, HasAlpha = 0, HasAnimation = 0, Format = 1 },
            new Image { Name = "Gallery/WebP Gallery/5.webp", Width = 1024, Height = 752, HasAlpha = 0, HasAnimation = 0, Format = 1 },

            new Image { Name = "Gallery/Lossless and Alpha Gallery/1_webp_ll.webp", Width = 400, Height = 301, HasAlpha = 1, HasAnimation = 0, Format = 2 },
            new Image { Name = "Gallery/Lossless and Alpha Gallery/1_webp_a.webp", Width = 400, Height = 301, HasAlpha = 1, HasAnimation = 0, Format = 1  },

            new Image { Name = "Gallery/Lossless and Alpha Gallery/2_webp_ll.webp", Width = 386, Height = 395, HasAlpha = 1, HasAnimation = 0, Format = 2  },
            new Image { Name = "Gallery/Lossless and Alpha Gallery/2_webp_a.webp", Width = 386, Height = 395, HasAlpha = 1, HasAnimation = 0, Format = 1  },

            new Image { Name = "Gallery/Lossless and Alpha Gallery/3_webp_ll.webp", Width = 800, Height = 600, HasAlpha = 1, HasAnimation = 0, Format = 2  },
            new Image { Name = "Gallery/Lossless and Alpha Gallery/3_webp_a.webp", Width = 800, Height = 600, HasAlpha = 1, HasAnimation = 0, Format = 1  },

            new Image { Name = "Gallery/Lossless and Alpha Gallery/4_webp_ll.webp", Width = 421, Height = 163, HasAlpha = 1, HasAnimation = 0, Format = 2  },
            new Image { Name = "Gallery/Lossless and Alpha Gallery/4_webp_a.webp", Width = 421, Height = 163, HasAlpha = 1, HasAnimation = 0, Format = 1  },

            new Image { Name = "Gallery/Lossless and Alpha Gallery/5_webp_ll.webp", Width = 300, Height = 300, HasAlpha = 1, HasAnimation = 0, Format = 2  },
            new Image { Name = "Gallery/Lossless and Alpha Gallery/5_webp_a.webp", Width = 300, Height = 300, HasAlpha = 1, HasAnimation = 0, Format = 1  },
        };

        #region WebP decode

        [TestMethod]
        public void TestWebPGetDecoderVersion()
        {
            // test WebPGetDecoderVersion()
            int version = LibWebP.WebPGetDecoderVersion();

            var revision = version % 256;
            var minor = (version >> 8) % 256;
            var major = (version >> 16) % 256;
            string versionName = major + "." + minor + "." + revision;

            // libwebp-1.2.2
            Assert.AreEqual(66050, version);
            Assert.AreEqual("1.2.2", versionName);
        }

        [TestMethod]
        public void TestWebPGetInfo()
        {
            // test WebPGetInfo()

            foreach (var item in ImageList)
            {
                int width = 0;
                int height = 0;
                byte[] bytes = File.ReadAllBytes(item.Name);
                IntPtr data = Marshal.UnsafeAddrOfPinnedArrayElement(bytes, 0);

                int info = LibWebP.WebPGetInfo(data, (uint)bytes.LongLength, ref width, ref height);
                Assert.AreEqual(1, info);
                Assert.AreEqual(item.Width, width);
                Assert.AreEqual(item.Height, height);
            }
        }

        [TestMethod]
        public void TestWebPDecodeRGBA()
        {
            // test WebPDecodeRGBA()

            foreach (var item in ImageList)
            {
                int width = 0;
                int height = 0;
                byte[] bytes = File.ReadAllBytes(item.Name);
                IntPtr data = Marshal.UnsafeAddrOfPinnedArrayElement(bytes, 0);

                IntPtr info = LibWebP.WebPDecodeRGBA(data, (uint)bytes.LongLength, ref width, ref height);
                Assert.AreNotEqual(0, info);
                Assert.AreEqual(item.Width, width);
                Assert.AreEqual(item.Height, height);
            }
        }

        [TestMethod]
        public void TestWebPDecodeARGB()
        {
            // test WebPDecodeARGB()

            foreach (var item in ImageList)
            {
                int width = 0;
                int height = 0;
                byte[] bytes = File.ReadAllBytes(item.Name);
                IntPtr data = Marshal.UnsafeAddrOfPinnedArrayElement(bytes, 0);

                IntPtr info = LibWebP.WebPDecodeARGB(data, (uint)bytes.LongLength, ref width, ref height);
                Assert.AreNotEqual(0, info);
                Assert.AreEqual(item.Width, width);
                Assert.AreEqual(item.Height, height);
            }
        }

        [TestMethod]
        public void TestWebPDecodeBGRA()
        {
            // test WebPDecodeBGRA()

            foreach (var item in ImageList)
            {
                int width = 0;
                int height = 0;
                byte[] bytes = File.ReadAllBytes(item.Name);
                IntPtr data = Marshal.UnsafeAddrOfPinnedArrayElement(bytes, 0);

                IntPtr info = LibWebP.WebPDecodeBGRA(data, (uint)bytes.LongLength, ref width, ref height);
                Assert.AreNotEqual(0, info);
                Assert.AreEqual(item.Width, width);
                Assert.AreEqual(item.Height, height);
            }
        }

        [TestMethod]
        public void TestWebPDecodeRGB()
        {
            // test WebPDecodeRGB()

            foreach (var item in ImageList)
            {
                int width = 0;
                int height = 0;
                byte[] bytes = File.ReadAllBytes(item.Name);
                IntPtr data = Marshal.UnsafeAddrOfPinnedArrayElement(bytes, 0);

                IntPtr info = LibWebP.WebPDecodeRGB(data, (uint)bytes.LongLength, ref width, ref height);
                Assert.AreNotEqual(0, info);
                Assert.AreEqual(item.Width, width);
                Assert.AreEqual(item.Height, height);
            }
        }

        [TestMethod]
        public void TestWebPDecodeBGR()
        {
            // test WebPDecodeBGR()

            foreach (var item in ImageList)
            {
                int width = 0;
                int height = 0;
                byte[] bytes = File.ReadAllBytes(item.Name);
                IntPtr data = Marshal.UnsafeAddrOfPinnedArrayElement(bytes, 0);

                IntPtr info = LibWebP.WebPDecodeBGR(data, (uint)bytes.LongLength, ref width, ref height);
                Assert.AreNotEqual(0, info);
                Assert.AreEqual(item.Width, width);
                Assert.AreEqual(item.Height, height);
            }
        }

        [TestMethod]
        public void TestWebPDecodeYUV()
        {
            // test WebPDecodeYUV()

            foreach (var item in ImageList)
            {
                int width = 0;
                int height = 0;
                byte[] bytes = File.ReadAllBytes(item.Name);
                IntPtr data = Marshal.UnsafeAddrOfPinnedArrayElement(bytes, 0);

                IntPtr u = new IntPtr(((item.Width + 1) / 2) * ((item.Height + 1) / 2));
                IntPtr v = new IntPtr(((item.Width + 1) / 2) * ((item.Height + 1) / 2));
                int stride = 0;
                int uv_stride = 0;

                IntPtr y = LibWebP.WebPDecodeYUV(data, (uint)bytes.LongLength, ref width, ref height, ref u, ref v, ref stride, ref uv_stride);
                Assert.AreNotEqual(0, y);
                Assert.AreEqual(item.Width, width);
                Assert.AreEqual(item.Height, height);
            }
        }

        [TestMethod]
        public void TestWebPDecodeRGBAInto()
        {
            // test WebPDecodeRGBAInto()

            foreach (var item in ImageList)
            {
                byte[] bytes = File.ReadAllBytes(item.Name);
                IntPtr data = Marshal.UnsafeAddrOfPinnedArrayElement(bytes, 0);

                //Allocate canvas
                Bitmap bitmap = new Bitmap(item.Width, item.Height, PixelFormat.Format32bppArgb);
                //Lock surface for writing
                BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, item.Width, item.Height), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

                IntPtr info = LibWebP.WebPDecodeRGBAInto(data, (uint)bytes.LongLength, bitmapData.Scan0, (uint)(bitmapData.Stride * bitmapData.Height), bitmapData.Stride);
                Assert.AreEqual(bitmapData.Scan0, info);

                //Unlock surface
                if (bitmapData != null && bitmap != null) bitmap.UnlockBits(bitmapData);
                //Dispose of bitmap if anything went wrong
                if (bitmap != null) bitmap.Dispose();
            }
        }

        [TestMethod]
        public void TestWebPDecodeARGBInto()
        {
            // test WebPDecodeARGBInto()

            foreach (var item in ImageList)
            {
                byte[] bytes = File.ReadAllBytes(item.Name);
                IntPtr data = Marshal.UnsafeAddrOfPinnedArrayElement(bytes, 0);

                //Allocate canvas
                Bitmap bitmap = new Bitmap(item.Width, item.Height, PixelFormat.Format32bppArgb);
                //Lock surface for writing
                BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, item.Width, item.Height), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

                IntPtr info = LibWebP.WebPDecodeARGBInto(data, (uint)bytes.LongLength, bitmapData.Scan0, (uint)(bitmapData.Stride * bitmapData.Height), bitmapData.Stride);
                Assert.AreEqual(bitmapData.Scan0, info);

                //Unlock surface
                if (bitmapData != null && bitmap != null) bitmap.UnlockBits(bitmapData);
                //Dispose of bitmap if anything went wrong
                if (bitmap != null) bitmap.Dispose();
            }
        }

        [TestMethod]
        public void TestWebPDecodeBGRAInto()
        {
            // test WebPDecodeBGRAInto()

            foreach (var item in ImageList)
            {
                byte[] bytes = File.ReadAllBytes(item.Name);
                IntPtr data = Marshal.UnsafeAddrOfPinnedArrayElement(bytes, 0);

                //Allocate canvas
                Bitmap bitmap = new Bitmap(item.Width, item.Height, PixelFormat.Format32bppArgb);
                //Lock surface for writing
                BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, item.Width, item.Height), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

                IntPtr info = LibWebP.WebPDecodeBGRAInto(data, (uint)bytes.LongLength, bitmapData.Scan0, (uint)(bitmapData.Stride * bitmapData.Height), bitmapData.Stride);
                Assert.AreEqual(bitmapData.Scan0, info);

                //Unlock surface
                if (bitmapData != null && bitmap != null) bitmap.UnlockBits(bitmapData);
                //Dispose of bitmap if anything went wrong
                if (bitmap != null) bitmap.Dispose();
            }
        }

        [TestMethod]
        public void TestWebPDecodeRGBInto()
        {
            // test WebPDecodeRGBInto()

            foreach (var item in ImageList)
            {
                byte[] bytes = File.ReadAllBytes(item.Name);
                IntPtr data = Marshal.UnsafeAddrOfPinnedArrayElement(bytes, 0);

                //Allocate canvas
                Bitmap bitmap = new Bitmap(item.Width, item.Height, PixelFormat.Format24bppRgb);
                //Lock surface for writing
                BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, item.Width, item.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

                IntPtr info = LibWebP.WebPDecodeRGBInto(data, (uint)bytes.LongLength, bitmapData.Scan0, (uint)(bitmapData.Stride * bitmapData.Height), bitmapData.Stride);
                Assert.AreEqual(bitmapData.Scan0, info);

                //Unlock surface
                if (bitmapData != null && bitmap != null) bitmap.UnlockBits(bitmapData);
                //Dispose of bitmap if anything went wrong
                if (bitmap != null) bitmap.Dispose();
            }
        }

        [TestMethod]
        public void TestWebPDecodeBGRInto()
        {
            // test WebPDecodeBGRInto()

            foreach (var item in ImageList)
            {
                byte[] bytes = File.ReadAllBytes(item.Name);
                IntPtr data = Marshal.UnsafeAddrOfPinnedArrayElement(bytes, 0);

                //Allocate canvas
                Bitmap bitmap = new Bitmap(item.Width, item.Height, PixelFormat.Format24bppRgb);
                //Lock surface for writing
                BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, item.Width, item.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

                IntPtr info = LibWebP.WebPDecodeBGRInto(data, (uint)bytes.LongLength, bitmapData.Scan0, (uint)(bitmapData.Stride * bitmapData.Height), bitmapData.Stride);
                Assert.AreEqual(bitmapData.Scan0, info);

                //Unlock surface
                if (bitmapData != null && bitmap != null) bitmap.UnlockBits(bitmapData);
                //Dispose of bitmap if anything went wrong
                if (bitmap != null) bitmap.Dispose();
            }
        }

        [TestMethod]
        public void TestWebPDecodeYUVInto()
        {
            // test WebPDecodeYUVInto()

            foreach (var item in ImageList)
            {
                byte[] bytes = File.ReadAllBytes(item.Name);
                IntPtr data = Marshal.UnsafeAddrOfPinnedArrayElement(bytes, 0);

                uint lumaSize = (uint)(item.Width * item.Height);
                IntPtr luma = new IntPtr(lumaSize);

                uint uSize = (uint)(((item.Width + 1) / 2) * ((item.Height + 1) / 2));
                IntPtr u = new IntPtr(uSize);

                uint vSize = (uint)(((item.Width + 1) / 2) * ((item.Height + 1) / 2));
                IntPtr v = new IntPtr(vSize);

                int lumaStride = item.Width;
                int uStride = item.Width;
                int vStride = item.Width;

                IntPtr y = LibWebP.WebPDecodeYUVInto(data, (uint)bytes.LongLength, luma, lumaSize, lumaStride,
                    u, uSize, uStride, v, vSize, vStride);
                Assert.AreNotEqual(0, y);
            }
        }

        [TestMethod]
        public void TestWebPInitDecBuffer()
        {
            // test WebPInitDecBuffer()

            WebPDecBuffer buffer = new WebPDecBuffer();
            int result = LibWebP.WebPInitDecBuffer(ref buffer);
            Assert.AreNotEqual(0, result);
            return;
        }

        [TestMethod]
        public void TestWebPFreeDecBuffer()
        {
            // test WebPFreeDecBuffer()

            WebPDecBuffer buffer = new WebPDecBuffer();
            int result = LibWebP.WebPInitDecBuffer(ref buffer);
            Assert.AreNotEqual(0, result);

            LibWebP.WebPFreeDecBuffer(ref buffer);

            return;
        }

        [TestMethod]
        public void TestWebPINewDecoder()
        {
            // test WebPINewDecoder()

            WebPDecBuffer buffer = new WebPDecBuffer();
            int result = LibWebP.WebPInitDecBuffer(ref buffer);
            Assert.AreNotEqual(0, result);

            IntPtr decoder = LibWebP.WebPINewDecoder(ref buffer);
            Assert.AreNotEqual(null, decoder);

            WebPIDecoder webPIDecoder = Utils.IntPtrToStruct<WebPIDecoder>(decoder);

            return;
        }

        [TestMethod]
        public void TestWebPINewRGB()
        {
            // test WebPINewRGB()

            uint size = 1024 * 1024;
            IntPtr output = new IntPtr(size);

            IntPtr decoder = LibWebP.WebPINewRGB(WEBP_CSP_MODE.MODE_BGR, output, size, 1024);
            Assert.AreNotEqual(null, decoder);

            WebPIDecoder webPIDecoder = Utils.IntPtrToStruct<WebPIDecoder>(decoder);

            return;
        }

        [TestMethod]
        public void TestWebPINewYUVA()
        {
            // test WebPINewYUVA()

            uint lumaSize = (uint)(1024 * 1024);
            IntPtr luma = new IntPtr(lumaSize);

            uint uSize = (uint)(((1024 + 1) / 2) * ((1024 + 1) / 2));
            IntPtr u = new IntPtr(uSize);

            uint vSize = (uint)(((1024 + 1) / 2) * ((1024 + 1) / 2));
            IntPtr v = new IntPtr(vSize);

            uint aSize = (uint)(((1024 + 1) / 2) * ((1024 + 1) / 2));
            IntPtr a = new IntPtr(aSize);

            int lumaStride = 1024;
            int uStride = 1024;
            int vStride = 1024;
            int aStride = 1024;

            IntPtr decoder = LibWebP.WebPINewYUVA(luma, lumaSize, lumaStride,
                u, uSize, uStride,
                v, vSize, vStride,
                a, aSize, aStride);

            Assert.AreNotEqual(null, decoder);

            WebPIDecoder webPIDecoder = Utils.IntPtrToStruct<WebPIDecoder>(decoder);

            return;
        }

        [TestMethod]
        public void TestWebPINewYUV()
        {
            // test WebPINewYUV()

            uint lumaSize = (uint)(1024 * 1024);
            IntPtr luma = new IntPtr(lumaSize);

            uint uSize = (uint)(((1024 + 1) / 2) * ((1024 + 1) / 2));
            IntPtr u = new IntPtr(uSize);

            uint vSize = (uint)(((1024 + 1) / 2) * ((1024 + 1) / 2));
            IntPtr v = new IntPtr(vSize);

            int lumaStride = 1024;
            int uStride = 1024;
            int vStride = 1024;

            IntPtr decoder = LibWebP.WebPINewYUV(luma, lumaSize, lumaStride,
                u, uSize, uStride,
                v, vSize, vStride);

            Assert.AreNotEqual(null, decoder);

            WebPIDecoder webPIDecoder = Utils.IntPtrToStruct<WebPIDecoder>(decoder);

            return;
        }

        [TestMethod]
        public void TestWebPIDelete()
        {
            // test WebPIDelete()

            WebPDecBuffer buffer = new WebPDecBuffer();
            int result = LibWebP.WebPInitDecBuffer(ref buffer);
            Assert.AreNotEqual(0, result);

            IntPtr decoder = LibWebP.WebPINewDecoder(ref buffer);
            Assert.AreNotEqual(null, decoder);

            WebPIDecoder webPIDecoder = Utils.IntPtrToStruct<WebPIDecoder>(decoder);

            LibWebP.WebPIDelete(ref webPIDecoder);
        }

        [TestMethod]
        public void TestWebPIAppend()
        {
            // test WebPIAppend()
            // something wrong

            WebPDecBuffer buffer = new WebPDecBuffer();
            int result = LibWebP.WebPInitDecBuffer(ref buffer);
            Assert.AreNotEqual(0, result);

            IntPtr decoder = LibWebP.WebPINewDecoder(ref buffer);
            Assert.AreNotEqual(null, decoder);

            WebPIDecoder webPIDecoder = Utils.IntPtrToStruct<WebPIDecoder>(decoder);

            uint size = 1024 * 1024;
            IntPtr data = new IntPtr(size);

            VP8StatusCode status = LibWebP.WebPIAppend(ref webPIDecoder, data, size);
            Assert.AreEqual(VP8StatusCode.VP8_STATUS_OK, status);
        }

        [TestMethod]
        public void TestWebPIUpdate()
        {
            // test WebPIUpdate()
            // something wrong

            WebPDecBuffer buffer = new WebPDecBuffer();
            int result = LibWebP.WebPInitDecBuffer(ref buffer);
            Assert.AreNotEqual(0, result);

            IntPtr decoder = LibWebP.WebPINewDecoder(ref buffer);
            Assert.AreNotEqual(null, decoder);

            WebPIDecoder webPIDecoder = Utils.IntPtrToStruct<WebPIDecoder>(decoder);

            uint size = 1024 * 1024;
            IntPtr data = new IntPtr(size);

            VP8StatusCode status = LibWebP.WebPIUpdate(ref webPIDecoder, data, size);
            Assert.AreEqual(VP8StatusCode.VP8_STATUS_OK, status);
        }

        [TestMethod]
        public void TestWebPIDecGetRGB()
        {
            // test WebPIDecGetRGB()

            WebPDecBuffer buffer = new WebPDecBuffer();
            int result = LibWebP.WebPInitDecBuffer(ref buffer);
            Assert.AreNotEqual(0, result);

            IntPtr decoder = LibWebP.WebPINewDecoder(ref buffer);
            Assert.AreNotEqual(null, decoder);

            WebPIDecoder webPIDecoder = Utils.IntPtrToStruct<WebPIDecoder>(decoder);

            int lastY = 0;
            int width = 0;
            int height = 0;
            int stride = 0;

            IntPtr r = LibWebP.WebPIDecGetRGB(ref webPIDecoder, ref lastY, ref width, ref height, ref stride);
            Assert.AreNotEqual(null, r);
        }

        [TestMethod]
        public void TestWebPIDecGetYUVA()
        {
            // test WebPIDecGetYUVA()

            WebPDecBuffer buffer = new WebPDecBuffer();
            int result = LibWebP.WebPInitDecBuffer(ref buffer);
            Assert.AreNotEqual(0, result);

            IntPtr decoder = LibWebP.WebPINewDecoder(ref buffer);
            Assert.AreNotEqual(null, decoder);

            WebPIDecoder webPIDecoder = Utils.IntPtrToStruct<WebPIDecoder>(decoder);

            uint uSize = (uint)(((1024 + 1) / 2) * ((1024 + 1) / 2));
            IntPtr u = new IntPtr(uSize);

            uint vSize = (uint)(((1024 + 1) / 2) * ((1024 + 1) / 2));
            IntPtr v = new IntPtr(vSize);

            uint aSize = (uint)(((1024 + 1) / 2) * ((1024 + 1) / 2));
            IntPtr a = new IntPtr(aSize);

            int lastY = 0;
            int width = 0;
            int height = 0;
            int stride = 0;
            int uvStride = 0;
            int aStride = 0;

            IntPtr r = LibWebP.WebPIDecGetYUVA(ref webPIDecoder, ref lastY, u, v, a,
                ref width, ref height, ref stride, ref uvStride, ref aStride);
            Assert.AreNotEqual(null, r);
        }

        [TestMethod]
        public void TestWebPIDecodedArea()
        {
            // test WebPIDecodedArea()

            WebPDecBuffer buffer = new WebPDecBuffer();
            int result = LibWebP.WebPInitDecBuffer(ref buffer);
            Assert.AreNotEqual(0, result);

            IntPtr decoder = LibWebP.WebPINewDecoder(ref buffer);
            Assert.AreNotEqual(null, decoder);

            WebPIDecoder webPIDecoder = Utils.IntPtrToStruct<WebPIDecoder>(decoder);

            int left = 0;
            int top = 0;
            int width = 0;
            int height = 0;

            IntPtr r = LibWebP.WebPIDecodedArea(ref webPIDecoder, ref left, ref top, ref width, ref height);
            Assert.AreNotEqual(null, r);
        }

        [TestMethod]
        public void TestWebPGetFeatures()
        {
            // test WebPGetFeatures()

            foreach (var item in ImageList)
            {
                byte[] bytes = File.ReadAllBytes(item.Name);
                IntPtr data = Marshal.UnsafeAddrOfPinnedArrayElement(bytes, 0);

                WebPBitstreamFeatures features = new WebPBitstreamFeatures();

                VP8StatusCode code = LibWebP.WebPGetFeatures(data, (uint)bytes.LongLength, ref features);
                Assert.AreEqual(VP8StatusCode.VP8_STATUS_OK, code);

                Assert.AreEqual(item.Width, features.Width);
                Assert.AreEqual(item.Height, features.Height);
                Assert.AreEqual(item.HasAlpha, features.HasAlpha);
                Assert.AreEqual(item.HasAnimation, features.HasAnimation);
                Assert.AreEqual(item.Format, features.Format);

                //Console.WriteLine("Width: {0}, Height: {1}, HasAlpha: {2}, HasAnimation: {3}, Format: {4}",
                //    features.Width, features.Height,
                //    features.HasAlpha, features.HasAnimation, features.Format);
            }
        }

        [TestMethod]
        public void TestWebPInitDecoderConfig()
        {
            // test WebPInitDecoderConfig()

            WebPDecoderConfig config = new WebPDecoderConfig();

            int result = LibWebP.WebPInitDecoderConfig(ref config);
            Assert.AreNotEqual(0, result);
        }

        [TestMethod]
        public void TestWebPIDecode()
        {
            // test WebPIDecode()

            foreach (var item in ImageList)
            {
                byte[] bytes = File.ReadAllBytes(item.Name);
                IntPtr data = Marshal.UnsafeAddrOfPinnedArrayElement(bytes, 0);

                WebPDecoderConfig config = new WebPDecoderConfig();

                IntPtr result = LibWebP.WebPIDecode(data, (uint)bytes.LongLength, ref config);
                Assert.AreNotEqual(null, result);
            }
        }

        [TestMethod]
        public void TestWebPDecode()
        {
            // test WebPDecode()

            foreach (var item in ImageList)
            {
                byte[] bytes = File.ReadAllBytes(item.Name);
                IntPtr data = Marshal.UnsafeAddrOfPinnedArrayElement(bytes, 0);

                WebPDecoderConfig config = new WebPDecoderConfig();

                VP8StatusCode result = LibWebP.WebPDecode(data, (uint)bytes.LongLength, ref config);
                Assert.AreEqual(VP8StatusCode.VP8_STATUS_OK, result);

            }
        }

        #endregion

        #region WebP encode

        [TestMethod]
        public void TestWebPGetEncoderVersion()
        {
            // test WebPGetEncoderVersion()
            int version = LibWebP.WebPGetEncoderVersion();

            var revision = version % 256;
            var minor = (version >> 8) % 256;
            var major = (version >> 16) % 256;
            string versionName = major + "." + minor + "." + revision;

            // libwebp-1.2.2
            Assert.AreEqual(66050, version);
            Assert.AreEqual("1.2.2", versionName);
        }


        [TestMethod]
        public void TestTemp()
        {
            byte[] bytes = File.ReadAllBytes(ImageList[0].Name);
            IntPtr data = Marshal.UnsafeAddrOfPinnedArrayElement(bytes, 0);

            WebPPicture picture = new WebPPicture();
            LibWebP.WebPMemoryWrite(data, (uint)bytes.LongLength,ref picture);

            //WebPPicture src = new WebPPicture();
            //WebPPicture reference = new WebPPicture();
            float[] result = new float[5];

            int b = LibWebP.WebPPictureDistortion(ref picture, ref picture, 1, ref result);

            Console.WriteLine(b);
            Console.WriteLine(result[0]);
            Console.WriteLine(result[1]);
            Console.WriteLine(result[2]);
            Console.WriteLine(result[3]);
            Console.WriteLine(result[4]);
        }


        #endregion


    }

    struct Image
    {
        public string Name;
        public int Width;
        public int Height;
        public int HasAlpha;
        public int HasAnimation;
        public int Format;
    }

}
