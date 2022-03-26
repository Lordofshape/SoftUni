using System;

namespace T04._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            const double puzzle = 2.60;
            const double doll = 3.00;
            const double bearToy = 4.10;
            const double minion = 8.20;
            const double truck = 2.00;

            double excursionPrice = double.Parse(Console.ReadLine());
            int numbersOfPuzzle = int.Parse(Console.ReadLine());
            int numbersofDoll = int.Parse(Console.ReadLine());
            int numbersOfBears = int.Parse(Console.ReadLine());
            int numbersOfMinions = int.Parse(Console.ReadLine());
            int numbersOfTrucks = int.Parse(Console.ReadLine());

            int toysCount = numbersOfBears + numbersofDoll + numbersOfMinions + numbersOfPuzzle + numbersOfTrucks;
            double totalPrice = numbersOfBears * bearToy + numbersofDoll * doll + numbersOfMinions * minion + numbersOfPuzzle * puzzle + numbersOfTrucks * truck;

            if (toysCount >= 50)
            {
                totalPrice *= 0.75;
            }

            double rent = totalPrice * 0.10;
            double differance = Math.Abs(rent + excursionPrice - totalPrice);
            if (totalPrice >= rent + excursionPrice)
            {
                Console.WriteLine($"Yes! {differance:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {differance:f2} lv needed.");
            }
        }
    }
}
