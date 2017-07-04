using System;

namespace _01.SweetDessert
{
    public class SweetDessert
    {
        public static void Main()
        {
            var amountOfCash = double.Parse(Console.ReadLine());
            var numberOfGuest = int.Parse(Console.ReadLine());
            var priceOfBananas = double.Parse(Console.ReadLine());
            var priceOfEggs = double.Parse(Console.ReadLine());
            var priceOfBerries = double.Parse(Console.ReadLine());

            double oneSetPrice = (2 * priceOfBananas) + (4 * priceOfEggs) + (0.2 * priceOfBerries);
            var portionNeeded = Math.Ceiling(numberOfGuest / 6d);
            var moneyNeeded = portionNeeded * oneSetPrice;

            if (moneyNeeded <= amountOfCash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {moneyNeeded:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(moneyNeeded - amountOfCash):F2}lv more.");
            }
        }
    }
}