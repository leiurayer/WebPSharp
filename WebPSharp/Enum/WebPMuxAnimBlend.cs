namespace WebPSharp.Enum
{
    // Blend operation (animation only). Indicates how transparent pixels of the
    // current frame are blended with those of the previous canvas.
    public enum WebPMuxAnimBlend : int
    {
        WEBP_MUX_BLEND,              // Blend.
        WEBP_MUX_NO_BLEND            // Do not blend.
    }
}
