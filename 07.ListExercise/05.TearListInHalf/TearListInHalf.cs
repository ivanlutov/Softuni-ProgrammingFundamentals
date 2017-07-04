using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.TearListInHalf
{
    public class TearListInHalf
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            var firstList = new List<int>();
            var secondList = new List<int>();

            for (int i = input.Count / 2; i < input.Count; i++)
            {
                firstList.Add(input[i]);
            }
            for (int i = 0; i < input.Count / 2; i++)
            {
                secondList.Add(input[i]);
            }

            int indexCount = 0;

            for (int i = 0; i < firstList.Count; i++)
            {
                int firstNum = (firstList[i] / 10);
                int secondNum = (firstList[i] % 10);

                secondList.Insert(indexCount, firstNum);

                indexCount += 2;

                secondList.Insert(indexCount, secondNum);

                indexCount++;
            }

            Console.WriteLine(string.Join(" ", secondList));
        }
    }
}