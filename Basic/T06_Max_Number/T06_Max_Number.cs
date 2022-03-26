namespace T06_Max_Number
{
using System;
using System.Linq;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            List <int> numbers = new List<int>();
            string input = Console.ReadLine();

            while (input != "Stop")
            {
                int currentNumber = int.Parse(input);
                numbers.Add(currentNumber);
                input = Console.ReadLine();
            }


            Console.WriteLine(numbers.Max());
        }
    }
}
