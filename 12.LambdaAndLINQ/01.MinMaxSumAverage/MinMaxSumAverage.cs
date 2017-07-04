using System;
using System.Linq;

namespace _01.MinMaxSumAverage
{
    public class MinMaxSumAverage
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                var numberLine = int.Parse(Console.ReadLine());
                numbers[i] = numberLine;
            }

            Console.WriteLine($"Sum = {numbers.Sum()}");
            Console.WriteLine($"Min = {numbers.Min()}");
            Console.WriteLine($"Max = {numbers.Max()}");
            Console.WriteLine($"Average = {numbers.Average()}");
        }
    }
}