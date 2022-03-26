using System;

namespace P01_EnterEvenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            while (true)
            {
                input = Console.ReadLine();
                int number;
                bool succes = int.TryParse(input, out number );
                if (succes)
                {
                    if (number%2==0)
                    {
                        Console.WriteLine(number);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid number!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid number");
                }
            }
        }
    }
}
