using System;

namespace P11_Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal totalCoffeePrice = 0;
            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsuleCount = int.Parse(Console.ReadLine());
                decimal priceOfCoffee = days * capsuleCount * pricePerCapsule;
                totalCoffeePrice += priceOfCoffee;
                Console.WriteLine($"The price for the coffee is: ${priceOfCoffee:f2}");
            }
            Console.WriteLine($"Total: ${totalCoffeePrice:f2}");
        }
    }
}
