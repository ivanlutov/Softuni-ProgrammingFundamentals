using System;
using System.Collections.Generic;

namespace _05.Boxes
{
    public class Point
    {
        public int X { get; set; }

        public int Y { get; set; }

        public static double Distance(Point firstPoint, Point secondPoint)
        {
            var sideA = firstPoint.X - secondPoint.X;
            var sideB = firstPoint.Y - secondPoint.Y;

            var distance = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
            return distance;
        }
    }

    public class Box
    {
        public Point UpperLeft { get; set; }

        public Point UpperRight { get; set; }

        public Point BottomLeft { get; set; }

        public Point BottomRight { get; set; }

        public static int CalculatePerimeter(int width, int height)
        {
            var perimeter = 2 * width + 2 * height;
            return perimeter;
        }

        public static double CalculateArea(int width, int height)
        {
            var area = width * height;
            return area;
        }
    }

    public class Boxes
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var boxes = new List<Box>();

            while (!input.Equals("end"))
            {
                var inputData = input.Split(new char[] { '|', ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
                var currentBox = new Box();
                if (inputData.Length > 1)
                {
                    currentBox.UpperLeft = ReadPoint(int.Parse(inputData[0]), int.Parse(inputData[1]));
                    currentBox.UpperRight = ReadPoint(int.Parse(inputData[2]), int.Parse(inputData[3]));
                    currentBox.BottomLeft = ReadPoint(int.Parse(inputData[4]), int.Parse(inputData[5]));
                    currentBox.BottomRight = ReadPoint(int.Parse(inputData[6]), int.Parse(inputData[7]));
                }

                boxes.Add(currentBox);
                input = Console.ReadLine();
            }

            foreach (var box in boxes)
            {
                var width = (int)Point.Distance(box.UpperLeft, box.UpperRight);
                var height = (int)Point.Distance(box.UpperLeft, box.BottomLeft);
                Console.WriteLine($"Box: {width}, {height}");
                Console.WriteLine($"Perimeter: {Box.CalculatePerimeter(width, height)}");
                Console.WriteLine($"Area: {Box.CalculateArea(width, height)}");
            }
        }

        public static Point ReadPoint(int firstPoint, int secondPoint)
        {
            var point = new Point
            {
                X = firstPoint,
                Y = secondPoint
            };

            return point;
        }
    }
}