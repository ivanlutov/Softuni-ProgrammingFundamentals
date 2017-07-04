using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.JSONStringify
{
    public class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public List<int> Grades { get; set; }
    }

    public class JSONStringify
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var students = new List<Student>();

            while (input != "stringify")
            {
                var inputLine = input.Split(new char[] { ' ', ':', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);
                if (inputLine.Length > 1)
                {
                    var name = inputLine[0];
                    var age = int.Parse(inputLine[1]);

                    Student currentStudent = new Student();
                    currentStudent.Name = name;
                    currentStudent.Age = age;
                    currentStudent.Grades = new List<int>();

                    for (int i = 2; i < inputLine.Length; i++)
                    {
                        currentStudent.Grades.Add(int.Parse(inputLine[i]));
                    }
                    students.Add(currentStudent);
                }

                input = Console.ReadLine();
            }

            Console.Write("[");
            foreach (var student in students)
            {
                if (students.Last() == student)
                {
                    Console.Write($"{{name:\"{student.Name}\",age:{student.Age},grades:[{string.Join(", ", student.Grades)}]}}");
                }
                else
                {
                    Console.Write($"{{name:\"{student.Name}\",age:{student.Age},grades:[{string.Join(", ", student.Grades)}]}},");
                }
            }
            Console.WriteLine("]");
        }
    }
}