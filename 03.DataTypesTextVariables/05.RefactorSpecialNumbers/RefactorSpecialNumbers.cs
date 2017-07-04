using System;

namespace _05.RefactorSpecialNumbers
{
    public class RefactorSpecialNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sumOfDigits = 0;
            int digits = 0;
            bool special = false;

            for (int num = 1; num <= n; num++)
            {
                digits = num;
                while (num > 0)
                {
                    sumOfDigits += num % 10;
                    num = num / 10;
                }
                special = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine($"{digits} -> {special}");
                sumOfDigits = 0;
                num = digits;
            }
        }
    }
}