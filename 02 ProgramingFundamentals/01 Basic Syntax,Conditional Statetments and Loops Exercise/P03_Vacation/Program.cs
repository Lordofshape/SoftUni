namespace P03_Vacation
{
    using System;
    public class Program
    {
        static void Main()
        {
            int people=int.Parse(Console.ReadLine());
            var group=Console.ReadLine();
            var day=Console.ReadLine();
            var price = 0.0;

            if (group == "Business" && people >= 100)
                {
                    people = people - 10;
                }
            if (day == "Friday")
            {
                if(group == "Students")
                {
                    price = 8.45 * people;
                }
                else if(group == "Business")
                {
                    price = 10.90 * people;
                }
                else if (group == "Regular")
                {
                    price = 15 * people;
                }
            }
            else if (day == "Saturday")
            {
                if (group == "Students")
                {
                    price = 9.80 * people;
                }
                else if (group == "Business")
                {
                    price = 15.60 * people;
                }
                else if (group == "Regular")
                {
                    price = 20 * people;
                }

            }
            else if(day == "Sunday")
            {
                if (group == "Students")
                {
                    price = 10.46 * people;
                }
                else if (group == "Business")
                {
                    price = 16 * people;
                }
                else if (group == "Regular")
                {
                    price = 22.50 * people;
                }
            }

            if (group == "Students" && people >= 30)
            {
                price *= 0.85;
            }
            else if(group=="Regular" && people >= 10 && people <= 20)
            {
                price *= 0.95;
            }

            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}