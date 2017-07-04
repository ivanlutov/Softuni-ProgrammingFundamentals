using System;

namespace _06.MathPower
{
    public class MathPower
    {
        public static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double result = RaiseToPower(number, power);
            Console.WriteLine(result);
        }

        private static double RaiseToPower(double number, int power)
        {
            double result = Math.Pow(number, power);
            return result;
        }
    }
}