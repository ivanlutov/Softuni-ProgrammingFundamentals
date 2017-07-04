using System;
using System.Linq;

namespace _05.CharRotation
{
    public class CharRotation
    {
        public static void Main()
        {
            string inputString = Console.ReadLine();
            int[] inputDigit = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            char[] chars = inputString.ToCharArray();

            string result = string.Empty;

            for (int i = 0; i < inputDigit.Length; i++)
            {
                if (inputDigit[i] % 2 == 0)
                {
                    result += (char)(chars[i] - inputDigit[i]);
                }
                else if (inputDigit[i] % 2 != 0)
                {
                    result += (char)(chars[i] + inputDigit[i]);
                }
            }

            Console.WriteLine(result);
        }
    }
}