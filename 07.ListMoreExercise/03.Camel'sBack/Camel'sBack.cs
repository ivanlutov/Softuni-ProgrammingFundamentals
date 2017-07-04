using System;
using System.Linq;

namespace _03.Camel_sBack
{
    public class Program
    {
        public static void Main()
        {
            var numberOfBuilding = Console.ReadLine().Split().Select(int.Parse).ToList();
            int camelBack = int.Parse(Console.ReadLine());

            int count = 0;

            while (numberOfBuilding.Count > camelBack)
            {
                numberOfBuilding.RemoveAt(0);
                numberOfBuilding.RemoveAt(numberOfBuilding.Count - 1);
                count++;
            }

            if (count == 0)
            {
                var stableResult = string.Join(" ", numberOfBuilding);
                Console.WriteLine($"already stable: {stableResult}");
                return;
            }
            else
            {
                var result = string.Join(" ", numberOfBuilding);
                Console.WriteLine($"{count} rounds");
                Console.WriteLine($"remaining: {result}");
            }
        }
    }
}