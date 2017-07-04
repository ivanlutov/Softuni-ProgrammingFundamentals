using System;
using System.Linq;

namespace _07.CountOfCapitalLettersInArray
{
    public class CountOfCapitalLettersInArray
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();

            int count = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == 1)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}