using System;
using System.Linq;

namespace _06.EqualSequenceOfElementsInArray
{
    public class EqualSequenceOfElementsInArray
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int count = 0;
            int previousNum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i].Equals(previousNum))
                {
                    count++;
                }

                previousNum = numbers[i];
            }

            if (numbers.Length - 1 == count)
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