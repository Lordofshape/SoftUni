namespace P09_Sum_of_Odd_Numbers
{
    using System;
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            for (int i = 0; i < n; i++)
            {
                var currentnum = 1 + (i * 2);
                sum+=currentnum;
                Console.WriteLine(currentnum);
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
