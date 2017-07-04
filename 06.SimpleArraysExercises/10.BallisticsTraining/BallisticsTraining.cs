using System;
using System.Linq;

namespace _10.BallisticsTraining
{
    public class BallisticsTraining
    {
        public static void Main()
        {
            long[] xAndY = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long x = xAndY[0];
            long y = xAndY[1];

            string[] commandLine = Console.ReadLine().Split().ToArray();
            long count = 0;

            long xTarget = 0;
            long yTarget = 0;

            for (int i = 0; i < commandLine.Length / 2; i++)
            {
                string command = commandLine[count];
                long index = long.Parse(commandLine[count + 1]);

                if (command.Equals("up"))
                {
                    yTarget += index;
                }
                else if (command.Equals("down"))
                {
                    yTarget -= index;
                }
                else if (command.Equals("left"))
                {
                    xTarget -= index;
                }
                else if (command.Equals("right"))
                {
                    xTarget += index;
                }

                count += 2;
            }

            if (x == xTarget && y == yTarget)
            {
                Console.WriteLine($"firing at [{xTarget}, {yTarget}]");
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine($"firing at [{xTarget}, {yTarget}]");
                Console.WriteLine("better luck next time...");
            }
        }
    }
}