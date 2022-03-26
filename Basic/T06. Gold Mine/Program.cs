using System;

namespace T06._Gold_Mine
{
    class Program
    {
        static void Main(string[] args)
        {           
            int numbersOfLocation = int.Parse(Console.ReadLine());

            for (int location = 1; location <= numbersOfLocation; location++)
            {
                double minePrediction = double.Parse(Console.ReadLine());
                int mineDays = int.Parse(Console.ReadLine());
                double goldCounter = 0;
                for (int day = 1; day <= mineDays; day++)
                {
                    int minedGold = int.Parse(Console.ReadLine());
                    goldCounter += minedGold;
                }
                double averageGoldPerDay = goldCounter / mineDays;
                if (averageGoldPerDay>=minePrediction)
                {
                    Console.WriteLine($"Good job! Average gold per day: {averageGoldPerDay:f2}.");
                }
                else
                {
                    double neededGold = minePrediction - averageGoldPerDay;
                    Console.WriteLine($"You need {neededGold:f2} gold.");
                }
            }
        }
    }
}
