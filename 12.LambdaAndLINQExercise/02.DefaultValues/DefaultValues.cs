using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.DefaultValues
{
    public class DefaultValues
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var keyValue = new Dictionary<string, string>();

            while (!input.Equals("end"))
            {
                var dataLine = input.Split("-> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var key = dataLine[0];
                var value = dataLine[1];

                if (!keyValue.ContainsKey(key))
                {
                    keyValue[key] = string.Empty;
                }
                keyValue[key] = value;

                input = Console.ReadLine();
            }

            string replaceWord = Console.ReadLine();

            var dictWithDefault = keyValue
               .Where(v => v.Value != "null")
               .OrderByDescending(v => v.Value.Length)
               .ToDictionary(t => t.Key, t => t.Value);

            var replace = keyValue
                .Where(v => v.Value == "null")
                .ToDictionary(t => t.Key, t => replaceWord);

            foreach (var name in dictWithDefault)
            {
                Console.WriteLine($"{name.Key} <-> {name.Value}");
            }

            foreach (var name in replace)
            {
                Console.WriteLine($"{name.Key} <-> {name.Value}");
            }
        }
    }
}