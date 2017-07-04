using System;
using System.Collections.Generic;

namespace _03.MixedPhones
{
    public class MixedPhones
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine()
                .Split(' ');

            var resultDictionary = new SortedDictionary<string, long>();

            while (inputLine[0].ToLower() != "over")
            {
                long intResult = 0;
                if (long.TryParse(inputLine[0], out intResult))
                {
                    resultDictionary[inputLine[2]] = intResult;
                }
                else if (long.TryParse(inputLine[2], out intResult))
                {
                    resultDictionary[inputLine[0]] = intResult;
                }

                inputLine = Console.ReadLine()
                    .Split(' ');
            }

            foreach (var kvp in resultDictionary)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}