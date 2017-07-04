using System;

namespace _05.IntegerToBase
{
    public class IntegerToBase
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());

            string result = IntToBase(number, toBase);
            Console.WriteLine(result);
        }

        private static string IntToBase(int number, int toBase)
        {
            string result = string.Empty;
            int remainder = 0;
            while (number > 0)
            {
                remainder = number % toBase;
                result = remainder + result;
                number = number / toBase;
            }

            return result;
        }
    }
}