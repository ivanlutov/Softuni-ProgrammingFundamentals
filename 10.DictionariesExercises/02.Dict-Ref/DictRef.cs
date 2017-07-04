using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Dict_Ref
{
    public class DictRef
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split('=').ToList();

            var resultDictionary = new Dictionary<string, int>();

            while (!input[0].Equals("end"))
            {
                var name = input[0].Trim();
                int number;
                Int32.TryParse(input[1].Trim(), out number);
                var value = input[1].Trim();

                if (!resultDictionary.ContainsKey(name))
                {
                    if (resultDictionary.ContainsKey(value))
                    {
                        resultDictionary[name] = resultDictionary[value];
                    }
                    else
                    {
                        int n;
                        bool isNumeric = int.TryParse(value, out n);
                        if (isNumeric)
                        {
                            resultDictionary[name] = number;
                        }
                    }
                }
                else
                {
                    resultDictionary[name] = number;
                    if (resultDictionary.ContainsKey(value))
                    {
                        resultDictionary[name] = resultDictionary[value];
                    }
                    int n;
                    bool isNumeric = int.TryParse(value, out n);
                    if (isNumeric)
                    {
                        resultDictionary[name] = number;
                    }
                }

                input = Console.ReadLine().Split('=').ToList();
            }

            foreach (var kvp in resultDictionary)
            {
                Console.WriteLine($"{kvp.Key} === {kvp.Value}");
            }
        }
    }
}