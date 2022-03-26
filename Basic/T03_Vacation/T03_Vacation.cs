namespace T03_Vacation
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double neededVacationMoney = double.Parse(Console.ReadLine());
            double currMoney = double.Parse(Console.ReadLine());

            int days = 0;
            int spentCount = 0;

            while (spentCount != 5)
            {
                string input = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                days++;

                if (input == "save")
                {
                    spentCount = 0;
                    currMoney += money;
                }
                else if (input == "spend")
                {
                    spentCount++;
                    if (money > currMoney)
                    {
                        currMoney = 0;
                    }
                    else
                    {
                        currMoney -= money;
                    }
                }
                if (currMoney >= neededVacationMoney)
                {
                    Console.WriteLine($"You saved the money for {days} days.");
                    break;
                }
            }
            if (spentCount == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{days}");
            }
        }
    }
}
