using System;

namespace T03_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int combinations = 0;

            for (int num1 = 0; num1 <= n; num1++)
            {
                int counter = 0;
                for (int num2 = 0; num2 <= n; num2++)
                {
                    for (int num3 = 0; num3 <= n; num3++)
                    {
                        counter = num1 + num2 + num3;
                        if (counter==n)
                        {
                            combinations++;
                        }
                    }
                }
            }

            Console.WriteLine(combinations);
        }
    }
}
