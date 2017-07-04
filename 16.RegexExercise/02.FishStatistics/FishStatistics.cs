using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.FishStatistics
{
    public class FishStatistics
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string pattern = @"(>*)(?:<+)(\(+)('|-|x)>";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            if (matches.Count == 0)
            {
                Console.WriteLine("No fish found.");
                return;
            }

            int count = 1;
            foreach (Match fish in matches)
            {
                var tailLength = fish.Groups[1].ToString();
                var bodyLength = fish.Groups[2].ToString();
                var status = fish.Groups[3].ToString();

                Console.WriteLine($"Fish {count}: {fish}");
                if (tailLength.Length > 5)
                {
                    Console.WriteLine($" Tail type: Long ({tailLength.Length * 2} cm)");
                }
                else if (tailLength.Length > 1 && tailLength.Length <= 5)
                {
                    Console.WriteLine($" Tail type: Medium ({tailLength.Length * 2} cm)");
                }
                else if (tailLength.Length == 1)
                {
                    Console.WriteLine($" Tail type: Short ({tailLength.Length * 2} cm)");
                }
                else if (tailLength.Length == 0)
                {
                    Console.WriteLine($" Tail type: None");
                }

                if (bodyLength.Length > 10)
                {
                    Console.WriteLine($" Body type: Long ({bodyLength.Length * 2} cm)");
                }
                else if (bodyLength.Length > 5 && bodyLength.Length <= 10)
                {
                    Console.WriteLine($" Body type: Medium ({bodyLength.Length * 2} cm)");
                }
                else if (bodyLength.Length <= 5)
                {
                    Console.WriteLine($" Body type: Short ({bodyLength.Length * 2} cm)");
                }

                if (status == "'")
                {
                    Console.WriteLine(" Status: Awake");
                }
                else if (status == "-")
                {
                    Console.WriteLine(" Status: Asleep");
                }
                else if (status == "x")
                {
                    Console.WriteLine(" Status: Dead");
                }

                count++;
            }
        }
    }
}