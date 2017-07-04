using System;
using System.Linq;

namespace _04.CountOccurrencesLargerNumbers
{
    public class CountOccurrencesLargerNumbers
    {
        public static void Main()
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            double p = double.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > p)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}