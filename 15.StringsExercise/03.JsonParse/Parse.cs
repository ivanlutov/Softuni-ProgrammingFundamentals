using System;
using System.Collections.Generic;

namespace _03.JsonParse
{
    public class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public List<int> Grades { get; set; }
    }

    public class Parse
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var students = new List<string>();
            var resultStudents = new List<Student>();

            var index = -1;
            while (true)
            {
                index = input.IndexOf("}");

                if (index < 0)
                {
                    break;
                }
                var currentStudent = input.Substring(0, index);
                students.Add(currentStudent);
                input = input.Remove(0, index + 1);
            }

            foreach (var student in students)
            {
                var currentStudentString = student;
                currentStudentString = currentStudentString.Replace("name", "*");
                currentStudentString = currentStudentString.Replace("age", "*");
                currentStudentString = currentStudentString.Replace("grades", "*");
                var studentTokens = currentStudentString.Split(new char[] { '*', '[', '{', ':', '"', ',', ']', '}' }, StringSplitOptions.RemoveEmptyEntries);
                var name = studentTokens[0];
                var age = int.Parse(studentTokens[1]);

                Student currentStudent = new Student();
                currentStudent.Name = name;
                currentStudent.Age = age;
                currentStudent.Grades = new List<int>();

                if (studentTokens.Length > 2)
                {
                    for (int i = 2; i < studentTokens.Length; i++)
                    {
                        currentStudent.Grades.Add(int.Parse(studentTokens[i]));
                    }
                }

                resultStudents.Add(currentStudent);
            }

            foreach (var student in resultStudents)
            {
                if (student.Grades.Count > 0)
                {
                    Console.WriteLine($"{student.Name} : {student.Age} -> {string.Join(", ", student.Grades)}");
                }
                else
                {
                    Console.WriteLine($"{student.Name} : {student.Age} -> None");
                }
            }
        }
    }
}