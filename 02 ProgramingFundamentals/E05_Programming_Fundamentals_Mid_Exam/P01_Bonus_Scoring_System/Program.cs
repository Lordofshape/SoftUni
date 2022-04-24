namespace P01_Bonus_Scoring_System
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberStudents = int.Parse(Console.ReadLine());
            int totalLecture = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());
            double bestStudent = 0;
            double totalBonus = 0;
            for (int i = 0; i < numberStudents; i++)
            {
                double attedance = double.Parse(Console.ReadLine());
                double currBonus = attedance / totalLecture * (5 + additionalBonus);
                if (currBonus > totalBonus)
                {
                    bestStudent = attedance;
                    totalBonus = currBonus;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Round(totalBonus)}.");
            Console.WriteLine($"The student has attended {bestStudent} lectures.");
        }
    }
}
