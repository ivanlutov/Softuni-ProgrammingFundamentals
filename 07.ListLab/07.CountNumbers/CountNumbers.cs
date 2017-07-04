using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.CountNumbers
{
    public class CountNumbers
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var count = new int[numbers.Max() + 1];

            foreach (var number in numbers)
            {
                count[number]++;
            }

            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] > 0)
                {
                    Console.WriteLine($"{i} -> {count[i]}");
                }
            }
        }
    }
}