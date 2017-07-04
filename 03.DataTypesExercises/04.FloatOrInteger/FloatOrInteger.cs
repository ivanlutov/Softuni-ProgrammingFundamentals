using System;

namespace _04.FloatOrInteger
{
    public class FloatOrInteger
    {
        public static void Main()
        {
            double num = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Round(num));
        }
    }
}