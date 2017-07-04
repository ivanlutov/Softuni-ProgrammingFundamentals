using System;
using System.IO;

namespace _02.LineNumbers
{
    public class LineNumbers
    {
        public static void Main()
        {
            string[] inputFile = File.ReadAllLines("input.txt");

            for (int i = 0; i < inputFile.Length; i++)
            {
                File.AppendAllText("output.txt", $"{i + 1}. " + inputFile[i] + Environment.NewLine);
            }
        }
    }
}