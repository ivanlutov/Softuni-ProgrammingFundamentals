﻿using System;

namespace _02.TriplesOfLatinLetters
{
    public class TriplesOfLatinLetters
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        Console.WriteLine($"{(char)(i + 'a')}{(char)(j + 'a')}{(char)(k + 'a')}");
                    }
                }
            }
        }
    }
}