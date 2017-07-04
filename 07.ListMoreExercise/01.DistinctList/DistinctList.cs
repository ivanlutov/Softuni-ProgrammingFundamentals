using System;
using System.Linq;

namespace _01.DistinctList
{
    public class DistinctList
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            var result = input.Distinct().ToList();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}