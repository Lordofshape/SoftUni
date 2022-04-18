using System;

namespace T02._Beer_And_Chips
{
    class Program
    {
        static void Main(string[] args)
        {
            const double beer = 1.2;
            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int bottles = int.Parse(Console.ReadLine());
            int packagesChips = int.Parse(Console.ReadLine());

            double totalPriceBeer = beer * bottles;
            double priceForOneChips = totalPriceBeer * 0.45;
            double totalPriceChips = Math.Ceiling(packagesChips * priceForOneChips);
            double totalPrice = totalPriceBeer + totalPriceChips;
            double moneyLeft =budget - totalPrice;
            double neededMoney = totalPrice - budget;
            
            if (moneyLeft>=0)
            {
                Console.WriteLine($"{name} bought a snack and has {moneyLeft:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"{name} needs {neededMoney:f2} more leva!");
            }
        }
    }
}
