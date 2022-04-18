using System;
using System.Linq;

namespace P06_Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var evenNumbers = 0;
            var oddNumbers = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbers += numbers[i];
                }
                else
                {
                    oddNumbers += numbers[i];
                }
            }
            Console.WriteLine(evenNumbers - oddNumbers);
        }
    }
}
