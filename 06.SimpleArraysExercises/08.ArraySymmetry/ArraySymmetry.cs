using System;
using System.Linq;

namespace _8.ArraySymmetry
{
    public class ArraySymmetry
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();

            string[] secondWords = words.Reverse().ToArray();

            int count = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Equals(secondWords[i]))
                {
                    count++;
                }
            }

            if (words.Length == count)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}