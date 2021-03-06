﻿using System;

namespace _03.PrintingTriangle
{
    public class PrintingTriangle
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            PrintTriangle(n);
        }

        public static void PrintTriangle(int n)
        {
            for (int line = 1; line <= n; line++)
            {
                PrintLine(1, line);
            }
            for (int line = n - 1; line >= 1; line--)
            {
                PrintLine(1, line);
            }
        }

        private static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}