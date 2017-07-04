using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.SortNumbers
{
    public class SortNumbers
    {
        public static void Main()
        {
            List<decimal> numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            numbers.Sort();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}