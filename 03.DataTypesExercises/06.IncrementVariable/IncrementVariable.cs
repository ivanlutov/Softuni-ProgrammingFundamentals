using System;

namespace _06.IncrementVariable
{
    public class IncrementVariable
    {
        public static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            int sbyteNum = 256;

            int overflowed = input / sbyteNum;
            int residue = input - (sbyteNum * overflowed);

            Console.WriteLine($"{residue}");
            Console.WriteLine($"Overflowed {overflowed} times");
        }
    }
}