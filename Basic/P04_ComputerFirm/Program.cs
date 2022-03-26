using System;

namespace P04_ComputerFirm
{
    class Program
    {
        static void Main(string[] args)
        {
            //Взимане на последната цифра от int и първите 2 цифри или определена цифра
            /* 
            int raiting = int.Parse(Console.ReadLine());
            int lastDigit = raiting % 10;
            int start = Convert.ToInt32(raiting.ToString().Substring(0,2));
           .*/

            int numComputers = int.Parse(Console.ReadLine());
            double numOfSales = 0;
            int counter = 0;

            for (int i = 0; i < numComputers; i++)
            {
                int salesRaiting = int.Parse(Console.ReadLine());

                int raiting = salesRaiting % 10;
                counter += raiting;
                int salesPredicition = Convert.ToInt32(salesRaiting.ToString().Substring(0, 2));
                if (raiting==2)
                {
                    numOfSales += 0;
                }
                else if (raiting==3)
                {
                    numOfSales += (salesPredicition * 1.0) / 2;
                }
                else if (raiting==4)
                {
                    numOfSales += (salesPredicition * 1.0) * 0.7;
                }
                else if (raiting==5)
                {
                    numOfSales += (salesPredicition * 1.0) * 0.85;
                }
                else if (raiting==6)
                {
                    numOfSales += salesPredicition;
                }
            }
            double averageRaiting = (counter*1.0) / numComputers;
            Console.WriteLine($"{numOfSales:f2}");
            Console.WriteLine($"{averageRaiting:f2}");

        }
    }
}
