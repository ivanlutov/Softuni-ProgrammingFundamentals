using System;
using System.Linq;

namespace _04.DistanceBetweenPoints
{
    public class DistanceBetweenPoints
    {
        public static void Main()
        {
            var firstPoint = ReadPoint();
            var secondPoint = ReadPoint();

            var result = CalcDistance(firstPoint, secondPoint);
            Console.WriteLine($"{result:F3}");
        }

        public static double CalcDistance(Point firstPoint, Point secondPoint)
        {
            var sideA = firstPoint.X - secondPoint.X;
            var sideB = firstPoint.Y - secondPoint.Y;

            var distance = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
            return distance;
        }

        public static Point ReadPoint()
        {
            var pointToString = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var firstPoint = pointToString[0];
            var secondPoint = pointToString[1];

            var point = new Point
            {
                X = firstPoint,
                Y = secondPoint
            };

            return point;
        }

        public class Point
        {
            public int X { get; set; }

            public int Y { get; set; }
        }
    }
}