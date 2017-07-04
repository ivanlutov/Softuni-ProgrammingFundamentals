using System;

namespace _01.SpecialNumbers
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int curentNum = i;
                int sum = 0;

                foreach (var symbol in curentNum.ToString())
                {
                    int symbols = symbol - '0';
                    sum += symbols;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}