using System;
using System.Linq;

namespace P04_Array_Rotation
{
    internal class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int firstEl = array[0];
                for (int j = 0; j < array.Length - 1; j++)
                {
                    array[j] = array[j + 1];
                }
                array[^1] = firstEl;
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
