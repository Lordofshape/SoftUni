using System;

namespace P01_Train
{
    internal class Program
    {
        static void Main()
        {
            int wagonsNumber = int.Parse(Console.ReadLine());
            int[] wagons = new int[wagonsNumber];
            var sum = 0;
            for (int i = 0; i < wagons.Length; i++)
            {
                var passengers = int.Parse(Console.ReadLine());
                sum += passengers;
                wagons[i] = passengers;
            }
            Console.WriteLine(string.Join(" ", wagons));
            Console.WriteLine(sum);
        }
    }
}
