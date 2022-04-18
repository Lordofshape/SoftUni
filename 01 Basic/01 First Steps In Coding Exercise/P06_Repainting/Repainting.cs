namespace Repainting
{
    using System;

    class Program
    {

        static void Main(string[] args)
        {
            //Input
            int naylon = int.Parse(Console.ReadLine());
            int dry = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int hoursWork = int.Parse(Console.ReadLine());

            //Logic
            double sumNaylon = (naylon + 2) * 1.50;
            double sumBags = 0.40;
            double sumDry = (dry * 1.10) * 14.50;
            double sumThinner = thinner * 5;
            double sumMaterials = sumNaylon + sumBags + sumDry + sumThinner;
            double sumCraftsman = (sumMaterials * 0.3) * 8;
            double finalSum = sumMaterials + sumCraftsman;

            Console.WriteLine(finalSum);

        }
    }
}
