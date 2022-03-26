using System;

namespace P09_Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var students=int.Parse(Console.ReadLine());
            var priceLightsaber = double.Parse(Console.ReadLine());
            var priceRobe = double.Parse(Console.ReadLine());
            var priceBelt = double.Parse(Console.ReadLine());
            var sumBelts = students * priceBelt;
            var sumRobe = students * priceRobe;
            var sumSabers=Math.Ceiling(students * 1.10) * priceLightsaber;

            if (students>=6)
            {
                while (students>=6)
                {
                    sumBelts -= priceBelt;
                    students -= 6;
                }
            }
            var neededSum = sumBelts + sumRobe + sumSabers;
            if (money-neededSum<0)
            {
                neededSum = money - neededSum;
                Console.WriteLine($"John will need {Math.Abs(neededSum):f2}lv more.");
            }
            else
            {
                Console.WriteLine($"The money is enough - it would cost {neededSum:f2}lv.");
            }
        }
    }
}
