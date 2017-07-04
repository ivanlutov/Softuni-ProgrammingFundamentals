using System;

namespace _02.MinMethod
{
    public class MinMethod
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int firstParam = Math.Min(a, b);
            int secondParam = Math.Min(firstParam, c);

            int smallestNum = GetMin(firstParam, secondParam);
            Console.WriteLine(smallestNum);
        }

        private static int GetMin(int firstParam, int secondParam)
        {
            int smallestNum = Math.Min(firstParam, secondParam);
            return smallestNum;
        }
    }
}