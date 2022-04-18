using System;

namespace T04._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int ageOfLilly = int.Parse(Console.ReadLine());
            double priceOfLaundryM = double.Parse(Console.ReadLine());
            int priceOfToy = int.Parse(Console.ReadLine());
            double totalSum = 0;
            int sum = 0;
            int toys = 0;

            for (int i = 1; i <= ageOfLilly; i++)
            {
                sum += 5;
                if (i % 2 == 0)
                {
                    totalSum += sum -1;
                }
                else
                {
                    toys++;
                }
            }
            totalSum += toys * priceOfToy;
            if (totalSum>=priceOfLaundryM)
            {
                double reminder = totalSum - priceOfLaundryM;
                Console.WriteLine($"Yes! {reminder:f2}");
            }
            else
            {
                double neededMoney = priceOfLaundryM - totalSum;
                Console.WriteLine($"No! {neededMoney:f2}");
            }
        }
    }
}
