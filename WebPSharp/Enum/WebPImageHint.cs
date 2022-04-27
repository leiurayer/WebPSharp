namespace WebPSharp.Enum
{
    // Image characteristics hint for the underlying encoder.
    public enum WebPImageHint : int
    {
        WEBP_HINT_DEFAULT = 0,  // default preset.
        WEBP_HINT_PICTURE,      // digital picture, like portrait, inner shot
        WEBP_HINT_PHOTO,        // outdoor photograph, with natural lighting
        WEBP_HINT_GRAPH,        // Discrete tone image (graph, map-tile etc).
        WEBP_HINT_LAST
    }
}
