using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SentenceSplit
{
    public class SentenceSplit
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string delimiter = Console.ReadLine();

            string replaceString = input.Replace(delimiter, "*");

            var words = new List<string>();

            var splitInput = replaceString.Split('*').ToArray();

            foreach (var word in splitInput)
            {
                words.Add(word);
            }

            Console.WriteLine($"[{string.Join(", ", words)}]");
        }
    }
}