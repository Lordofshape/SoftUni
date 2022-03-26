using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_Truck_Tour
{
    internal class Program
    {
       
       

        public static void Main(string[] args)
        {

            int entries = int.Parse(Console.ReadLine());
           Queue<int[]> pumps = new Queue<int[]>();

            for (int entry = 0; entry < entries; entry++)
            {
                int[] pump = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                pumps.Enqueue(pump);
            }
                

            for (int entry = 0; entry < entries; entry++)
            {
                if (IsSolution(entries,pumps)==false)
                {
                    int[] startingPump = pumps.Dequeue();
                    pumps.Enqueue(startingPump);
                    continue;
                }
                Console.WriteLine(entry);
                break;
            }

        }

        static bool IsSolution(int entries, Queue<int[]> pumps)
        {
            int tankFuel = 0;
            bool foundAnswer = true;

            for (int entry = 0; entry < entries; entry++)
            {
                int[] currPump = pumps.Dequeue();
                tankFuel += currPump[0] - currPump[1];
                if (tankFuel < 0)
                {
                    foundAnswer = false;
                }
                pumps.Enqueue(currPump);
            }

            if (foundAnswer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

