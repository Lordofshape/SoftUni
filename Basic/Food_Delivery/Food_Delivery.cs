namespace Food_Delivery
{
using System;

    class Program
    {
        static void Main(string[] args)
        {
            
            //Input
            int chickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int veganMenu = int.Parse(Console.ReadLine());

            //Logic
            double chickenMenuPrice = chickenMenu * 10.35;
            double fishMenuPrice = fishMenu * 12.40;
            double veganMenuPrice = veganMenu * 8.15;
            double orderPrice = chickenMenuPrice + fishMenuPrice + veganMenuPrice;
            double desert = orderPrice * 0.20;
            double orderWithDelivery = orderPrice + desert + 2.50;

            Console.WriteLine(orderWithDelivery);

        }
    }
}
