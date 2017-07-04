using System;
using System.Collections.Generic;

namespace _01.Placeholders
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var wordsForReplace = new List<string>();

            while (input != "end")
            {
                var inputLine = input.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var sequencesForReplace = inputLine[0];
                var words = inputLine[1].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < words.Length; i++)
                {
                    wordsForReplace.Add(words[i]);
                }
                for (int i = 0; i < words.Length; i++)
                {
                    sequencesForReplace = sequencesForReplace.Replace($"{{{i}}}", wordsForReplace[i]);
                }
                Console.WriteLine(sequencesForReplace);
                wordsForReplace.Clear();

                input = Console.ReadLine();
            }
        }
    }
}