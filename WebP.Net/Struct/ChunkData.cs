using System.Runtime.InteropServices;

namespace WebP.Net.Struct
{
    //    typedef struct {
    //  size_t offset_;
    //    size_t size_;
    //}ChunkData;

    [StructLayout(LayoutKind.Sequential)]
    public struct ChunkData
    {
        public uint Offset;
        public uint Size;
    }
}
