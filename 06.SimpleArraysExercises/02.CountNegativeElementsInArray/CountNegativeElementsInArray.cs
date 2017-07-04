using System;

namespace _02.CountNegativeElementsInArray
{
    public class CountNegativeElementsInArray
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] number = new int[n];

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                number[i] = currentNumber;

                if (number[i] < 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}