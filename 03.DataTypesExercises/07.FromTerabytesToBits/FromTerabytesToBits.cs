using System;

namespace _07.FromTerabytesToBits
{
    public class FromTerabytesToBits
    {
        public static void Main()
        {
            decimal input = decimal.Parse(Console.ReadLine());

            decimal oneTeraByte = (decimal)1024 * 1024 * 1024 * 1024 * 8;

            Console.WriteLine(Math.Round(input * oneTeraByte));
        }
    }
}