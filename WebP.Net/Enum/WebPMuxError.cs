namespace WebP.Net.Enum
{
    // Error codes
    public enum WebPMuxError : int
    {
        WEBP_MUX_OK = 1,
        WEBP_MUX_NOT_FOUND = 0,
        WEBP_MUX_INVALID_ARGUMENT = -1,
        WEBP_MUX_BAD_DATA = -2,
        WEBP_MUX_MEMORY_ERROR = -3,
        WEBP_MUX_NOT_ENOUGH_DATA = -4
    }
}
