using System;
using System.Collections.Generic;

namespace _01.SerializeString
{
    public class SerializeString
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            var resultCharacter = new HashSet<string>();
            int index = -1;
            string resultString = string.Empty;

            foreach (char character in input)
            {
                resultString += character + ":";
                while (true)
                {
                    index = input.IndexOf(character, index + 1);

                    if (index < 0)
                    {
                        break;
                    }
                    resultString += index + "/";
                }
                resultString = resultString.TrimEnd('/');
                resultCharacter.Add(resultString);
                resultString = string.Empty;
            }

            Console.WriteLine(string.Join(Environment.NewLine, resultCharacter));
        }
    }
}