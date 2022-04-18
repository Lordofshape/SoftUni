using System;

namespace P03_SantasHoliday
{
    class Program
    {
        static void Main(string[] args)
        {
            int stayDays = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string rating = Console.ReadLine();
            int stayNights = stayDays - 1;
            double price = 0;

            switch (room)
            {
                case "room for one person":
                    price = 18 * stayNights;
                    
                    break;
                case "apartment":
                    price = 25 * stayNights;
                    if (stayDays<10)
                    {
                        double discount = price * 0.3;
                        price -= discount;
                            break;
                    }
                    else if (stayDays<=15)
                    {
                        double discount = price * 0.35;
                        price -= discount;
                        break;
                    }
                    else if (stayDays>15)
                    {
                        double discount = price * 0.5;
                        price -= discount;
                        break;
                    }
                    break;
                case "president apartment":
                    price = 35 * stayNights;
                    if (stayDays < 10)
                    {
                        double discount = price * 0.1;
                        price -= discount;
                        break;
                    }
                    else if (stayDays <= 15)
                    {
                        double discount = price * 0.15;
                        price -= discount;
                        break;
                    }
                    else if (stayDays > 15)
                    {
                        double discount = price * 0.2;
                        price -= discount;
                        break;
                    }
                    break;



            }
            if (rating == "positive")
            {
                double tip = price * 0.25;
                price += tip;
                Console.WriteLine($"{price:f2}");
            }
            else if (rating == "negative")
            {
                double discount = price * 0.10;
                price -= discount;
                Console.WriteLine($"{price:f2}");
            }
        }
    }
}
