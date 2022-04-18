namespace T10_Multiplication_Table
{
using System;

    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            for (int i = input; i == input; i++)
            {

                for (int j = 1; j <= 10; j++)
                {
                    int product = input * j;
                    Console.WriteLine($"{input} X {j} = {product}");
                }

            }
        }
    }
}
