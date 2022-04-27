using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Drawing;
using WebPSharp.Struct;

namespace WebPSharp.Test
{
    [TestClass]
    public class TestSimpleDecoder
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

        [TestMethod]
        public void TestWebPtoBitmap()
        {
            foreach (var item in ImageList)
            {
                SimpleDecoder simpleDecoder = new SimpleDecoder(item.Name);
                Bitmap bitmap = simpleDecoder.WebPtoBitmap();

                WebPBitstreamFeatures features = new WebPBitstreamFeatures();
                bitmap = simpleDecoder.WebPtoBitmap(ref features);

                //Assert.AreEqual(1, info);
                Assert.AreEqual(item.Width, features.Width);
                Assert.AreEqual(item.Height, features.Height);
            }


        }
    }
}
