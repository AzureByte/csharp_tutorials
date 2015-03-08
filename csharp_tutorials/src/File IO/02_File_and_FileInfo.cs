using System;
using System.IO;

namespace csharp_tutorials.src.File_IO
{
    class _02_File_and_FileInfo
    {
        public static void Main()
        {
            string fileName = "testFile.txt";

            if (!File.Exists(@"c:\users\neville\desktop\" + fileName))
            {
                FileInfo fInfo = new FileInfo(@"c:\users\neville\desktop\" + fileName);
                FileStream fStream = fInfo.Create();
                fStream.Close();
            }
        }
    }
}
