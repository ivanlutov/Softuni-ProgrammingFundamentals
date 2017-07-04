using System;

namespace _07.GreaterOfTwoValues
{
    public class GreaterOfTwoValues
    {
        public static void Main()
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int result = GetMax(first, second);
                Console.WriteLine(result);
            }
            else if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                char result = GetMax(first, second);
                Console.WriteLine(result);
            }
            else if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                string result = GetMax(first, second);
                Console.WriteLine(result);
            }
        }

        private static int GetMax(int first, int second)
        {
            int result = Math.Max(first, second);
            return result;
        }

        private static char GetMax(char first, char second)
        {
            if (first >= second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        private static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
            {
                return first;
            }
            return second;
        }
    }
}