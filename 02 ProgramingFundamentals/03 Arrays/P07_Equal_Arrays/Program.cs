using System;
using Linq;

namespace P07_Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arrayOne = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var arrayTwo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var sum = 0;

            for (int i = 0; i < arrayOne.Length; i++)
            {
                if (arrayOne[i] != arrayTwo[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
                else
                {
                    sum += arrayOne[i];
                }
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
