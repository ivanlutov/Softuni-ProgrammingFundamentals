using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumbers
{
    public class CountRealNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            var result = new SortedDictionary<double, int>();

            foreach (var num in numbers)
            {
                if (!result.ContainsKey(num))
                {
                    result[num] = 0;
                }
                result[num]++;
            }

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}