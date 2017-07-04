using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _03.CriticalBreakpoint
{
    public class Line
    {
        public BigInteger X1 { get; set; }

        public BigInteger Y1 { get; set; }

        public BigInteger X2 { get; set; }

        public BigInteger Y2 { get; set; }

        public BigInteger CriticalRatio { get; set; }
    }

    public class CriticalBreakpoint
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<Line> lines = new List<Line>();

            while (input != "Break it.")
            {
                var tokens = input.Split().Select(int.Parse).ToArray();

                Line currentLine = new Line
                {
                    X1 = tokens[0],
                    Y1 = tokens[1],
                    X2 = tokens[2],
                    Y2 = tokens[3],
                    CriticalRatio = BigInteger.Abs(((long)tokens[2] + tokens[3]) - ((long)tokens[0] + tokens[1]))
                };

                lines.Add(currentLine);

                input = Console.ReadLine();
            }

            bool hasBreakpoint = true;
            BigInteger actualRatio = 0;

            foreach (Line line in lines)
            {
                if (actualRatio == 0 && line.CriticalRatio != 0)
                {
                    actualRatio = line.CriticalRatio;
                }

                if ((line.CriticalRatio != actualRatio) && (line.CriticalRatio != 0))
                {
                    hasBreakpoint = false;
                    break;
                }
            }

            if (hasBreakpoint)
            {
                BigInteger totalRatio = BigInteger.Pow(actualRatio, lines.Count);

                BigInteger criticalBreakpoint = 0;

                BigInteger.DivRem(totalRatio, lines.Count, out criticalBreakpoint);

                foreach (var line in lines)
                {
                    Console.WriteLine($"Line: [{line.X1}, {line.Y1}, {line.X2}, {line.Y2}]");
                }

                Console.WriteLine($"Critical Breakpoint: {criticalBreakpoint}");
            }
            else
            {
                Console.WriteLine("Critical breakpoint does not exist.");
            }
        }
    }
}