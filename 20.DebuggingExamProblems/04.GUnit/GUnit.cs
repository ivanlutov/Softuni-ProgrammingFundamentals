using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.GUnit
{
    public class GUnit
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            Regex regex = new Regex(@"^([A-Z]+[a-zA-Z0-9]+) \| ([A-Z]+[a-zA-Z0-9]+) \| ([A-Z]+[a-zA-Z0-9]+)$");
            var result = new Dictionary<string, Dictionary<string, List<string>>>();

            while (inputLine != "It's testing time!")
            {
                if (regex.IsMatch(inputLine))
                {
                    Match match = regex.Match(inputLine);

                    var className = match.Groups[1].Value;
                    var methodName = match.Groups[2].Value;
                    var unitTestName = match.Groups[3].Value;

                    if (!result.ContainsKey(className))
                    {
                        result[className] = new Dictionary<string, List<string>>();
                    }
                    if (!result[className].ContainsKey(methodName))
                    {
                        result[className][methodName] = new List<string>();
                    }
                    if (!result[className][methodName].Contains(unitTestName))
                    {
                        result[className][methodName].Add(unitTestName);
                    }
                }

                inputLine = Console.ReadLine();
            }

            foreach (var classes in result.OrderByDescending(x => x.Value.Values.Sum(y => y.Count)).ThenBy(x => x.Value.Count()).ThenBy(x => x.Key, StringComparer.Ordinal))
            {
                Console.WriteLine($"{classes.Key}:");
                foreach (var method in classes.Value.OrderByDescending(x => x.Value.Count()).ThenBy(x => x.Key, StringComparer.Ordinal))
                {
                    Console.WriteLine($"##{method.Key}");
                    foreach (var unit in method.Value.OrderBy(x => x.Length).ThenBy(x => x, StringComparer.Ordinal))
                    {
                        Console.WriteLine($"####{unit}");
                    }
                }
            }
        }
    }
}