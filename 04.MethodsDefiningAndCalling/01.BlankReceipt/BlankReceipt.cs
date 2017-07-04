using System;

namespace _01.BlankReceipt
{
    public class BlankReceipt
    {
        public static void Main()
        {
            PrintReceipt();
        }

        public static void PrintReceipt()
        {
            PrintReceiptHeader();
            PrintReceiptBody();
            PrintReceiptFooter();
        }

        public static void PrintReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        public static void PrintReceiptBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        public static void PrintReceiptFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© SoftUni");
        }
    }
}