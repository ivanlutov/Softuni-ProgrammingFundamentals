using System;

namespace _01.ReverseString
{
    public class ReverseString
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            var reverseText = string.Empty;

            for (int i = text.Length; i > 0; i--)
            {
                reverseText += text[i - 1];
            }
            Console.WriteLine(reverseText);
        }
    }
}