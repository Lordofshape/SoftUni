namespace T05_Account_Balance
{

    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string contribution = Console.ReadLine();

            double balance = 0;

            while (contribution != "NoMoreMoney")
            {
                double currentNumber = double.Parse(contribution);
                if (currentNumber < 0)
                {
                    Console.WriteLine("Invalid operation!" );
                    break;
                }
                balance += currentNumber;
                Console.WriteLine($"Increase: {currentNumber:f2}");
                contribution = Console.ReadLine();

            }
            Console.WriteLine($"Total: {balance:f2}");
        }
    }
}
