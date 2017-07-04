using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ExamShopping
{
    public class ExamShopping
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToList();

            var resultDictionary = new Dictionary<string, int>();

            while (!input[0].Equals("shopping"))
            {
                var command = input[0];
                var product = input[1];
                var quantity = int.Parse(input[2]);
                if (command.Equals("stock"))
                {
                    if (!resultDictionary.ContainsKey(product))
                    {
                        resultDictionary[product] = 0;
                    }
                    resultDictionary[product] += quantity;
                }

                input = Console.ReadLine().Split().ToList();
            }

            while (!input[0].Equals("exam"))
            {
                input = Console.ReadLine().Split().ToList();

                var command = input[0];
                var product = input[1];

                if (command.Equals("exam"))
                {
                    break;
                }

                if (resultDictionary.ContainsKey(product))
                {
                    var quantity = int.Parse(input[2]);

                    if (resultDictionary[product] == 0)
                    {
                        Console.WriteLine($"{product} out of stock");
                    }
                    else if (quantity > resultDictionary[product])
                    {
                        resultDictionary[product] = 0;
                    }
                    else
                    {
                        resultDictionary[product] -= quantity;
                    }
                }
                else if (!resultDictionary.ContainsKey(product))
                {
                    Console.WriteLine($"{product} doesn't exist");
                }
            }
            foreach (var kvp in resultDictionary)
            {
                if (kvp.Value > 0)
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                }
            }
        }
    }
}