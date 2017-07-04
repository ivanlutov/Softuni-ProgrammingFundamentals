﻿using System;
using System.Linq;

namespace _01.Last3ConsecutiveEqualStrings
{
    public class ConsectutiveEqualStrings
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split().ToArray();

            int count = 1;

            for (int i = words.Length - 1; i > 0; i--)
            {
                if (words[i] == words[i - 1])
                {
                    count++;

                    if (count == 3)
                    {
                        Console.WriteLine($"{words[i]} {words[i]} {words[i]}");
                        break;
                    }
                }
                else
                {
                    count = 1;
                }
            }
        }
    }
}