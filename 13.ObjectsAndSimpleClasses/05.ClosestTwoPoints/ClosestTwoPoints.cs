using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ClosestTwoPoints
{
    public class ClosestTwoPoints
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                var currentpoint = ReadPoint();
                points.Add(currentpoint);
            }

            var distanceBetweenPoints = double.MaxValue;
            Point firstPointResult = null;
            Point secondPointResult = null;

            for (int first = 0; first < points.Count; first++)
            {
                for (int second = first + 1; second < points.Count; second++)
                {
                    var firstPoint = points[first];
                    var secondPoint = points[second];

                    var distance = CalcDistance(firstPoint, secondPoint);

                    if (distance < distanceBetweenPoints)
                    {
                        distanceBetweenPoints = distance;
                        firstPointResult = firstPoint;
                        secondPointResult = secondPoint;
                    }
                }
            }

            Console.WriteLine($"{distanceBetweenPoints:F3}");
            Console.WriteLine(firstPointResult.Print());
            Console.WriteLine(secondPointResult.Print());
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
            var pointToString = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var firstPoint = pointToString[0];
            var secondPoint = pointToString[1];

            var point = new Point()
            {
                X = firstPoint,
                Y = secondPoint
            };

            return point;
        }
    }

    public class Point
    {
        public int X { get; set; }

        public int Y { get; set; }

        public string Print()
        {
            return $"({X}, {Y})";
        }
    }
}