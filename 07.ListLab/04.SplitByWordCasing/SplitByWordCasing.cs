using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SplitByWordCasing
{
    public class SplitByWordCasing
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split(new[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']' },
                StringSplitOptions.RemoveEmptyEntries).ToArray();

            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();

            foreach (var word in words)
            {
                bool isAllLowerCase = true;
                bool isAllUpperrCase = true;

                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsLower(word[i]))
                    {
                        isAllUpperrCase = false;
                    }
                    else if (char.IsUpper(word[i]))
                    {
                        isAllLowerCase = false;
                    }
                    else
                    {
                        isAllLowerCase = false;
                        isAllUpperrCase = false;
                    }
                }
                if (isAllLowerCase)
                {
                    lowerCase.Add(word);
                }
                else if (isAllUpperrCase)
                {
                    upperCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }
            }
            Console.Write("Lower-case: ");
            Console.WriteLine(string.Join(", ", lowerCase));

            Console.Write("Mixed-case: ");
            Console.WriteLine(string.Join(", ", mixedCase));

            Console.Write("Upper-case: ");
            Console.WriteLine(string.Join(", ", upperCase));
        }
    }
}