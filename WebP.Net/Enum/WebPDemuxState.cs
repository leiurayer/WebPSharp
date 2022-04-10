namespace WebP.Net.Enum
{
    public enum WebPDemuxState : int
    {
        WEBP_DEMUX_PARSE_ERROR = -1,  // An error occurred while parsing.
        WEBP_DEMUX_PARSING_HEADER = 0,  // Not enough data to parse full header.
        WEBP_DEMUX_PARSED_HEADER = 1,  // Header parsing complete,
                                       // data may be available.
        WEBP_DEMUX_DONE = 2   // Entire file has been parsed.
    }
}
