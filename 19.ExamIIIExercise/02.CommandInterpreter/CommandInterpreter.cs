using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.CommandInterpreter
{
    public class CommandInterpreter
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var commandLine = Console.ReadLine();

            while (commandLine != "end")
            {
                var parameters = commandLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                bool isValid = false;

                switch (parameters[0])
                {
                    case "reverse":
                        var reverseIndex = int.Parse(parameters[2]);
                        var reverseCount = int.Parse(parameters[4]);
                        isValid = ValidationSortAndReverse(array, reverseIndex, reverseCount);

                        if (isValid)
                        {
                            Reverse(array, reverseIndex, reverseCount);
                        }
                        break;

                    case "sort":
                        var sortIndex = int.Parse(parameters[2]);
                        var sortCount = int.Parse(parameters[4]);
                        isValid = ValidationSortAndReverse(array, sortIndex, sortCount);

                        if (isValid)
                        {
                            Sort(array, sortIndex, sortCount);
                        }
                        break;

                    case "rollLeft":
                        var countLeft = int.Parse(parameters[1]);
                        isValid = ValidationRollLeftAndRight(array, countLeft);

                        if (isValid)
                        {
                            RollLeft(array, countLeft);
                        }
                        break;

                    case "rollRight":
                        var countRight = int.Parse(parameters[1]);
                        isValid = ValidationRollLeftAndRight(array, countRight);

                        if (isValid)
                        {
                            RollRight(array, countRight);
                        }
                        break;
                }

                if (isValid == false)
                {
                    Console.WriteLine("Invalid input parameters.");
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", array)}]");
        }

        private static bool ValidationRollLeftAndRight(List<string> array, int count)
        {
            var result = count >= 0;
            return result;
        }

        private static bool ValidationSortAndReverse(List<string> array, int index, int count)
        {
            var result = index >= 0 && index < array.Count && count >= 0 && index + count <= array.Count;
            return result;
        }

        private static void Reverse(List<string> array, int reverseIndex, int reverseCount)
        {
            array.Reverse(reverseIndex, reverseCount);
        }

        private static void Sort(List<string> array, int sortIndex, int sortCount)
        {
            array.Sort(sortIndex, sortCount, null);
        }

        private static void RollLeft(List<string> array, int countLeft)
        {
            int count = countLeft % array.Count;

            for (int i = 0; i < count; i++)
            {
                string firstElement = array[0];
                for (int j = 0; j < array.Count - 1; j++)
                {
                    array[j] = array[j + 1];
                }
                array[array.Count - 1] = firstElement;
            }
        }

        private static void RollRight(List<string> array, int countRight)
        {
            int count = countRight % array.Count;

            for (int i = 0; i < count; i++)
            {
                string lastElement = array[array.Count - 1];

                for (int j = array.Count - 1; j > 0; j--)
                {
                    array[j] = array[j - 1];
                }

                array[0] = lastElement;
            }
        }
    }
}