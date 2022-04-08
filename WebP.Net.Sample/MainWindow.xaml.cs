using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Media.Imaging;
using WebP.Net.Enum;
using WebP.Net.Exception;
using WebP.Net.Struct;

namespace WebP.Net.Sample
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            byte[] bytes = File.ReadAllBytes("Gallery/WebP Gallery/1.webp");
            //byte[] bytes = File.ReadAllBytes("Gallery/Lossless and Alpha Gallery/1_webp_a.webp");
            IntPtr data = Marshal.UnsafeAddrOfPinnedArrayElement(bytes, 0);
            WebPBitstreamFeatures features = new WebPBitstreamFeatures();

            VP8StatusCode code = LibWebP.WebPGetFeatures(data, (uint)bytes.LongLength, ref features);
            if (code != VP8StatusCode.VP8_STATUS_OK)
            {
                return;
            }

            int width = features.Width;
            int height = features.Height;
            Bitmap bitmap;
            BitmapData bitmapData;

            if (features.HasAlpha == 0)
            {
                //Allocate canvas
                bitmap = new Bitmap(width, height, PixelFormat.Format24bppRgb);
                //Lock surface for writing
                bitmapData = bitmap.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

                IntPtr info = LibWebP.WebPDecodeBGRInto(data, (uint)bytes.LongLength, bitmapData.Scan0, (uint)(bitmapData.Stride * bitmapData.Height), bitmapData.Stride);
                if (bitmapData.Scan0 != info)
                {
                    throw new System.Exception("Failed to decode WebP image with error " + (long)info);
                }
            }
            else
            {
                //Allocate canvas
                bitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb);
                //Lock surface for writing
                bitmapData = bitmap.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

                IntPtr info = LibWebP.WebPDecodeBGRAInto(data, (uint)bytes.LongLength, bitmapData.Scan0, (uint)(bitmapData.Stride * bitmapData.Height), bitmapData.Stride);
                if (bitmapData.Scan0 != info)
                {
                    throw new WebPException("Failed to decode WebP image with error " + (long)info);
                }
            }

            //Unlock surface
            if (bitmapData != null && bitmap != null) bitmap.UnlockBits(bitmapData);
            //Dispose of bitmap if anything went wrong
            //if (bitmap != null) bitmap.Dispose();

            nameTestWebP.Source = BitmapToBitmapImage(bitmap, ImageFormat.Png);
            nameTestWebP.Width = width;
            nameTestWebP.Height = height;

            bitmap.Save("test.png", ImageFormat.Png);
        }


        /// <summary>
        /// Bitmap to BitmapImage
        /// </summary>
        /// <param name="bitmap"></param>
        /// <returns></returns>
        public static BitmapImage BitmapToBitmapImage(Bitmap bitmap, ImageFormat format)
        {
            BitmapImage result = new BitmapImage();
            using (MemoryStream stream = new MemoryStream())
            {
                bitmap.Save(stream, format);
                stream.Position = 0;
                result.BeginInit();
                result.CacheOption = BitmapCacheOption.OnLoad;
                result.StreamSource = stream;
                result.EndInit();
                result.Freeze();
            }
            return result;
        }

    }
}
