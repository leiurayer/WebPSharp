namespace WebP.Net.Enum
{
    public enum CPUFeature : int
    {
        kSSE2,
        kSSE3,
        kSlowSSSE3,  // special feature for slow SSSE3 architectures
        kSSE4_1,
        kAVX,
        kAVX2,
        kNEON,
        kMIPS32,
        kMIPSdspR2,
        kMSA
    }
}
