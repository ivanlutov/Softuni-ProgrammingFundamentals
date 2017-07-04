using System;

namespace _01.SinoTheWalker
{
    public class SinoTheWalker
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            double second = double.Parse(Console.ReadLine());
            double steps = double.Parse(Console.ReadLine());

            DateTime myDate = DateTime.ParseExact(input, "HH:mm:ss",
                                       System.Globalization.CultureInfo.InvariantCulture);
            var totalSecond = (second * steps) % (24 * 60 * 60);

            myDate = myDate.AddSeconds((double)totalSecond);
            Console.WriteLine($"Time Arrival: {myDate.TimeOfDay}");
        }
    }
}