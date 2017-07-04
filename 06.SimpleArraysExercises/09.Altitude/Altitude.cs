using System;
using System.Linq;

namespace _09.Altitude
{
    public class Altitude
    {
        public static void Main()
        {
            string[] commandLine = Console.ReadLine().Split().ToArray();

            long altitude = long.Parse(commandLine[0]);
            long count = 1;

            for (int i = 0; i < commandLine.Length - 1; i += 2)
            {
                string command = commandLine[count];
                long index = long.Parse(commandLine[count + 1]);

                if (command.Equals("up"))
                {
                    altitude += index;
                }
                else if (command.Equals("down"))
                {
                    altitude -= index;
                }

                count = count + 2;

                if (altitude <= 0)
                {
                    Console.WriteLine("crashed");
                    return;
                }
            }

            if (altitude <= 0)
            {
                Console.WriteLine("crashed");
            }
            else
            {
                Console.WriteLine($"got through safely. current altitude: {altitude}m");
            }
        }
    }
}