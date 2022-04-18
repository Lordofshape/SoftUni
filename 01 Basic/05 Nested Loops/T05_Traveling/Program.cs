using System;

namespace T05_Traveling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double budged = double.Parse(Console.ReadLine());
                double savedmoney = 0;
                while (savedmoney < budged)
                {
                    savedmoney += double.Parse(Console.ReadLine());
                }

                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}
