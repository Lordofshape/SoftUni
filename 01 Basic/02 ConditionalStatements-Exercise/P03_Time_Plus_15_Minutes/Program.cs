using System;

namespace P03_Time_Plus_15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            min += 15;
            if (min>=60)
            {
                min -= 60;
                hour += 1;
            }

            if (hour>=24)
            {
                hour = 0;
            }

            Console.WriteLine($"{hour}:{min:d2}");
        }
    }
}
