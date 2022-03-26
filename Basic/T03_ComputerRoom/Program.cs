using System;

namespace T03_ComputerRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            /*            • На първия ред - месецът - текст с възможности: "march", "april", "may", "june", "july", "august"
            • На втория ред - броят на прекараните часове - цяло число в диапазона[1...10]
            • На третия ред - броят на хората в групата -цяло число в диапазона[1...10]
            • На четвъртия ред - времето от деня – текст с възможности: "day" или "night"
            Март до Май day -10.50 лв/ч        Юни до Август-12.60 лв/ч night-10.20 лв/ч
            night -8.40 лв/ч 
            */

            string month = Console.ReadLine();
            int spendHour = int.Parse(Console.ReadLine());
            int peopleGroupNum = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            double sum = 0;

            if (month=="march"|| month=="april"||month=="may")
            {
                if (time=="day")
                {
                    sum += 10.50 * spendHour;
                }
                else if (time=="night")
                {
                    sum += 8.40 * spendHour;
                }
            }
            else if (month=="june"||month=="july"||month=="august")
            {
                if (time=="day")
                {
                    sum += 12.60 * spendHour;
                }
                else if (time=="night")
                {
                    sum += 10.20 * spendHour;
                }
            }
            if (peopleGroupNum>=4)
            {
                sum *= 0.9;
            }
            if (spendHour>=5)
            {
                sum *= 0.5;
            }
            double totalPrice = sum * peopleGroupNum;
            double pricePerPerson = (totalPrice / peopleGroupNum)/spendHour;
            Console.WriteLine($"Price per person for one hour: {pricePerPerson:f2}");
            Console.WriteLine($"Total cost of the visit: {totalPrice:f2}");

        }
    }
}
