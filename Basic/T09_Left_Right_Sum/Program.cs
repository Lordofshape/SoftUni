namespace T09_Left_Right_Sum
{
using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int rightSum = 0;
            int leftSum = 0;

            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                rightSum += currentNum;
            }
            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                leftSum += currentNum;
            }

            if (rightSum==leftSum)
            {
                Console.WriteLine($" Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($" No, diff = {Math.Abs(leftSum-rightSum)}");
            }
        }
    }
}
