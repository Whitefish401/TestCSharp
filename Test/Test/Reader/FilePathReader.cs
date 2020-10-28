using System;

namespace CSharpTest
{
    class FilePathReader
    {
        public string WriteFilePath()
        {
            Console.WriteLine("Enter Path");
            var dirPath = @"" + Console.ReadLine();
            return dirPath;
        }
    }
}