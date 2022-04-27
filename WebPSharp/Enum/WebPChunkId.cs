namespace WebPSharp.Enum
{
    // IDs for different types of chunks.
    public enum WebPChunkId : int
    {
        WEBP_CHUNK_VP8X,        // VP8X
        WEBP_CHUNK_ICCP,        // ICCP
        WEBP_CHUNK_ANIM,        // ANIM
        WEBP_CHUNK_ANMF,        // ANMF
        WEBP_CHUNK_DEPRECATED,  // (deprecated from FRGM)
        WEBP_CHUNK_ALPHA,       // ALPH
        WEBP_CHUNK_IMAGE,       // VP8/VP8L
        WEBP_CHUNK_EXIF,        // EXIF
        WEBP_CHUNK_XMP,         // XMP
        WEBP_CHUNK_UNKNOWN,     // Other chunks.
        WEBP_CHUNK_NIL
    }
}
