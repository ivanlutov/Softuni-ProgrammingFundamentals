using System.IO;

namespace _05.FolderSize
{
    public class FolderSize
    {
        public static void Main()
        {
            var getFiles = Directory.GetFiles("TestFolder");

            double sum = 0;

            foreach (var file in getFiles)
            {
                FileInfo fileInfo = new FileInfo(file);
                sum += fileInfo.Length;
            }

            File.WriteAllText("output.txt", (sum / 1024 / 1024).ToString());
        }
    }
}