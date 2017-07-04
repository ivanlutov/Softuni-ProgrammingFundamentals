using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LINQuistics
{
    public class LINQuistics
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();
            var collectionDict = new Dictionary<string, HashSet<string>>();

            while (!inputLine.Equals("exit"))
            {
                if (inputLine.Contains("."))
                {
                    var dataLine = inputLine.Split(new char[] { '.', ')', '(' }, StringSplitOptions.RemoveEmptyEntries);
                    var collection = dataLine[0];
                    if (!collectionDict.ContainsKey(collection))
                    {
                        collectionDict[collection] = new HashSet<string>();
                    }
                    for (int i = 1; i < dataLine.Length; i++)
                    {
                        collectionDict[collection].Add(dataLine[i]);
                    }
                }
                else
                {
                    int number = 0;
                    if (Int32.TryParse(inputLine, out number))
                    {
                        var result = collectionDict.Values
                            .OrderByDescending(x => x.Count()).First()
                            .OrderBy(x => x.Length).Take(number).ToList();
                        foreach (var methodName in result)
                        {
                            if (result.Count > 0)
                            {
                                Console.WriteLine($"* {methodName}");
                            }
                        }
                    }
                    else if (collectionDict.ContainsKey(inputLine))
                    {
                        var result = collectionDict[inputLine]
                            .OrderByDescending(x => x.Length)
                            .ThenByDescending(x => x.Distinct().Count())
                            .ToList();
                        foreach (var methodName in result)
                        {
                            if (result.Count > 0)
                            {
                                Console.WriteLine($"* {methodName}");
                            }
                        }
                    }
                    else if (!collectionDict.ContainsKey(inputLine))
                    {
                        inputLine = Console.ReadLine();
                        continue;
                    }
                }

                inputLine = Console.ReadLine();
            }

            string[] commandLine = Console.ReadLine().Split();
            var method = commandLine[0];
            var selection = commandLine[1];

            if (selection == "all")
            {
                foreach (var collection in collectionDict.Where(x => x.Value.Contains(method))
                    .OrderByDescending(x => x.Value.Count())
                    .ThenByDescending(x => x.Value.Min(y => y.Length)))
                {
                    Console.WriteLine(collection.Key);
                    foreach (var methodName in collection.Value.OrderByDescending(x => x.Count()))
                    {
                        Console.WriteLine($"* {methodName}");
                    }
                }
            }
            else
            {
                foreach (var collection in collectionDict.Where(x => x.Value.Contains(method))
                    .OrderBy(x => x.Value.Count())
                    .ThenByDescending(x => x.Value.Min(y => y.Length)))
                {
                    Console.WriteLine(collection.Key);
                }
            }
        }
    }
}