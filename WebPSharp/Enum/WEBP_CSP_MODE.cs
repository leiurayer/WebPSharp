namespace WebPSharp.Enum
{
    public enum WEBP_CSP_MODE : int
    {
        MODE_RGB = 0,
        MODE_RGBA = 1,
        MODE_BGR = 2,
        MODE_BGRA = 3,
        MODE_ARGB = 4,
        MODE_RGBA_4444 = 5,
        MODE_RGB_565 = 6,
        // RGB-premultiplied transparent modes (alpha value is preserved)
        MODE_rgbA = 7,
        MODE_bgrA = 8,
        MODE_Argb = 9,
        MODE_rgbA_4444 = 10,
        // YUV modes must come after RGB ones.
        MODE_YUV = 11,
        MODE_YUVA = 12,  // yuv 4:2:0
        MODE_LAST = 13
    }
}
