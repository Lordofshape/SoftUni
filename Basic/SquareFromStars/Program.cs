using System;


namespace SquareFromStars
    
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n >= 2 || n <= 100)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.Write("*");
                    for (int c = 1; c < n; c++)
                    {
                        Console.Write(" *");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}


