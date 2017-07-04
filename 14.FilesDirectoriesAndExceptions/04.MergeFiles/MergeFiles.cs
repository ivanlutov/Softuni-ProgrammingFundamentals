using System;
using System.IO;

namespace _04.MergeFiles
{
    public class MergeFiles
    {
        public static void Main()
        {
            var firstFile = File.ReadAllLines("FileOne.txt");
            var secondFile = File.ReadAllLines("FileTwo.txt");

            for (int i = 0; i < firstFile.Length; i++)
            {
                File.AppendAllText("output.txt", firstFile[i] + Environment.NewLine);
                File.AppendAllText("output.txt", secondFile[i] + Environment.NewLine);
            }
        }
    }
}