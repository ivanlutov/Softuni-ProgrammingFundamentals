using System;
using System.Collections.Generic;

namespace _01.AverageStudentGrades
{
    public class AverageStudentGrades
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var gradesDictionary = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                var nameAndGrades = Console.ReadLine().Split();

                var name = nameAndGrades[0];
                var grades = double.Parse(nameAndGrades[1]);
            }
        }
    }
}