using System;
using System.Globalization;

namespace _01.DayOfWeek
{
    public class DayOfWeek
    {
        public static void Main()
        {
            string dayOfWeek = Console.ReadLine();

            var date = DateTime.ParseExact(dayOfWeek, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}