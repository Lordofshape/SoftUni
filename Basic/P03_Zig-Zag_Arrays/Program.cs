using System;
using System.Linq;

namespace P03_Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int[] arr2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] currentNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int firstNumber = currentNumbers[0];
                int secondNumber = currentNumbers[1];

                if (i % 2 == 0)
                {
                    arr[i] = firstNumber;
                    arr2[i] = secondNumber;
                }
                else
                {
                    arr[i] = secondNumber;
                    arr2[i] = firstNumber;
                }

            }

            Console.WriteLine(string.Join(" ", arr));
            Console.WriteLine(string.Join(" ", arr2));
        }
    }
}
