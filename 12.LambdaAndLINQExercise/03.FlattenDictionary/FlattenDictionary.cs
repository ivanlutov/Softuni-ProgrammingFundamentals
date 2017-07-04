using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.FlattenDictionary
{
    public class FlattenDictionary
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            var products = new Dictionary<string, Dictionary<string, string>>();
            var flattenDictionary = new Dictionary<string, string>();
            var model = string.Empty;

            while (!input.Equals("end"))
            {
                var dataLine = input.Split();
                var categories = dataLine[0];
                var product = dataLine[1];

                if (dataLine.Length > 2)
                {
                    model = dataLine[2];
                }
                if (!products.ContainsKey(categories))
                {
                    products[categories] = new Dictionary<string, string>();
                }
                if (!products[categories].ContainsKey(product))
                {
                    products[categories][product] = string.Empty;
                }
                products[categories][product] = model;

                if (categories.Equals("flatten"))
                {
                    products
                        .Where(x => x.Key == product)
                }

                input = Console.ReadLine();
            }

            foreach (var entry in flattenDictionary)
            {
                Console.WriteLine($"{entry.Key} - {entry.Value}");
            }
        }
    }
}