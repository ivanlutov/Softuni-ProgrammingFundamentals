using System;

namespace _02.SignOfIntegerNumber
{
    public class SignOfIntegerNumber
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            PrintSign(number);
        }

        public static void PrintSign(int number)
        {
            if (number == 0)
            {
                Console.WriteLine($"The number {number} is zero.");
            }
            else if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
        }
    }
}