namespace Supplies_For_School
{
    using System;

    class Program

    {  
        static void Main(string[] args)
        {
            //Input from console
            int pencilPackage = int.Parse(Console.ReadLine());
            int markerPackage = int.Parse(Console.ReadLine());
            int cleaningDetergent = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            //Logic
            double pensPrice= pencilPackage* 5.80;
            double markerPrice = markerPackage * 7.20;
            double detergentPrice = cleaningDetergent * 1.20;
            double sum = pensPrice + markerPrice + detergentPrice;
            double discountPrice = Math.Abs(discount / 100);
            double finalSum = sum-(sum * discountPrice);

            Console.WriteLine(finalSum);
        }

    }
}
