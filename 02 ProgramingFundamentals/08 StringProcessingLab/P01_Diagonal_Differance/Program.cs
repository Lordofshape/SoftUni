using System;
using System.Linq;

namespace P01_Diagonal_Differance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rowCol = int.Parse(Console.ReadLine());
            var matrix = new int[rowCol, rowCol];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] inputRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] = inputRow[j];
                }
            }
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                leftSum+=matrix[i,i];
                rightSum+=matrix[i, matrix.GetLength(1) - 1-i];
            }
            Console.WriteLine(Math.Abs(leftSum-rightSum));
        }
    }
}
