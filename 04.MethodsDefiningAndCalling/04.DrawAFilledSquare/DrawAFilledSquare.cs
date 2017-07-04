using System;

namespace _04.DrawAFilledSquare
{
    public class DrawAFilledSquare
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintTopOrBottom(n);
            for (int i = 0; i < n - 2; i++)
            {
                PrintMiddleRow(n);
            }
            PrintTopOrBottom(n);
        }

        private static void PrintMiddleRow(int n)
        {
            Console.Write("-");
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }

        public static void PrintTopOrBottom(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }
    }
}