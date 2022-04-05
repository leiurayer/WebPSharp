using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace WebP.Net.Test
{
    [TestClass]
    public class TestLibWebP
    {
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

            WebPGetInfo("Gallery/WebP Gallery/1.webp", 550, 368);
            WebPGetInfo("Gallery/WebP Gallery/2.webp", 550, 404);
            WebPGetInfo("Gallery/WebP Gallery/3.webp", 1280, 720);
            WebPGetInfo("Gallery/WebP Gallery/4.webp", 1024, 772);
            WebPGetInfo("Gallery/WebP Gallery/5.webp", 1024, 752);
        }

        private void WebPGetInfo(string img, int destWidth, int destHeight)
        {
            int width = 0;
            int height = 0;
            byte[] bytes = File.ReadAllBytes(img);
            IntPtr data = Marshal.UnsafeAddrOfPinnedArrayElement(bytes, 0);

            int info = LibWebP.WebPGetInfo(data, (uint)bytes.LongLength, ref width, ref height);
            Assert.AreEqual(1, info);
            Assert.AreEqual(destWidth, width);
            Assert.AreEqual(destHeight, height);
        }

        [TestMethod]
        public void TestWebPDecodeRGBA()
        {
            // test WebPDecodeRGBA()

            WebPDecodeRGBA("Gallery/WebP Gallery/1.webp", 550, 368);
            WebPDecodeRGBA("Gallery/WebP Gallery/2.webp", 550, 404);
            WebPDecodeRGBA("Gallery/WebP Gallery/3.webp", 1280, 720);
            WebPDecodeRGBA("Gallery/WebP Gallery/4.webp", 1024, 772);
            WebPDecodeRGBA("Gallery/WebP Gallery/5.webp", 1024, 752);
        }

        private void WebPDecodeRGBA(string img, int destWidth, int destHeight)
        {
            int width = 0;
            int height = 0;
            byte[] bytes = File.ReadAllBytes(img);
            IntPtr data = Marshal.UnsafeAddrOfPinnedArrayElement(bytes, 0);

            IntPtr info = LibWebP.WebPDecodeRGBA(data, (uint)bytes.LongLength, ref width, ref height);
            Assert.AreNotEqual(0, info);
            Assert.AreEqual(destWidth, width);
            Assert.AreEqual(destHeight, height);
        }

        [TestMethod]
        public void TestWebPDecodeARGB()
        {
            // test WebPDecodeARGB()

            WebPDecodeARGB("Gallery/WebP Gallery/1.webp", 550, 368);
            WebPDecodeARGB("Gallery/WebP Gallery/2.webp", 550, 404);
            WebPDecodeARGB("Gallery/WebP Gallery/3.webp", 1280, 720);
            WebPDecodeARGB("Gallery/WebP Gallery/4.webp", 1024, 772);
            WebPDecodeARGB("Gallery/WebP Gallery/5.webp", 1024, 752);
        }

        private void WebPDecodeARGB(string img, int destWidth, int destHeight)
        {
            int width = 0;
            int height = 0;
            byte[] bytes = File.ReadAllBytes(img);
            IntPtr data = Marshal.UnsafeAddrOfPinnedArrayElement(bytes, 0);

            IntPtr info = LibWebP.WebPDecodeARGB(data, (uint)bytes.LongLength, ref width, ref height);
            Assert.AreNotEqual(0, info);
            Assert.AreEqual(destWidth, width);
            Assert.AreEqual(destHeight, height);
        }

        [TestMethod]
        public void TestWebPDecodeBGRA()
        {
            // test WebPDecodeBGRA()

            WebPDecodeBGRA("Gallery/WebP Gallery/1.webp", 550, 368);
            WebPDecodeBGRA("Gallery/WebP Gallery/2.webp", 550, 404);
            WebPDecodeBGRA("Gallery/WebP Gallery/3.webp", 1280, 720);
            WebPDecodeBGRA("Gallery/WebP Gallery/4.webp", 1024, 772);
            WebPDecodeBGRA("Gallery/WebP Gallery/5.webp", 1024, 752);
        }

        private void WebPDecodeBGRA(string img, int destWidth, int destHeight)
        {
            int width = 0;
            int height = 0;
            byte[] bytes = File.ReadAllBytes(img);
            IntPtr data = Marshal.UnsafeAddrOfPinnedArrayElement(bytes, 0);

            IntPtr info = LibWebP.WebPDecodeBGRA(data, (uint)bytes.LongLength, ref width, ref height);
            Assert.AreNotEqual(0, info);
            Assert.AreEqual(destWidth, width);
            Assert.AreEqual(destHeight, height);
        }

        [TestMethod]
        public void TestWebPDecodeRGB()
        {
            // test WebPDecodeRGB()

            WebPDecodeRGB("Gallery/WebP Gallery/1.webp", 550, 368);
            WebPDecodeRGB("Gallery/WebP Gallery/2.webp", 550, 404);
            WebPDecodeRGB("Gallery/WebP Gallery/3.webp", 1280, 720);
            WebPDecodeRGB("Gallery/WebP Gallery/4.webp", 1024, 772);
            WebPDecodeRGB("Gallery/WebP Gallery/5.webp", 1024, 752);
        }

        private void WebPDecodeRGB(string img, int destWidth, int destHeight)
        {
            int width = 0;
            int height = 0;
            byte[] bytes = File.ReadAllBytes(img);
            IntPtr data = Marshal.UnsafeAddrOfPinnedArrayElement(bytes, 0);

            IntPtr info = LibWebP.WebPDecodeRGB(data, (uint)bytes.LongLength, ref width, ref height);
            Assert.AreNotEqual(0, info);
            Assert.AreEqual(destWidth, width);
            Assert.AreEqual(destHeight, height);
        }

        [TestMethod]
        public void TestWebPDecodeBGR()
        {
            // test WebPDecodeBGR()

            WebPDecodeBGR("Gallery/WebP Gallery/1.webp", 550, 368);
            WebPDecodeBGR("Gallery/WebP Gallery/2.webp", 550, 404);
            WebPDecodeBGR("Gallery/WebP Gallery/3.webp", 1280, 720);
            WebPDecodeBGR("Gallery/WebP Gallery/4.webp", 1024, 772);
            WebPDecodeBGR("Gallery/WebP Gallery/5.webp", 1024, 752);
        }

        private void WebPDecodeBGR(string img, int destWidth, int destHeight)
        {
            int width = 0;
            int height = 0;
            byte[] bytes = File.ReadAllBytes(img);
            IntPtr data = Marshal.UnsafeAddrOfPinnedArrayElement(bytes, 0);

            IntPtr info = LibWebP.WebPDecodeBGR(data, (uint)bytes.LongLength, ref width, ref height);
            Assert.AreNotEqual(0, info);
            Assert.AreEqual(destWidth, width);
            Assert.AreEqual(destHeight, height);
        }


    }
}
