using System;

namespace _01.HornetWings
{
    public class HornetWings
    {
        public static void Main()
        {
            var wingFlaps = long.Parse(Console.ReadLine());
            var distanceForThousendWindFlaps = double.Parse(Console.ReadLine());
            var endurance = long.Parse(Console.ReadLine());

            var distance = (wingFlaps / 1000) * distanceForThousendWindFlaps;
            var rest = (wingFlaps / endurance) * 5;
            var time = wingFlaps / 100;
            var timeResult = rest + time;

            Console.WriteLine($"{distance:F2} m.");
            Console.WriteLine($"{timeResult} s.");
        }
    }
}