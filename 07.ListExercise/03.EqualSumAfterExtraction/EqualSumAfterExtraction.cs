using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.EqualSumAfterExtraction
{
    public class EqualSumAfterExtraction
    {
        public static void Main()
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < secondList.Count; i++)
            {
                foreach (var num in firstList)
                {
                    if (secondList.Contains(num))
                    {
                        secondList.Remove(num);
                    }
                }
            }

            int sumFirstList = firstList.Sum();
            int sumSecondList = secondList.Sum();
            int diff = Math.Abs(sumFirstList - sumSecondList);

            if (sumFirstList == sumSecondList)
            {
                Console.WriteLine($"Yes. Sum: {sumFirstList}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {diff}");
            }
        }
    }
}