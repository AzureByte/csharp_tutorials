using System;
using System.IO;

namespace csharp_tutorials.src.File_IO
{
    class PathClass
    {
        public static void Main()
        {
            //path where my file resides
            string pathString = @"C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\machine.config";

            Console.WriteLine("Path Root : " + Path.GetPathRoot(pathString) + "\n");
            Console.WriteLine("Full Path : " + Path.GetFullPath(pathString) + "\n");
            Console.WriteLine("Directory name : " + Path.GetDirectoryName(pathString) + "\n");
            Console.WriteLine("Filename : " + Path.GetFileName(pathString) + "\n");
            Console.WriteLine("Has Extension : " + Path.HasExtension(pathString) + "\n");
            Console.WriteLine("Extension : " + Path.GetExtension(pathString) + "\n");
            Console.WriteLine("Filename without extension : " + Path.GetFileNameWithoutExtension(pathString) + "\n");
            Console.WriteLine("Is Path Rooted : " + Path.IsPathRooted(pathString) + "\n");

            Console.WriteLine("--------------------\n");

            Console.WriteLine("Random filename : " + Path.GetRandomFileName() + "\n");
            Console.WriteLine("Temporary filename : " + Path.GetTempFileName() + "\n");
            Console.WriteLine("Temporary path : " + Path.GetTempPath() + "\n");

            //get all the characters which are invalid for path names
            char[] invalidPathChars = Path.GetInvalidPathChars();
            Console.Write("Invalid Path Chars : ");
            foreach (char character in invalidPathChars)
            {
                Console.Write(character + " ");
            }
            Console.WriteLine("\n");

            //get all the characters which are invalid for file names
            char[] invalidFileChars = Path.GetInvalidFileNameChars();
            Console.Write("Invalid Filename Chars : ");
            foreach (char character in invalidFileChars)
            {
                Console.Write(character + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
