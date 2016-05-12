using System;
using System.IO;

namespace csharp_tutorials.src.File_IO
{
    class _03_Directory_and_DirectoryInfo
    {
        public static void Main()
        {
            string directoryName = "testDirectory";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (!Directory.Exists(path + "\\" + directoryName)) //An alternative to @ is to escape the \
            {
                DirectoryInfo dInfo = new DirectoryInfo(path + "\\" + directoryName);
                dInfo.Create();
            }
        }
    }
}
