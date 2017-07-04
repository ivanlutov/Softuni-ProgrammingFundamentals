using System;

namespace _09.TriangleFormations
{
    public class TriangleFormations
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (IsValid(a, b, c))
            {
                Console.WriteLine("Triangle is valid.");
                if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                {
                    Console.WriteLine("Triangle has a right angle between sides a and b");
                }
                else if (Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2))
                {
                    Console.WriteLine("Triangle has a right angle between sides a and c");
                }
                else if (Math.Pow(c, 2) + Math.Pow(b, 2) == Math.Pow(a, 2))
                {
                    Console.WriteLine("Triangle has a right angle between sides b and c");
                }
                else if ((a == b) && (a == c) && (b == c))
                {
                    Console.WriteLine("Triangle has no right angles");
                }
            }
            else
            {
                Console.WriteLine("Invalid Triangle.");
            }
        }

        private static bool IsValid(int a, int b, int c)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                return true;
            }
            return false;
        }
    }
}