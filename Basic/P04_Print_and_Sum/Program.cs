namespace P04_Print_and_Sum
{
    using System;
    public class Program
    {
        static void Main()
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = startNumber; i <= endNumber; i++)
            {
                Console.Write(i);
                Console.Write(" ");
                sum += i;
            }
            Console.WriteLine("");
            Console.Write($"Sum: {sum}");
        }
    }
}