﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Greeting
{
    public class Greeting
    {
        public static void Main()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Hello, {firstName} {lastName}.You are {age} years old.");
        }
    }
}