namespace Yard_Greening
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double landscapeArea = double.Parse(Console.ReadLine());

            double greeningSum = landscapeArea * 7.61;
            double discount = Math.Abs(greeningSum * 0.18);

            double finalPrice = greeningSum - discount;

            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
