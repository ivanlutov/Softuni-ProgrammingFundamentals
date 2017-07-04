using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ArrayManipulator
{
    public class ArrayManipulator
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToList();

            var command = Console.ReadLine();

            while (command != "end")
            {
                var commandLine = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                switch (commandLine[0])
                {
                    case "exchange":
                        var indexExchange = int.Parse(commandLine[1]);
                        if (indexExchange >= 0 && indexExchange < array.Count)
                        {
                            array = Exchange(array, indexExchange);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;

                    case "max":
                        var oddOrEvenMax = commandLine[1];
                        Max(array, oddOrEvenMax);
                        break;

                    case "min":
                        var oddOrEvenMin = commandLine[1];
                        Min(array, oddOrEvenMin);
                        break;

                    case "first":
                        var evenOrOddFirst = commandLine[2];
                        var countFirst = int.Parse(commandLine[1]);
                        if (countFirst <= array.Count)
                        {
                            FirstEvenOrOdd(array, countFirst, evenOrOddFirst);
                        }
                        else
                        {
                            Console.WriteLine("Invalid count");
                        }
                        break;

                    case "last":
                        var evenOrOddLast = commandLine[2];
                        var countLast = int.Parse(commandLine[1]);
                        if (countLast <= array.Count)
                        {
                            LastEvenOrOdd(array, evenOrOddLast, countLast);
                        }
                        else
                        {
                            Console.WriteLine("Invalid count");
                        }
                        break;

                    default:
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", array)}]");
        }

        private static void LastEvenOrOdd(List<int> array, string evenOrOddLast, int countLast)
        {
            if (evenOrOddLast == "even")
            {
                var temp = array.Where(n => Math.Abs(n % 2) == 0).Reverse().ToList();
                var result = temp.Take(countLast).Reverse();

                Console.WriteLine($"[{string.Join(", ", result)}]");
            }
            else
            {
                var temp = array.Where(n => Math.Abs(n % 2) != 0).Reverse().ToList();
                var result = temp.Take(countLast).Reverse();
                Console.WriteLine($"[{string.Join(", ", result)}]");
            }
        }

        private static void FirstEvenOrOdd(List<int> array, int count, string evenOrOdd)
        {
            if (evenOrOdd == "even")
            {
                var temp = array.Where(n => Math.Abs(n % 2) == 0).ToList();
                var result = temp.Take(count);

                Console.WriteLine($"[{string.Join(", ", result)}]");
            }
            else
            {
                var temp = array.Where(n => Math.Abs(n % 2) != 0).ToList();
                var result = temp.Take(count);
                Console.WriteLine($"[{string.Join(", ", result)}]");
            }
        }

        private static void Min(List<int> array, string oddOrEvenMin)
        {
            if (oddOrEvenMin == "even")
            {
                if (array.Count > 0)
                {
                    var minElement = array.Min();
                    var lastIndexOf = array.LastIndexOf(minElement);
                    Console.WriteLine(lastIndexOf);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
            else
            {
                if (array.Count > 0)
                {
                    var minElement = array.Min();
                    var lastIndexOf = array.LastIndexOf(minElement);
                    Console.WriteLine(lastIndexOf);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
        }

        private static void Max(List<int> array, string oddOrEvenMax)
        {
            if (oddOrEvenMax == "even")
            {
                if (array.Count > 0)
                {
                    var maxElement = array.Max();
                    var lastIndexOf = array.LastIndexOf(maxElement);
                    Console.WriteLine(lastIndexOf);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
            else
            {
                if (array.Count > 0)
                {
                    var maxElement = array.Max();
                    var lastIndexOf = array.LastIndexOf(maxElement);
                    Console.WriteLine(lastIndexOf);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
        }

        private static List<int> Exchange(List<int> array, int indexExchange)
        {
            //List<int> temp = array.Skip(indexExchange + 1).ToList();
            //temp.AddRange(array.Take(indexExchange + 1));
            //return temp;

            var leftPart = array.Take(indexExchange + 1);
            var rightPart = array.Skip(indexExchange + 1);
            var combined = rightPart.Concat(leftPart).ToList();
            return combined;
        }
    }
}