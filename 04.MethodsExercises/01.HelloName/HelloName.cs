﻿using System;

namespace _01.HelloName
{
    public class HelloName
    {
        public static void Main()
        {
            string name = Console.ReadLine();

            PrintName(name);
        }

        private static void PrintName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}