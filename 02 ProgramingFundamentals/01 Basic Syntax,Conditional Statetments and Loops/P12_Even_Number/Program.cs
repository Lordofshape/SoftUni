namespace P12_Even_Number
{
    using System;
    public class Program
    {
        static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            while (num  % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");
                num=int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The number is: {Math.Abs(num)}");
        }
    }
}