using System;

namespace T04._Cat_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ако котката изяжда от 100(вкл.) до 200 грама, то тя попада в група 1: малки котки.
• Ако котката изяжда от 200(вкл.) до 300 грама, то тя попада в група 2: големи котки.
• Ако котката изяжда от 300(вкл.) до 400 грама, то тя попада в група 3: огромни котки*/
            double foodPrice = 12.45;
            int numsOfCats = int.Parse(Console.ReadLine());
            int foodCounter = 0;
            int group1 = 0;
            int group2 = 0;
            int group3 = 0;

            for (int cat = 1; cat <= numsOfCats; cat++)
            {
                int eatenCatFood = int.Parse(Console.ReadLine());
                foodCounter += eatenCatFood;
                if (eatenCatFood<200)
                {
                    group1++;
                }
                else if (eatenCatFood<300)
                {
                    group2++;
                }
                else if (eatenCatFood<400)
                {
                    group3++;
                }
            }
            double totalPriceForFood = foodCounter*1.0 / 1000;
            double total = totalPriceForFood * foodPrice;
            Console.WriteLine($"Group 1: {group1} cats.");
            Console.WriteLine($"Group 2: {group2} cats.");
            Console.WriteLine($"Group 3: {group3} cats.");
            Console.WriteLine($"Price for food per day: {total:f2} lv.");

        }
    }
}
