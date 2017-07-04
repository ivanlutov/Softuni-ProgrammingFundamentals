using System;
using System.Linq;

namespace _03.EnduranceRally
{
    public class EnduranceRally
    {
        public static void Main()
        {
            var names = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var zones = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            var addIndex = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < names.Length; i++)
            {
                var currentName = names[i];
                double startFuel = (double)currentName[0];

                for (int j = 0; j < zones.Length; j++)
                {
                    var currentIndex = j;
                    if (addIndex.Contains(currentIndex))
                    {
                        startFuel += zones[j];
                        if (startFuel <= 0)
                        {
                            Console.WriteLine($"{currentName} - reached {currentIndex}");
                            break;
                        }
                    }
                    else
                    {
                        startFuel -= zones[j];
                        if (startFuel <= 0)
                        {
                            Console.WriteLine($"{currentName} - reached {currentIndex}");
                            break;
                        }
                    }
                }
                if (startFuel > 0)
                {
                    Console.WriteLine($"{currentName} - fuel left {startFuel:F2}");
                }
            }
        }
    }
}