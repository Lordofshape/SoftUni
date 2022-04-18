namespace Fish_Tank
{
using System;

    class Program
    {
        static void Main(string[] args)
        {
           //Input 
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());
            //Logic
            double volumeTank = lenght * width * height;
            double volumeLitters = volumeTank * 0.001;
            double usedSpace = procent / 100;
            //Output
            double littersWater = volumeLitters * (1 - usedSpace);
            Console.WriteLine(littersWater);
           


        }
    }
}
