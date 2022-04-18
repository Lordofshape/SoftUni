using System;
using System.Linq;

namespace T02_The_Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int[] wagons = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < wagons.Length; i++)
            {
                if (people >= 0)
                {
                    while (wagons[i] < 4 && people != 0)
                    {
                        people--;
                        wagons[i] += 1;
                    }
                }
                else
                {
                    return;
                }
            }
            if (people > 0)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");

            }

            if (wagons[^1] < 4)
            {
                Console.WriteLine("The lift has empty spots!");
            }
            Console.WriteLine(String.Join(" ", wagons));
        }
    }
}
