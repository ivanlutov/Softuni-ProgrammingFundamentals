using System;

namespace _14.ASCIIString
{
    public class ASCIIString
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string words = "";

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                char cChar = Convert.ToChar(num);
                words += cChar;
            }
            Console.WriteLine(words);
        }
    }
}