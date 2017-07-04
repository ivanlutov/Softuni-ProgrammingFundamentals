using System;

namespace _05.CalculateTriangleArea
{
    public class CalculateTriangleArea
    {
        public static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double result = GetTriangleArea(width, height);
            Console.WriteLine(result);
        }

        private static double GetTriangleArea(double width, double height)
        {
            double result = (width * height) / 2;
            return result;
        }
    }
}