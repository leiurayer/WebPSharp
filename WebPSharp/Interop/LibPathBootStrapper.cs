using System;
using System.IO;

namespace WebPSharp.Interop
{
    internal class LibPathBootStrapper
    {
        internal static string LibPath { get; private set; }

        static LibPathBootStrapper()
        {
            string fileName = null;
            if (NativeLibraryLoader.IsWindows)
            {
                if (NativeLibraryLoader.Is64Bit)
                {
                    fileName = "libwebp.dll";
                }
                else
                {
                    fileName = "libwebp.dll";
                }
            }
            else if (NativeLibraryLoader.IsLinux)
            {
                if (NativeLibraryLoader.Is64Bit)
                {
                    fileName = "libwebp.so";
                }
                else
                {
                    fileName = "libwebp.so";
                }
            }
            else if (NativeLibraryLoader.IsMacOSX)
            {
                if (NativeLibraryLoader.Is64Bit)
                {
                    fileName = "libwebp.dylib";
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
