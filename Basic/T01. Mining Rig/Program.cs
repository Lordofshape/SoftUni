using System;

namespace T01._Mining_Rig
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int videoCardPrice = int.Parse(Console.ReadLine());
            int priceTransient = int.Parse(Console.ReadLine());
            double priceUsedElectricity = double.Parse(Console.ReadLine());
            double profitFromOneCardDay = double.Parse(Console.ReadLine());

            double totalPriceCards = videoCardPrice * 13;
            double totalPriceTransient = priceTransient * 13;
            double totalPrice = totalPriceCards + totalPriceTransient + 1000;
            double profitFromOneCard = profitFromOneCardDay - priceUsedElectricity;
            double profitFromCards = profitFromOneCard * 13;
            double returnInvestition = totalPrice / profitFromCards;

            Console.WriteLine(totalPrice);
            Console.WriteLine($"{Math.Ceiling(returnInvestition)}");
        }
    }
}
