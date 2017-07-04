using System;

namespace _04.NthDigit
{
    public class NthDigit
    {
        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());

            int result = FindNthDigit(number, index);
            Console.WriteLine(result);
        }

        private static int FindNthDigit(long number, int index)
        {
            long result = 0;
            for (long i = 0; i < index; i++)
            {
                result = number % 10;
                number = number / 10;
            }
            return (int)result;
        }
    }
}