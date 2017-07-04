using System;

namespace _01.CharityMarathon
{
    public class Program
    {
        public static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            long numberOfRunners = long.Parse(Console.ReadLine());
            long averageNumberOfLapsPerRunner = long.Parse(Console.ReadLine());
            long lenghtOfTrack = long.Parse(Console.ReadLine());
            int capacityOfTrack = int.Parse(Console.ReadLine());
            double amountOfMoneyPerKm = double.Parse(Console.ReadLine());

            capacityOfTrack = capacityOfTrack * days;
            numberOfRunners = Math.Min(numberOfRunners, capacityOfTrack);

            long totalMeters = numberOfRunners * averageNumberOfLapsPerRunner * lenghtOfTrack;
            long totalKm = totalMeters / 1000;
            double totalMoney = totalKm * amountOfMoneyPerKm;

            Console.WriteLine($"Money raised: {totalMoney:F2}");
        }
    }
}