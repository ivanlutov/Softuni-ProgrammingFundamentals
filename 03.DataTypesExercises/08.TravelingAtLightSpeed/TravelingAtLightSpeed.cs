using System;
using System.Globalization;

namespace _08.TravelingAtLightSpeed
{
    public class TravelingAtLightSpeed
    {
        public static void Main()
        {
            decimal lightYears = decimal.Parse(Console.ReadLine());

            decimal lightYearInKm = 9450000000000M;
            decimal speedOfLight = 300000M;

            decimal total = (lightYearInKm * lightYears) / speedOfLight;

            TimeSpan diff = TimeSpan.FromSeconds((double)total);
            string formatted = string.Format(
                  CultureInfo.CurrentCulture,
                  "{0} weeks\n{1} days\n{2} hours\n{3} minutes\n{4} seconds\n",
                  diff.Days / 7,
                  diff.Days % 7,
                  diff.Hours,
                  diff.Minutes,
                  diff.Seconds);

            Console.WriteLine(formatted);
        }
    }
}