using System;
using System.Linq;

namespace _03.Phonebook
{
    public class Phonebook
    {
        public static void Main()
        {
            string[] phones = Console.ReadLine().Split(' ').ToArray();
            string[] names = Console.ReadLine().Split(' ').ToArray();

            string commandLine = Console.ReadLine();

            while (!commandLine.Equals("done"))
            {
                PrintElements(names, phones, commandLine);

                commandLine = Console.ReadLine();
            }
        }

        private static void PrintElements(string[] names, string[] phones, string commandLine)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == commandLine)
                {
                    Console.WriteLine($"{names[i]} -> {phones[i]}");
                }
            }
        }
    }
}