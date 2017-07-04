using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01.Cards
{
    public class Cards
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var cards = new List<string>();

            string pattern = "([1]?[0-9JQKA])([SHDC])";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            foreach (Match card in matches)
            {
                int power = 0;

                if (int.TryParse(card.Groups[1].Value, out power))
                {
                    if (power < 2 && power > 10)
                    {
                        continue;
                    }
                }

                cards.Add(card.ToString());
            }

            Console.WriteLine(string.Join(", ", cards));
        }
    }
}