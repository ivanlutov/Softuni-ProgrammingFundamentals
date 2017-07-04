using System;
using System.Linq;

namespace _05.IncreasingSequenceOfElements
{
    public class IncreasingSequenceOfElements
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int count = 0;
            int lastNum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > lastNum)
                {
                    count++;
                }

                lastNum = numbers[i];
            }

            if (numbers.Length == count)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}