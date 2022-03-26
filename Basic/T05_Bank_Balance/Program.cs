namespace T05_Bank_Balance
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string deposit = Console.ReadLine();
            double balance = 0;

            while (deposit != "NoMoreMoney")
            {
                double currDeposit = double.Parse(deposit);
                if (currDeposit > 0)
                {
                    balance += currDeposit;
                    Console.WriteLine($"Increase: {currDeposit}");
                }
                else
                {
                    Console.WriteLine("Invalid operation!");
                    Console.WriteLine($"Total: {balance:f2}");
                    break;
                }
                deposit = Console.ReadLine();
            }
            if (deposit == "NoMoreMoney")
            {
                Console.WriteLine($"Total: {balance:f2}");
            }
        }
    }
}
