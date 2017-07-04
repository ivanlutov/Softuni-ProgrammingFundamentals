using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Shellbound
{
    public class Shellbound
    {
        public static void Main()
        {
            string commandLine = Console.ReadLine();

            var resultDictionary = new Dictionary<string, HashSet<long>>();

            while (!commandLine.Equals("Aggregate"))
            {
                string[] data = commandLine.Split(' ');
                string region = data[0];
                long size = long.Parse(data[1]);

                if (!resultDictionary.ContainsKey(region))
                {
                    resultDictionary[region] = new HashSet<long>();
                }
                resultDictionary[region].Add(size);

                commandLine = Console.ReadLine();
            }

            foreach (var regionAndSize in resultDictionary)
            {
                var region = regionAndSize.Key;
                var size = string.Join(", ", regionAndSize.Value);
                var giantSize = regionAndSize.Value.Sum() - (regionAndSize.Value.Sum() / regionAndSize.Value.Count());
                Console.WriteLine($"{region} -> {size} ({giantSize})");
            }
        }
    }
}