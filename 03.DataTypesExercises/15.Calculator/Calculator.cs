using System;

namespace _15.Calculator
{
    public class Calculator
    {
        public static void Main()
        {
            int firstOperand = int.Parse(Console.ReadLine());
            char operat = char.Parse(Console.ReadLine());
            int secondOperand = int.Parse(Console.ReadLine());

            switch (operat)
            {
                case '+':
                    Console.WriteLine($"{firstOperand} + {secondOperand} = {firstOperand + secondOperand}");
                    break;

                case '-':
                    Console.WriteLine($"{firstOperand} - {secondOperand} = {firstOperand - secondOperand}");
                    break;

                case '*':
                    Console.WriteLine($"{firstOperand} * {secondOperand} = {firstOperand * secondOperand}");
                    break;

                case '/':
                    Console.WriteLine($"{firstOperand} / {secondOperand} = {firstOperand / secondOperand}");
                    break;

                default:
                    break;
            }
        }
    }
}