using System;

namespace _02.CountSubstringOccurrences
{
    public class CountSubstringOccurrences
    {
        public static void Main()
        {
            string text = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();
            int index = -1;
            int count = 0;

            while (true)
            {
                index = text.IndexOf(pattern, index + 1);

                if (index < 0)
                {
                    break;
                }

                count++;
            }

            Console.WriteLine(count);
        }
    }
}