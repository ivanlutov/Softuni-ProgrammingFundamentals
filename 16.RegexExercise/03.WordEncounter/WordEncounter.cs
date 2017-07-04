using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03.WordEncounter
{
    public class WordEncounter
    {
        public static void Main()
        {
            string filter = Console.ReadLine();
            string input = Console.ReadLine();
            var wordsList = new List<string>();

            char character = filter[0];
            int num = int.Parse(filter[1].ToString());

            string pattern = @"^[A-Z].*(\.|\!|\?)$";
            Regex regexIsValid = new Regex(pattern);

            while (input != "end")
            {
                if (regexIsValid.IsMatch(input))
                {
                    var regex = new Regex(@"\w+");
                    var words = regex.Matches(input);

                    foreach (Match wordForCompare in words)
                    {
                        int count = 0;
                        for (int i = 0; i < wordForCompare.Value.Length; i++)
                        {
                            if (wordForCompare.Value[i] == character)
                            {
                                count++;
                            }
                        }

                        if (count >= num)
                        {
                            wordsList.Add(wordForCompare.Value);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            if (wordsList.Count > 0)
            {
                Console.WriteLine(string.Join(", ", wordsList));
            }
        }
    }
}