using System;
using System.IO;

namespace csharp_tutorials.src.File_IO
{
    class _02_File_and_FileInfo
    {
        public static void Main()
        {
            string fileName = "testFile.txt";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //You can specify your own path as a string here!

            if (!File.Exists(path + @"\" + fileName)) //The @ sign ensures you dont have to escape characters in a string.
            {
                FileInfo fInfo = new FileInfo(path + fileName);
                FileStream fStream = fInfo.Create();
                fStream.Close();
            }
        }
    }
}
