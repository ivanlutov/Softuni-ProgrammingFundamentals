using System;

namespace _05.DistanceOfTheStars
{
    public class Program
    {
        public static void Main()
        {
            decimal lightYear = 9450000000000M;

            decimal proximaCentauri = (decimal)4.22 * lightYear;
            decimal milkyWay = 26000 * lightYear;
            decimal diameterMilkyWay = 100000 * lightYear;
            decimal distanceFromEarth = (decimal)46500000000 * lightYear;

            Console.WriteLine(proximaCentauri.ToString("e2"));
            Console.WriteLine(milkyWay.ToString("e2"));
            Console.WriteLine(diameterMilkyWay.ToString("e2"));
            Console.WriteLine(distanceFromEarth.ToString("e2"));
        }
    }
}