using System;
using System.Runtime.InteropServices;

namespace WebPSharp
{
    public static class Utils
    {
        public static IntPtr StructToIntPtr<T>(T info)
        {
            int size = Marshal.SizeOf(info);
            IntPtr intPtr = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(info, intPtr, true);
            return intPtr;
        }

        public static T IntPtrToStruct<T>(IntPtr info)
        {
            return (T)Marshal.PtrToStructure(info, typeof(T));
        }

    }
}
