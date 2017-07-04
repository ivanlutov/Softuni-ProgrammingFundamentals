using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ForumTopics
{
    public class ForumTopics
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { '-', '>', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var resultDicionary = new Dictionary<string, HashSet<string>>();

            while (!input[0].Equals("filter"))
            {
                var name = input[0];
                for (int i = 1; i < input.Count; i++)
                {
                    if (!resultDicionary.ContainsKey(name))
                    {
                        resultDicionary[name] = new HashSet<string>();
                    }
                    resultDicionary[name].Add(input[i]);
                }

                input = Console.ReadLine().Split(new char[] { '-', '>', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            var hashTagWords = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var nameAndHash in resultDicionary)
            {
                bool isContainsAllTags = !hashTagWords.Except(nameAndHash.Value).Any();

                if (isContainsAllTags)
                {
                    Console.Write($"{nameAndHash.Key} | ");
                    foreach (var tags in nameAndHash.Value)
                    {
                        if (tags.Equals(nameAndHash.Value.Last()))
                        {
                            Console.Write($"#{tags}");
                            break;
                        }
                        Console.Write($"#{tags}, ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}