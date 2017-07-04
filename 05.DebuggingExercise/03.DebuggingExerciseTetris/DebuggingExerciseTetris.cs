using System;

namespace _03.DebuggingExerciseTetris
{
    public class DebuggingExerciseTetris
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string currentDirection = Console.ReadLine();

            while (currentDirection != "exit")
            {
                switch (currentDirection)
                {
                    case "up":
                        Up(n);
                        break;

                    case "right":
                        Right(n);
                        break;

                    case "down":
                        Down(n);
                        break;

                    case "left":
                        Left(n);
                        break;
                }

                currentDirection = Console.ReadLine();
            }
        }

        private static void Left(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('.', n) + new string('*', n));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', 2 * n));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('.', n) + new string('*', n));
            }
        }

        private static void Right(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', n) + new string('.', n));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', 2 * n));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', n) + new string('.', n));
            }
        }

        private static void Up(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('.', n) + new string('*', n) + new string('.', n));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', n * 3));
            }
        }

        private static void Down(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', n * 3));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('.', n) + new string('*', n) + new string('.', n));
            }
        }
    }
}