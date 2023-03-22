using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using System.Threading.Tasks;

namespace Filedirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = @"C:\Users\nitesh01\source\repos\Directoryforassignment";

            // 1. Return the number of text files in the directory (*.txt).
            int numTextFiles = Directory.GetFiles(directoryPath, "*.txt").Length;
            Console.WriteLine($"Number of text files: {numTextFiles}");



            // 2. Return the number of files per extension type.
            var filesByExtension = Directory.GetFiles(directoryPath)
                .GroupBy(file => Path.GetExtension(file).ToLower())
                .OrderByDescending(group => group.Count());
            foreach (var group in filesByExtension)
            {
                Console.WriteLine($"Extension: {group.Key}, count: {group.Count()}");
            }




            // 3. Return the top 5 largest files, along with their file size (use anonymous types).
            var largestFiles = Directory.GetFiles(directoryPath)
                .Select(file => new { Name = Path.GetFileName(file), Size = new FileInfo(file).Length })
                .OrderByDescending(file => file.Size)
                .Take(5);
            Console.WriteLine("Top 5 largest files:");
            foreach (var file in largestFiles)
            {
                Console.WriteLine($"Name: {file.Name}, Size: {file.Size} bytes");
            }




            // 4. Return the file with maximum length.
            var maxLengthFile = Directory.GetFiles(directoryPath)
                .Select(file => new { Name = Path.GetFileName(file), Size = new FileInfo(file).Length })
                .OrderByDescending(file => file.Size)
                .First();
            Console.WriteLine($"File with maximum length: {maxLengthFile.Name}, Size: {maxLengthFile.Size} bytes");

            Console.ReadLine();
        }
    }
}
