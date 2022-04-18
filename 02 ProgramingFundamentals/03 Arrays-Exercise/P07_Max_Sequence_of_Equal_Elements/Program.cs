using System;
using System.Linq;

namespace P07_Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                       .Split()
                       .Select(int.Parse)
                       .ToArray();
            int counter = 0;
            int winningCounter = 0;
            int number = numbers[0];

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    counter++;
                    if (counter > winningCounter)
                    {
                        winningCounter = counter;
                        number = numbers[i];
                    }
                }
                else
                {
                    counter = 0;
                }
            }
            for (int i = 0; i <= winningCounter; i++)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
