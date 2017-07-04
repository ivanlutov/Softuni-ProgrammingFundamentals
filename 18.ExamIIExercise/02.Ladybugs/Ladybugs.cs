using System;
using System.Linq;

namespace _02.Ladybugs
{
    public class Ladybugs
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            var indexesOfLadybugs = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var field = new int[size];

            foreach (var index in indexesOfLadybugs)
            {
                if (index < 0 || index >= size)
                {
                    continue;
                }

                field[index] = 1;
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                var commandLine = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                var ladyBugIndex = int.Parse(commandLine[0]);
                var direction = commandLine[1];
                var flyLenght = int.Parse(commandLine[2]);

                if (ladyBugIndex < 0 || ladyBugIndex >= size)
                {
                    continue;
                }

                if (field[ladyBugIndex] == 0)
                {
                    continue;
                }

                field[ladyBugIndex] = 0;
                var position = ladyBugIndex;

                while (true)
                {
                    if (direction == "right")
                    {
                        position += flyLenght;
                    }
                    else
                    {
                        position -= flyLenght;
                    }

                    if (position < 0 || position >= size)
                    {
                        break;
                    }

                    if (field[position] == 1)
                    {
                        continue;
                    }
                    else
                    {
                        field[position] = 1;
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}