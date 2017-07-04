using System;

namespace _07.NumbersToWords
{
    public class NumbersToWords
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Letterize();
            }
        }

        private static void Letterize()
        {
            int input = int.Parse(Console.ReadLine());
            int number = Math.Abs(input);

            int firstNum = number / 100;
            int secondNum = (number / 10) % 10;
            int thirdNum = number % 10;

            if (input > 999)
            {
                Console.WriteLine("too large");
            }
            if (input < -999)
            {
                Console.WriteLine("too small");
            }

            string printFirst = string.Empty;
            string printSecond = string.Empty;

            switch (number = firstNum)
            {
                case 1:
                    printFirst = "one-hundred";
                    break;

                case 2:
                    printFirst = "two-hundred";
                    break;

                case 3:
                    printFirst = "three-hundred";
                    break;

                case 4:
                    printFirst = "four-hundred";
                    break;

                case 5:
                    printFirst = "five-hundred";
                    break;

                case 6:
                    printFirst = "six-hundred";
                    break;

                case 7:
                    printFirst = "seven-hundred";
                    break;

                case 8:
                    printFirst = "eight-hundred";
                    break;

                case 9:
                    printFirst = "nine-hundred";
                    break;

                default:
                    break;
            }

            string sumOfTheSecondAndThirdNum = secondNum.ToString() + thirdNum.ToString();
            int sumOfTheSecondAndThirdNumToInt = int.Parse(sumOfTheSecondAndThirdNum);

            if (sumOfTheSecondAndThirdNumToInt >= 1 && sumOfTheSecondAndThirdNumToInt <= 99)
            {
                if (sumOfTheSecondAndThirdNumToInt >= 1 && sumOfTheSecondAndThirdNumToInt <= 20)
                {
                    switch (sumOfTheSecondAndThirdNum)
                    {
                        case "01":
                            printSecond = "one";
                            break;

                        case "02":
                            printSecond = "two";
                            break;

                        case "03":
                            printSecond = "three";
                            break;

                        case "04":
                            printSecond = "four";
                            break;

                        case "05":
                            printSecond = "five";
                            break;

                        case "06":
                            printSecond = "six";
                            break;

                        case "07":
                            printSecond = "seven";
                            break;

                        case "08":
                            printSecond = "eight";
                            break;

                        case "09":
                            printSecond = "nine";
                            break;

                        case "10":
                            printSecond = "ten";
                            break;

                        case "11":
                            printSecond = "eleven";
                            break;

                        case "12":
                            printSecond = "twelve";
                            break;

                        case "13":
                            printSecond = "thirteen";
                            break;

                        case "14":
                            printSecond = "fourteen";
                            break;

                        case "15":
                            printSecond = "fifteen";
                            break;

                        case "16":
                            printSecond = "sixteen";
                            break;

                        case "17":
                            printSecond = "seventeen";
                            break;

                        case "18":
                            printSecond = "eighteen";
                            break;

                        case "19":
                            printSecond = "nineteen";
                            break;

                        case "20":
                            printSecond = "twenty";
                            break;
                    }
                }
                else if (sumOfTheSecondAndThirdNumToInt >= 21 && sumOfTheSecondAndThirdNumToInt <= 99)
                {
                    string firstChar = string.Empty;
                    string secondChar = string.Empty;
                    switch (secondNum)
                    {
                        case 2:
                            firstChar = "twenty";
                            break;

                        case 3:
                            firstChar = "thirty";
                            break;

                        case 4:
                            firstChar = "forty";
                            break;

                        case 5:
                            firstChar = "fifty";
                            break;

                        case 6:
                            firstChar = "sixty";
                            break;

                        case 7:
                            firstChar = "seventy";
                            break;

                        case 8:
                            firstChar = "eighty";
                            break;

                        case 9:
                            firstChar = "ninety";
                            break;
                    }
                    switch (thirdNum)
                    {
                        case 0:
                            secondChar = string.Empty;
                            break;

                        case 1:
                            secondChar = "one";
                            break;

                        case 2:
                            secondChar = "two";
                            break;

                        case 3:
                            secondChar = "three";
                            break;

                        case 4:
                            secondChar = "four";
                            break;

                        case 5:
                            secondChar = "five";
                            break;

                        case 6:
                            secondChar = "six";
                            break;

                        case 7:
                            secondChar = "seven";
                            break;

                        case 8:
                            secondChar = "eight";
                            break;

                        case 9:
                            secondChar = "nine";
                            break;
                    }
                    printSecond = firstChar.ToString() + " " + secondChar.ToString();
                }
            }

            if ((input >= -999 && input <= -100) || (input <= 999 && input >= 100))
            {
                if (input < 0 && input >= -999)
                {
                    if (sumOfTheSecondAndThirdNumToInt == 0)
                    {
                        Console.WriteLine($"minus {printFirst}");
                    }
                    else
                    {
                        Console.WriteLine($"minus {printFirst} and {printSecond}");
                    }
                }
                else
                {
                    if (sumOfTheSecondAndThirdNumToInt == 0)
                    {
                        Console.WriteLine($"{printFirst}");
                    }
                    else
                    {
                        Console.WriteLine($"{printFirst} and {printSecond}");
                    }
                }
            }
        }
    }
}