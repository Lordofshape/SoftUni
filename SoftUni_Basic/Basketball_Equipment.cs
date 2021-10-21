namespace Basketball_Equipment
{
using System;

    class Program
    {
        static void Main(string[] args)
        {
            //input
            int yearTax = int.Parse(Console.ReadLine());
            //Logic
            double sneakers = yearTax * 0.6;
            double outfit = sneakers * 0.8;
            double ball = outfit * 0.25;
            double accessories = ball * 0.20;
            double needenSum = yearTax + sneakers + outfit + ball + accessories;

            Console.WriteLine(needenSum);

        }
    }
}
