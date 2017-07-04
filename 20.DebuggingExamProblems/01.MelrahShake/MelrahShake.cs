using System;
using System.Text.RegularExpressions;

namespace _01.MelrahShake
{
    public class MelrahShake
    {
        public static void Main()
        {
            string border = Console.ReadLine();
            string pattern = Console.ReadLine();

            var matches = Regex.Matches(border, Regex.Escape(pattern));

            while (true)
            {
                if (matches.Count >= 2 && pattern.Length > 0)
                {
                    var firstPattern = border.IndexOf(pattern);
                    var lastPattern = border.LastIndexOf(pattern);

                    border = border.Remove(lastPattern, pattern.Length);
                    border = border.Remove(firstPattern, pattern.Length);

                    pattern = pattern.Remove(pattern.Length / 2, 1);
                    Console.WriteLine("Shaked it.");
                }
                else
                {
                    Console.WriteLine("No shake.");
                    break;
                }

                matches = Regex.Matches(border, Regex.Escape(pattern));
            }

            Console.WriteLine(border);
        }
    }
}