using System;
using System.Linq;

namespace _03.ShortWordsSorted
{
    public class ShortWordsSorted
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                .ToLower()
                .Split(".,:;()[]\"'\\/!? ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Where(w => w.Length < 5)
                .OrderBy(w => w).Distinct();

            Console.WriteLine(string.Join(", ", words));
        }
    }
}