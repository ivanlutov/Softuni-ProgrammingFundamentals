using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.DictRefAdvanced
{
    public class DictRefAdvanced
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { '-', '>', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var resultDictionay = new Dictionary<string, List<int>>();

            while (!input[0].Equals("end"))
            {
                string name = input[0];

                int number;
                if (int.TryParse(input[1], out number))
                {
                    if (!resultDictionay.ContainsKey(name))
                    {
                        resultDictionay[name] = new List<int>();
                    }
                    for (int i = 1; i < input.Count; i++)
                    {
                        resultDictionay[name].Add(int.Parse(input[i]));
                    }
                }
                else
                {
                    if (resultDictionay.ContainsKey(input[1]))
                    {
                        resultDictionay[input[0]] = new List<int>(resultDictionay[input[1]]);
                    }
                }

                input = Console.ReadLine().Split(new char[] { '-', '>', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            foreach (var nameAndNumbers in resultDictionay)
            {
                var name = nameAndNumbers.Key;
                var numbers = string.Join(", ", nameAndNumbers.Value);
                Console.WriteLine($"{name} === {numbers}");
            }
        }
    }
}