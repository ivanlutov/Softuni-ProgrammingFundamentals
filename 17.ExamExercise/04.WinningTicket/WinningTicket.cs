using System;
using System.Text.RegularExpressions;

namespace _04.WinningTicket
{
    public class WinningTicket
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"([\@]{6,})|([\$]{6,})|([\^]{6,})|([\#]{6,})";
            string patternAllMatch = @"([\@]{20,})|([\$]{20,})|([\^]{20,})|([\#]{20,})";
            var inputLine = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < inputLine.Length; i++)
            {
                var currentTicket = inputLine[i];

                if (currentTicket.Length == 20)
                {
                    var firstPart = currentTicket.Substring(0, 10);
                    var secondPart = currentTicket.Substring(10);
                    Regex regexFirstPart = new Regex(pattern);
                    Regex regexSecondPart = new Regex(pattern);

                    var firstValue = regexFirstPart.Match(firstPart).Value;
                    var secondValue = regexSecondPart.Match(secondPart).Value;
                    bool firstContainsSecond = firstValue.Contains(secondValue);
                    bool secondConstainsFirst = secondValue.Contains(firstValue);

                    if ((regexFirstPart.IsMatch(firstPart) && regexSecondPart.IsMatch(secondPart))
                        && (firstContainsSecond || secondConstainsFirst))
                    {
                        Regex allEqualSymbols = new Regex(patternAllMatch);
                        if (allEqualSymbols.IsMatch(currentTicket))
                        {
                            Console.WriteLine($"ticket \"{currentTicket}\" - {currentTicket.Length / 2}{currentTicket[0]} Jackpot!");
                        }
                        else
                        {
                            Match firstMatch = regexFirstPart.Match(firstPart);
                            Match secondMatch = regexFirstPart.Match(secondPart);

                            var symbol = firstMatch.Value.ToString()[0];
                            int firstLenght = firstMatch.Value.Length;
                            int secondLenght = secondMatch.Value.Length;
                            Console.WriteLine($"ticket \"{currentTicket}\" - {Math.Min(firstLenght, secondLenght)}{symbol}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{currentTicket}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}