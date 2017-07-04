using System;
using System.Linq;

namespace _01.LargestElementInArray
{
    public class LargestElementInArray
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] number = new int[n];

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                number[i] = currentNumber;
            }

            int largestNum = number.Max();
            Console.WriteLine(largestNum);
        }
    }
}