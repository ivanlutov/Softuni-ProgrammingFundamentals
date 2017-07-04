using System;

namespace _01.DebuggingExerciseTrickyStrings
{
    public class DebuggingExerciseTrickyStrings
    {
        public static void Main()
        {
            string delimiter = Console.ReadLine();
            int numberOfStrings = int.Parse(Console.ReadLine());

            string result = string.Empty;

            for (int i = 0; i < numberOfStrings - 1; i++)
            {
                string currentString = Console.ReadLine();

                result += currentString + delimiter;
            }

            string currentStrin = Console.ReadLine();
            result += currentStrin;

            Console.WriteLine(result);
        }
    }
}