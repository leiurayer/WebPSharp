namespace WebP.Net.Enum
{
    // Encoding error conditions.
    public enum WebPEncodingError : int
    {
        VP8_ENC_OK = 0,
        VP8_ENC_ERROR_OUT_OF_MEMORY,            // memory error allocating objects
        VP8_ENC_ERROR_BITSTREAM_OUT_OF_MEMORY,  // memory error while flushing bits
        VP8_ENC_ERROR_NULL_PARAMETER,           // a pointer parameter is NULL
        VP8_ENC_ERROR_INVALID_CONFIGURATION,    // configuration is invalid
        VP8_ENC_ERROR_BAD_DIMENSION,            // picture has invalid width/height
        VP8_ENC_ERROR_PARTITION0_OVERFLOW,      // partition is bigger than 512k
        VP8_ENC_ERROR_PARTITION_OVERFLOW,       // partition is bigger than 16M
        VP8_ENC_ERROR_BAD_WRITE,                // error while flushing bytes
        VP8_ENC_ERROR_FILE_TOO_BIG,             // file is bigger than 4G
        VP8_ENC_ERROR_USER_ABORT,               // abort request by user
        VP8_ENC_ERROR_LAST                      // list terminator. always last.
    }
}
