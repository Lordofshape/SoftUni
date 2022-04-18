using System;

namespace P05_Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budge = double.Parse(Console.ReadLine());
            int stuntman = int.Parse(Console.ReadLine());
            double priceClothes = double.Parse(Console.ReadLine());

            double decorPrice = budge * 0.10;
            double totalPriceClothes = stuntman * priceClothes;
            if (stuntman>150)
            {
                totalPriceClothes *= 0.90;
            }

            double totalMoney = decorPrice + totalPriceClothes;
            if (totalMoney>budge)
            {
                double neededMoney = totalMoney - budge;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {neededMoney:f2} leva more.");
            }
            else
            {
                double moneyLeft = budge - totalMoney;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            }
        }
    }
}
