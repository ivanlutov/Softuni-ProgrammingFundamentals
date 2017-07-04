using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.CottageScraper
{
    public class CottageScraper
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            var dictionary = new Dictionary<string, List<int>>();
            double usedLogsCount = 0;
            double unusedLogsCount = 0;
            double pricePerMeter = 0;

            while (!input.Equals("chop chop"))
            {
                if (!input.Equals("chop chop"))
                {
                    var dateLine = input.Split("-> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    var type = dateLine[0];
                    var height = int.Parse(dateLine[1]);

                    if (!dictionary.ContainsKey(type))
                    {
                        dictionary[type] = new List<int>();
                    }
                    dictionary[type].Add(height);
                }

                input = Console.ReadLine();
            }

            var typeOfThree = Console.ReadLine();
            var minimumLenght = int.Parse(Console.ReadLine());

            var usedLogs = dictionary
                .Where(x => x.Key == typeOfThree)
                .SelectMany(x => x.Value.Where(y => y >= minimumLenght))
                .ToList();

            var unusedLogsLessLenght = dictionary
                .Where(x => x.Key == typeOfThree)
                .SelectMany(x => x.Value.Where(y => y < minimumLenght))
                .ToList();

            var unusedLogs = dictionary
                .Where(x => x.Key != typeOfThree)
                .SelectMany(x => x.Value)
                .ToList();

            usedLogsCount = usedLogs.Sum();
            unusedLogsCount = unusedLogsLessLenght.Sum() + unusedLogs.Sum();
            var logs = dictionary
                .SelectMany(x => x.Value);
            pricePerMeter = Math.Round(logs.Average(), 2);

            var usedLogsPrice = Math.Round((usedLogsCount * pricePerMeter), 2);
            var unusedLogsPrice = Math.Round((unusedLogsCount * pricePerMeter * 0.25), 2);
            var cottageScraperSubtotal = Math.Round((usedLogsPrice + unusedLogsPrice), 2);

            Console.WriteLine($"Price per meter: ${pricePerMeter:F2}");
            Console.WriteLine($"Used logs price: ${usedLogsPrice:F2}");
            Console.WriteLine($"Unused logs price: ${unusedLogsPrice:F2}");
            Console.WriteLine($"CottageScraper subtotal: ${cottageScraperSubtotal:F2}");
        }
    }
}