using System;

namespace P06_PinCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxnum1 = int.Parse(Console.ReadLine());
            int maxnum2 = int.Parse(Console.ReadLine());
            int maxnum3 = int.Parse(Console.ReadLine());

            for (int num1 = 2; num1 <= maxnum1 ; num1+=2)
            {
                for (int num2 = 2; num2 <= maxnum2 && num2 <=7; num2++)
                {
                    for (int num3 = 2; num3 <= maxnum3; num3+=2)
                    {
                        Console.WriteLine($"{num1}{num2}{num3}");
                    }
                }
            }
        }
    }
}
