namespace T10_Multiplication_Table
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var theInteger = int.Parse(Console.ReadLine());
            var times = int.Parse(Console.ReadLine());
            if (times <= 10)
            {
                for (int i = times; i <= 10; i++)
                {
                    int product = theInteger * i;
                    Console.WriteLine($"{theInteger} X {i} = {product}");
                }
            }
            else
            {
                int product = theInteger * times;
                Console.WriteLine($"{theInteger} X {times} = {product}");
            }
        }
    }
}
