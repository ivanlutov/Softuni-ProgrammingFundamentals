using System;
using System.Collections.Generic;

namespace _01.LambadaExpressions
{
    public class LambadaExpressions
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var lambdaDict = new Dictionary<string, Dictionary<string, List<string>>>();

            while (!input.Equals("lambada"))
            {
                if (!input.Equals("dance"))
                {
                    var tokens = input.Split("=>. ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    var selector = tokens[0];
                    var selectorObject = tokens[1];
                    var property = tokens[2];

                    if (!lambdaDict.ContainsKey(selector))
                    {
                        lambdaDict[selector] = new Dictionary<string, List<string>>();
                    }
                    if (!lambdaDict[selector].ContainsKey(selectorObject))
                    {
                        lambdaDict[selector][selectorObject] = new List<string>();
                    }
                    lambdaDict[selector][selectorObject].Clear();
                    lambdaDict[selector][selectorObject].Add(property);
                }
                else
                {
                    foreach (var entry in lambdaDict.Keys)
                    {
                        foreach (var entryKey in lambdaDict[entry].Keys)
                        {
                            lambdaDict[entry][entryKey].Insert(0, entryKey);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var lambda in lambdaDict)
            {
                Console.Write($"{lambda.Key} => ");
                foreach (var kvp in lambda.Value)
                {
                    Console.Write($"{kvp.Key}.{string.Join(".", kvp.Value)}");
                }
                Console.WriteLine();
            }
        }
    }
}