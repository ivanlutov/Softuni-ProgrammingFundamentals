using System;
using System.Linq;

namespace _03.CountGivenElementInArray
{
    public class CountGivenElementInArray
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int element = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i].Equals(element))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}