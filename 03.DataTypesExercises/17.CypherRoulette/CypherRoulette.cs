using System;

namespace _17.CypherRoulette
{
    public class CypherRoulette
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string printResult = string.Empty;
            string commandLine = string.Empty;

            bool isSpin = true;

            while (n > 0)
            {
                string previousLine = commandLine;

                commandLine = Console.ReadLine();

                if (previousLine == commandLine)
                {
                    printResult = string.Empty;

                    if (commandLine != "spin")
                    {
                        n--;
                    }
                    continue;
                }

                if (commandLine == "spin")
                {
                    isSpin = !isSpin;
                    continue;
                }

                if (isSpin)
                {
                    printResult = printResult + commandLine;
                }
                else
                {
                    printResult = commandLine + printResult;
                }

                n--;
            }
            Console.WriteLine(printResult);
        }
    }
}