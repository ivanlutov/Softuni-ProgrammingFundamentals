using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.CapitalizeWords
{
    public class CapitalizeWords
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var words = new List<string>();

            while (input != "end")
            {
                var inputLine = input
                    .Split(new char[] { ',', ' ', '=', '-', '>', ':', '~', '}', '|', '{', '`', '^', ']', '\\', '[', '?', '<', ';', '/', '.', '+', '*', ')', '(', '&', '%', '$', '#', '\"', '!' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var word in inputLine)
                {
                    var resultWord = FirstCharToUpper(word.ToLower());
                    words.Add(resultWord);
                }

                Console.WriteLine(string.Join(", ", words));

                words.Clear();

                input = Console.ReadLine();
            }
        }

        public static string FirstCharToUpper(string input)
        {
            return input.First().ToString().ToUpper() + String.Join("", input.Skip(1));
        }
    }
}