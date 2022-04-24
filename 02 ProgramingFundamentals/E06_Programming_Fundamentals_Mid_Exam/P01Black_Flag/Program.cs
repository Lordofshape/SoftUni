namespace P01_Black_Flag
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int plunders = int.Parse(Console.ReadLine());
            int expectedPlunder = int.Parse(Console.ReadLine());
            double totalPlunder = 0;
            for (int i = 1; i <= days; i++)
            {
                totalPlunder += plunders;
                if (i%3==0)
                {
                    totalPlunder += plunders * 0.5;
                }
                if (i%5==0)
                {
                    totalPlunder = totalPlunder * 0.7;
                }
            }
            if (totalPlunder>=expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
            }
            else
            {
                double percentage = (totalPlunder/expectedPlunder)*100;
                Console.WriteLine($"Collected only {percentage:f2}% of the plunder.");
            }
        }
    }
}
