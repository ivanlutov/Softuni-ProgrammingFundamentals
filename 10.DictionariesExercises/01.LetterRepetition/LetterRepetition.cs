using System;
using System.Collections.Generic;

namespace _01.LetterRepetition
{
    public class LetterRepetition
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            var charDictionary = new Dictionary<char, int>();

            foreach (char character in input)
            {
                if (!charDictionary.ContainsKey(character))
                {
                    charDictionary[character] = 0;
                }
                charDictionary[character]++;
            }

            foreach (var character in charDictionary)
            {
                Console.WriteLine($"{character.Key} -> {character.Value}");
            }
        }
    }
}