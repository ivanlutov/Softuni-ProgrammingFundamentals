using System;
using System.IO;

namespace _01.FilterExtensions
{
    public class FilterExtensions
    {
        public static void Main()
        {
            string extension = Console.ReadLine();

            var getFiles = Directory.GetFiles("input");

            foreach (var file in getFiles)
            {
                FileInfo fileInfo = new FileInfo(file);
                var ext = fileInfo.Name.Split('.');
                string currentFile = fileInfo.Name;

                if (extension == ext[ext.Length - 1])
                {
                    File.AppendAllText("output.txt", currentFile + Environment.NewLine);
                }
            }
        }
    }
}