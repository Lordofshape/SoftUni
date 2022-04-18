using System;

namespace T02._Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sumOfNums = 0;
            int maxNum = int.MinValue;

            for (int i = 0; i < num; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                sumOfNums += currentNum;
                if (maxNum<currentNum)
                {
                    maxNum = currentNum;
                }
            }
            int sumWithoutMaxNum = sumOfNums - maxNum;
            int differance = maxNum - sumWithoutMaxNum;
            if (sumWithoutMaxNum==maxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(differance)}");
            }
        }
    }
}
