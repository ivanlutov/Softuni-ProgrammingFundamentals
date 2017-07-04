using System;
using System.Linq;

namespace _06.RectanglePosition
{
    public class RectanglePosition
    {
        public static void Main()
        {
            var firstRectangle = ReadRectangle();
            var secondRectangle = ReadRectangle();

            var result = firstRectangle.isInside(secondRectangle);
            var printResult = result ? "Inside" : "Not inside";

            Console.WriteLine(printResult);
        }

        private static Rectangle ReadRectangle()
        {
            var rectanglesPoint = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var left = rectanglesPoint[0];
            var top = rectanglesPoint[1];
            var width = rectanglesPoint[2];
            var height = rectanglesPoint[3];

            Rectangle rectangle = new Rectangle
            {
                Left = left,
                Top = top,
                Width = width,
                Height = height
            };

            return rectangle;
        }
    }

    public class Rectangle
    {
        public int Left { get; set; }

        public int Top { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public int Right
        {
            get
            {
                return Left + Width;
            }
        }

        public int Bottom
        {
            get
            {
                return Top + Height;
            }
        }

        public bool isInside(Rectangle rectangle)
        {
            var leftIsValid = rectangle.Left <= Left;
            var topIsValid = rectangle.Top <= Top;
            var rightIsValid = rectangle.Right >= Right;
            var bottomIsValid = rectangle.Bottom >= Bottom;

            return leftIsValid && topIsValid && rightIsValid && bottomIsValid;
        }
    }
}