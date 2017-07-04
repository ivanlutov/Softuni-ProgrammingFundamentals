using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.SalesReport
{
    public class SalesReport
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var salesByTown = new SortedDictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                var currentSaleAsString = Console.ReadLine();
                var currentSale = Sale.Parse(currentSaleAsString);

                if (!salesByTown.ContainsKey(currentSale.Town))
                {
                    salesByTown[currentSale.Town] = 0M;
                }
                salesByTown[currentSale.Town] += currentSale.Price * currentSale.Quantity;
            }

            foreach (var townSale in salesByTown)
            {
                Console.WriteLine($"{townSale.Key} -> {townSale.Value:F2}");
            }
        }
    }

    public class Sale
    {
        public string Town { get; set; }

        public string Product { get; set; }

        public decimal Price { get; set; }

        public decimal Quantity { get; set; }

        public static Sale Parse(string saleAsString)
        {
            var saleAttribute = saleAsString.Split().ToArray();

            return new Sale
            {
                Town = saleAttribute[0],
                Product = saleAttribute[1],
                Price = decimal.Parse(saleAttribute[2]),
                Quantity = decimal.Parse(saleAttribute[3])
            };
        }
    }
}