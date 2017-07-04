using System;

namespace _12.VariableInHexadecimalFormat
{
    public class VariableInHexadecimalFormat
    {
        public static void Main()
        {
            string hexValue = Console.ReadLine();

            int decValue = Convert.ToInt32(hexValue, 16);

            Console.WriteLine(decValue);
        }
    }
}