using System.IO;

namespace _04.Re_Directory
{
    public class ReDirectory
    {
        public static void Main()
        {
            var getFiles = Directory.GetFiles("input");

            foreach (var file in getFiles)
            {
                FileInfo fileInfo = new FileInfo(file);
                var splitted = fileInfo.Name.Split('.');
                var extension = splitted[splitted.Length - 1];
                string currentFile = fileInfo.Name;

                if (!Directory.Exists($"output/{extension}s"))
                {
                    Directory.CreateDirectory($"output/{extension}s");
                }

                File.Move($"input/{currentFile}", $"output/{extension}s/{currentFile}");
            }
        }
    }
}