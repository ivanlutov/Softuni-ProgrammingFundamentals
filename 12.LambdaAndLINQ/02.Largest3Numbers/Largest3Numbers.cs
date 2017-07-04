using System;
using System.Linq;

namespace _02.Largest3Numbers
{
    public class Largest3Numbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).OrderByDescending(n => n).Take(3);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}