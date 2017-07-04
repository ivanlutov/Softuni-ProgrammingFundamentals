using System;
using System.Text.RegularExpressions;

namespace _04.CubicMessages
{
    public class CubicMessages
    {
        public static void Main()
        {
            string pattern = @"^(?<firstPart>\d+)(?<message>[a-zA-Z]+)(?<secondPart>[^a-zA-Z]*)$";
            string command = Console.ReadLine();

            while (command != "Over!")
            {
                int number = int.Parse(Console.ReadLine());

                var match = Regex.Match(command, pattern);
                if (!match.Success)
                {
                    command = Console.ReadLine();
                    continue;
                }

                var firstPart = match.Groups["firstPart"].Value;
                var secondPart = match.Groups["secondPart"].Value;
                var message = match.Groups["message"].Value;

                if (message.Length != number)
                {
                    command = Console.ReadLine();
                    continue;
                }
                var verificationCodeSymbols = firstPart + secondPart;
                string result = string.Empty;

                foreach (var character in verificationCodeSymbols)
                {
                    int digit = 0;
                    if (int.TryParse(character.ToString(), out digit) && digit < message.Length)
                    {
                        result += message[digit];
                    }
                    else
                    {
                        result += " ";
                    }
                }

                Console.WriteLine($"{message} == {result}");
                command = Console.ReadLine();
            }
        }
    }
}