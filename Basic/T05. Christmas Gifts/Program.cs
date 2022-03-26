using System;

namespace T05._Christmas_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            const int toyPrice = 5;
            const int sweaterPrice = 15;
            string input = Console.ReadLine();
            int adults = 0;
            int kids = 0;
            int moneyForToys = 0;
            int moneyForSweaters = 0;

            while (input != "Christmas")
            {

                int yearFamilyMember = int.Parse(input);
                if (yearFamilyMember <= 16)
                {
                    kids++;
                    moneyForToys += toyPrice;
                }
                else
                {
                    adults++;
                    moneyForSweaters += sweaterPrice;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Number of adults: {adults}");
            Console.WriteLine($"Number of kids: {kids}");
            Console.WriteLine($"Money for toys: {moneyForToys}");
            Console.WriteLine($"Money for sweaters: {moneyForSweaters}");
        }
    }
}
