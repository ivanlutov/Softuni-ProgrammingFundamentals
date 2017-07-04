using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddOccurrences
{
    public class OddOccurrences
    {
        public static void Main()
        {
            var words = Console.ReadLine().ToLower().Split().ToList();

            var dictionary = new Dictionary<string, int>();
            var result = new List<string>();

            foreach (var word in words)
            {
                if (!dictionary.ContainsKey(word))
                {
                    dictionary[word] = 0;
                }
                dictionary[word]++;
            }

            foreach (var kvp in dictionary)
            {
                if (kvp.Value % 2 != 0)
                {
                    result.Add(kvp.Key);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}