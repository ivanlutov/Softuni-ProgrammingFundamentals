using System;
using System.Linq;

namespace _02.AverageCharacterDelimiter
{
    public class AverageCharacterDelimiter
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToArray();

            int allSum = 0;
            int count = 0;

            string word = string.Empty;

            foreach (var character in input)
            {
                word += character;
            }

            foreach (char characters in word)
            {
                allSum += characters;
                count++;
            }

            var delimiter = (char)(allSum / count);
            var upperChar = Char.ToUpper(delimiter).ToString();

            Console.WriteLine(string.Join(upperChar, input));
        }
    }
}