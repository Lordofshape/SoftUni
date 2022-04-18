using System;

namespace P02_Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lengthArray = int.Parse(Console.ReadLine());
            int[] array = new int[lengthArray];


            for (int i = 0; i < array.Length; i++)
            {
                int number = int.Parse(Console.ReadLine());
                array[i] = number;
            }
            Array.Reverse(array);
            Console.WriteLine(string.Join(" ", array));

        }
    }
}
