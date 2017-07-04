using System;

namespace _03.ExactProductOfRealNumbers
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            decimal product = 1;

            for (int i = 0; i < n; i++)
            {
                product *= decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine(product);
        }
    }
}