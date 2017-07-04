using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.RemoveNegativesAndReverse
{
    public class RemoveNegativesAndReverse
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();

            foreach (var number in numbers)
            {
                if (number > 0)
                {
                    result.Add(number);
                }
            }

            result.Reverse();

            if (result.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}