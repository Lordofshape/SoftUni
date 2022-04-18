using System;

namespace P01_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int procesor = int.Parse(Console.ReadLine());
            int videoCard = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());
            int ramNumber = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double procesorInBg = procesor * 1.57;
            double videoCardInBg = videoCard * 1.57;
            double ramInBg = ram * 1.57;
            double ramsFinalPrice = ramInBg * ramNumber;
            double procoserPriceDiscount = procesorInBg * discount;
            double videoCardPriceDiscount = videoCardInBg * discount;
            double procesorFinalPRice = procesorInBg - procoserPriceDiscount;
            double videoCardFinalPrice = videoCardInBg - videoCardPriceDiscount;

            double finalPrice = procesorFinalPRice + videoCardFinalPrice + ramsFinalPrice;
            Console.WriteLine($"Money needed - {finalPrice:f2} leva.");

        }
    }
}
