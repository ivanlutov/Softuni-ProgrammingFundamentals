using System;
using System.Linq;

namespace _02.IntegerInsertion
{
    public class IntegerInsertion
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (!command.Equals("end"))
            {
                string firstDigit = command.Substring(0, 1);
                int index = Int32.Parse(firstDigit);
                int numberToAdd = Int32.Parse(command);

                input.Insert(index, numberToAdd);

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}