using System;

namespace P02_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            double tshirtPrice = double.Parse(Console.ReadLine());
            double sumForGift = double.Parse(Console.ReadLine());

            double shortsPrice = tshirtPrice * 0.75;
            double socksPrice = shortsPrice * 0.20;
            double shoesPrice = (tshirtPrice + shortsPrice) * 2;
            double discount = (tshirtPrice + shortsPrice + socksPrice + shoesPrice) * 0.15;

            double finalPrice = (tshirtPrice + shortsPrice + socksPrice + shoesPrice) - discount;
            if (sumForGift<=finalPrice)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {finalPrice:f2} lv.");
            }
            else
            {
                sumForGift -= finalPrice;
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {sumForGift:f2} lv. more.");
            }
        }
    }
}
