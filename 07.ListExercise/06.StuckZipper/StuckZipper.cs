using System;
using System.Linq;

namespace _06.StuckZipper
{
    public class StuckZipper
    {
        public static void Main()
        {
            var firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            var secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

            int idealNumOfMinDigits = int.MaxValue;

            foreach (var number in firstList)
            {
                var currentNumberDigitsCount = Math.Abs(number).ToString().Length;
                if (currentNumberDigitsCount < idealNumOfMinDigits)
                {
                    idealNumOfMinDigits = Math.Abs(number).ToString().Length;
                }
            }

            foreach (var number in secondList)
            {
                var currentNumberDigitsCount = Math.Abs(number).ToString().Length;
                if (currentNumberDigitsCount < idealNumOfMinDigits)
                {
                    idealNumOfMinDigits = Math.Abs(number).ToString().Length;
                }
            }

            for (int i = 0; i < firstList.Count; i++)
            {
                if (Math.Abs(firstList[i]).ToString().Length > idealNumOfMinDigits)
                {
                    firstList.RemoveAt(i);
                    i--;
                }
            }

            for (int i = 0; i < secondList.Count; i++)
            {
                if (Math.Abs(secondList[i]).ToString().Length > idealNumOfMinDigits)
                {
                    secondList.RemoveAt(i);
                    i--;
                }
            }

            int indexCount = 1;

            for (int i = 0; i < firstList.Count; i++)
            {
                secondList.Insert(Math.Min(indexCount, secondList.Count), firstList[i]);
                indexCount += 2;
            }

            Console.WriteLine(string.Join(" ", secondList));
        }
    }
}