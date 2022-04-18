using System;

namespace P10_Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lostGameCount = int.Parse(Console.ReadLine());
            var headsetPrice = double.Parse(Console.ReadLine());
            var mousePrice = double.Parse(Console.ReadLine());
            var keyboardPrice = double.Parse(Console.ReadLine());
            var displayPrice = double.Parse(Console.ReadLine());
            var headsetCount = lostGameCount/2;
            var mouseCount = lostGameCount/3;
            var keyboardCount = 0;

            while (lostGameCount>=6)
            {
                keyboardCount++;
                lostGameCount -= 6;
            }
            var displayCount = keyboardCount/2;
            var expenses = (headsetCount * headsetPrice)+(mouseCount*mousePrice)+(keyboardCount*keyboardPrice)+(displayCount * displayPrice);
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");

        }
    }
}
