using System;
using System.IO;

namespace WebPSharp.Interop
{
    internal class MuxLibPathBootStrapper
    {
        internal static string LibPath { get; private set; }

        static MuxLibPathBootStrapper()
        {
            string fileName = null;
            if (NativeLibraryLoader.IsWindows)
            {
                if (NativeLibraryLoader.Is64Bit)
                {
                    fileName = "libwebpmux.dll";
                }
                else
                {
                    fileName = "libwebpmux.dll";
                }
            }
            else if (NativeLibraryLoader.IsLinux)
            {
                if (NativeLibraryLoader.Is64Bit)
                {
                    fileName = "libwebpmux.so";
                }
                else
                {
                    fileName = "libwebpmux.so";
                }
            }
            else if (NativeLibraryLoader.IsMacOSX)
            {
                if (NativeLibraryLoader.Is64Bit)
                {
                    fileName = "libwebpmux.dylib";
                }
            }
            if (string.IsNullOrEmpty(fileName)) throw new NotSupportedException($"OS not supported:{Environment.OSVersion}");
            var paths = NativeLibraryLoader.GetPossibleRuntimeDirectories();
            var libFound = false;
            foreach (var path in paths)
            {
                var fullPath = Path.Combine(path, fileName);
                if (File.Exists(fullPath))
                {
                    LibPath = fullPath;
                    libFound = true;
                    break;
                }
            }

            if (!libFound) throw new NotSupportedException($"Unable to find library {fileName}");
        }
    }
}
