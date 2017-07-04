using System;

namespace _16.TrickyStrings
{
    public class TrickyStrings
    {
        public static void Main()
        {
            string delimiter = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string words = "";
            string lastWord = "";

            for (int i = 0; i < n - 1; i++)
            {
                string word = Console.ReadLine();

                words += word + delimiter;
            }
            for (int i = n - 1; i < n; i++)
            {
                string word = Console.ReadLine();
                lastWord += word;
            }
            Console.WriteLine(words + lastWord);
        }
    }
}