namespace DepositCalculator
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {

            double deposit = double.Parse(Console.ReadLine());
            int termOfTheDeposit = int.Parse(Console.ReadLine());
            double interecStrate = double.Parse(Console.ReadLine());
            double interestPaid = deposit * (interecStrate / 100);
            double interestOneMonth = interestPaid / 12;
            double finalSum = deposit + termOfTheDeposit * interestOneMonth;
            Console.WriteLine(finalSum);
        }
    }
}
