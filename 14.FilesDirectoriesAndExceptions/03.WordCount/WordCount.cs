using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03.WordCount
{
    public class WordCount
    {
        public static void Main()
        {
            var words = File.ReadAllText("words.txt").Split(' ').ToArray();

            var text = File.ReadAllText("text.txt").ToLower()
                     .Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries);

            var wordByCount = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (!wordByCount.ContainsKey(words[i]))
                {
                    wordByCount[words[i]] = 0;
                }
                foreach (var word in text)
                {
                    if (word == words[i])
                    {
                        wordByCount[words[i]] += 1;
                    }
                }
            }

            foreach (var word in wordByCount.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{word.Key} - {word.Value}");
            }
        }
    }
}