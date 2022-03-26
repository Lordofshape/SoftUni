using System;

namespace P03_Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] path = Console.ReadLine().Split('\\');
            string[] extensionAndFileName = path[path.Length-1].Split('.');
            string fileName = extensionAndFileName[0];
            string extension = extensionAndFileName[extensionAndFileName.Length-1];
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
            
        }
    }
}
