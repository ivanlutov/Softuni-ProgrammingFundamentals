using System;
using System.Globalization;

namespace _01.SoftuniCoffeeOrders
{
    public class SoftuniCoffeeOrders
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            decimal totalPrice = 0M;

            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                int capsulesCount = int.Parse(Console.ReadLine());

                decimal currentPrice = ((DateTime.DaysInMonth(orderDate.Year, orderDate.Month) * (long)capsulesCount) * pricePerCapsule);
                Console.WriteLine($"The price for the coffee is: ${currentPrice:F2}");
                totalPrice += currentPrice;
            }

            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}