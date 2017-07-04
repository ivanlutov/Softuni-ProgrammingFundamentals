using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Exercises
{
    public class Exercises
    {
        public static void Main()
        {
            List<Exercise> exercises = new List<Exercise>();

            string inputLine = Console.ReadLine();

            while (inputLine != "go go go")
            {
                var inputData = inputLine.Split(new char[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);

                Exercise newExercise = new Exercise();
                newExercise.Topic = inputData[0];
                newExercise.CourseName = inputData[1];
                newExercise.JudgeContestLink = inputData[2];
                newExercise.Problems = inputData.Skip(3).ToList();

                exercises.Add(newExercise);

                inputLine = Console.ReadLine();
            }

            foreach (Exercise exercise in exercises)
            {
                Console.WriteLine($"Exercises: {exercise.Topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{exercise.CourseName}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: {exercise.JudgeContestLink}");
                int count = 1;
                foreach (var problem in exercise.Problems)
                {
                    Console.WriteLine($"{count}. {problem}");
                    count++;
                }
            }
        }
    }

    public class Exercise
    {
        public string Topic { get; set; }

        public string CourseName { get; set; }

        public string JudgeContestLink { get; set; }

        public List<string> Problems { get; set; }
    }
}