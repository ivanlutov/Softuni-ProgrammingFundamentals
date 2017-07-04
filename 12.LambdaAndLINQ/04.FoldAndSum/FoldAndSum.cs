using System;
using System.Linq;

namespace _04.FoldAndSum
{
    public class FoldAndSum
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var k = numbers.Length / 4;

            var leftPart = numbers.Take(k).Reverse();
            var rightPart = numbers.Reverse().Take(k);

            var downRow = numbers.Skip(k).Take(2 * k).ToArray();
            var upRow = leftPart.Concat(rightPart).ToArray();
            var result = new int[downRow.Length];

            for (int i = 0; i < downRow.Length; i++)
            {
                result[i] = downRow[i] + upRow[i];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}