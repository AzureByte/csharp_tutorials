using System;
using System.IO;

namespace csharp_tutorials.src.File_IO
{
    class _03_Directory_and_DirectoryInfo
    {
        public static void Main()
        {
            string directoryName = "testDirectory";

            if (!Directory.Exists(@"c:\users\neville\desktop\" + directoryName))
            {
                DirectoryInfo dInfo = new DirectoryInfo(@"c:\users\neville\desktop\" + directoryName);
                dInfo.Create();
            }
        }
    }
}
