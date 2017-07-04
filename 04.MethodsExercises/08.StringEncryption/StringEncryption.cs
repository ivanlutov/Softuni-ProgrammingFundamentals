using System;

namespace _08.StringEncryption
{
    public class StringEncryption
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string printResult = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string cryptChar = string.Empty;

                char character = char.Parse(Console.ReadLine());
                int intChar = character;

                int firstDigit = intChar;

                while (firstDigit >= 10)
                {
                    firstDigit /= 10;
                }

                int lastDigit = intChar % 10;

                cryptChar += firstDigit.ToString() + lastDigit.ToString();

                char secondChar = (char)(intChar + lastDigit);

                cryptChar = secondChar + cryptChar;

                char thirdChar = (char)(intChar - firstDigit);

                cryptChar = cryptChar + thirdChar;

                printResult += cryptChar;
            }
            Console.WriteLine(printResult);
        }
    }
}