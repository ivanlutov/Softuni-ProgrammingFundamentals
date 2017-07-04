using System;
using System.Linq;

namespace _06.Batteries
{
    public class Batteries
    {
        public static void Main()
        {
            double[] capacity = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] usagePerHour = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int hours = int.Parse(Console.ReadLine());

            double[] allUsageEnergy = new double[capacity.Length];
            double[] batteryLasted = new double[capacity.Length];
            double[] batteryDead = new double[capacity.Length];
            double[] percent = new double[capacity.Length];

            for (int i = 0; i < capacity.Length; i++)
            {
                allUsageEnergy[i] = usagePerHour[i] * hours;
                batteryLasted[i] = Math.Abs(allUsageEnergy[i] - capacity[i]);
                batteryDead[i] = capacity[i] / usagePerHour[i];
                percent[i] = (batteryLasted[i] / capacity[i]) * 100;
            }

            for (int i = 0; i < capacity.Length; i++)
            {
                if (allUsageEnergy[i] < capacity[i])
                {
                    Console.WriteLine($"Battery {i + 1}: {batteryLasted[i]:F2} mAh ({percent[i]:F2})%");
                }
                else
                {
                    Console.WriteLine($"Battery {i + 1}: dead (lasted {Math.Ceiling(batteryDead[i])} hours)");
                }
            }
        }
    }
}