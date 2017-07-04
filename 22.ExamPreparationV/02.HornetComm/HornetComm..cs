using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.HornetComm
{
    public class Program
    {
        public static void Main()
        {
            var broadcast = new List<string>();
            var privateMessage = new List<string>();

            while (true)
            {
                string commandLine = Console.ReadLine();

                if (commandLine == "Hornet is Green")
                {
                    break;
                }

                var tokens = commandLine.Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length != 2)
                {
                    continue;
                }

                var firstQuery = tokens[0];
                var secondQuery = tokens[1];

                if (firstQuery.All(char.IsDigit) && secondQuery.All(char.IsLetterOrDigit))
                {
                    string reversedFirstQuery = new string(firstQuery.Reverse().ToArray());
                    privateMessage.Add($"{reversedFirstQuery} -> {secondQuery}");
                }
                else if (firstQuery.All(s => !char.IsDigit(s) && secondQuery.All(char.IsLetterOrDigit)))
                {
                    StringBuilder resultSecondQuery = new StringBuilder();

                    foreach (var character in secondQuery)
                    {
                        if (char.IsLower(character))
                        {
                            resultSecondQuery.Append(character.ToString().ToUpper());
                        }
                        else if (char.IsUpper(character))
                        {
                            resultSecondQuery.Append(character.ToString().ToLower());
                        }
                        else
                        {
                            resultSecondQuery.Append(character);
                        }
                    }

                    broadcast.Add($"{resultSecondQuery} -> {firstQuery}");
                }
            }

            Console.WriteLine("Broadcasts:");
            if (broadcast.Any())
            {
                Console.WriteLine(string.Join(Environment.NewLine, broadcast));
            }
            else
            {
                Console.WriteLine("None");
            }

            Console.WriteLine("Messages:");
            if (privateMessage.Any())
            {
                Console.WriteLine(string.Join(Environment.NewLine, privateMessage));
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}