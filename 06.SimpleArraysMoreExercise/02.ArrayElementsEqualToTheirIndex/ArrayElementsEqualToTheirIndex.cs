using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ArrayElementsEqualToTheirIndex
{
    public class ArrayElementsEqualToTheirIndex
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == i)
                {
                    result.Add(numbers[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}