using System;
using System.Collections.Generic;

namespace _04.Palindromes
{
    public class Palindromes
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            var words = text.Split(new char[] { ' ', '.', ',', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

            var resultWords = new SortedSet<string>();

            foreach (var word in words)
            {
                if (isPalindrome(word))
                {
                    resultWords.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", resultWords));
        }

        public static bool isPalindrome(string word)
        {
            string firstPart = word.Substring(0, word.Length / 2);
            char[] arr = word.ToCharArray();
            Array.Reverse(arr);
            string temp = new string(arr);
            string secondPart = temp.Substring(0, temp.Length / 2);
            return firstPart.Equals(secondPart);
        }
    }
}