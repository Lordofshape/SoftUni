using System;
using System.Linq;

namespace P03_Heart_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] houses = Console.ReadLine().Split("@").Select(int.Parse).ToArray();
            int cupidIndex = 0;
            string cmd;
            while ((cmd=Console.ReadLine())!="Love!")
            {
                string[] cmdArgs = cmd.Split();
                int jumpLength = int.Parse(cmdArgs[1]);
                cupidIndex += jumpLength;
                if (cupidIndex>=houses.Length)
                {
                    cupidIndex = 0;
                }
                if (houses[cupidIndex]>0)
                {
                    houses[cupidIndex] -= 2;
                    if (houses[cupidIndex]==0)
                    {
                        Console.WriteLine($"Place {cupidIndex} has Valentine's day.");
                    }
                }
                else
                {
                    Console.WriteLine($"Place {cupidIndex} already had Valentine's day.");
                }
            }
            Console.WriteLine($"Cupid's last position was {cupidIndex}.");
            int houseCounter = 0;
            for (int i = 0; i < houses.Length; i++)
            {
                if (houses[i]>0)
                {
                    houseCounter++;
                }
            }
            if (houseCounter>0)
            {
                Console.WriteLine($"Cupid has failed {houseCounter} places.");
            }
            else
            {
                Console.WriteLine("Mission was successful.");
            }
        }
    }
}
