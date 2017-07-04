using System;

namespace _04.Transport
{
    public class Program
    {
        public static void Main()
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = 4 + 8 + 12;
            int courses = (int)Math.Ceiling((double)numberOfPeople / capacity);

            Console.WriteLine(courses);
        }
    }
}