namespace T10_Odd_Even_Sum
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddNum = 0;
            int evenNum = 0;

            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenNum += currentNum;
                }
                else
                {
                    oddNum += currentNum;
                }
            }
            if (oddNum == evenNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {oddNum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(oddNum - evenNum)}");
            }
        }
    }
}
