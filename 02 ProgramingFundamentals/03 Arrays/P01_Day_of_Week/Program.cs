using System;

namespace P01_Day_of_Week
{
    internal class Program
    {
        static void Main()
        {
            string[] arr =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            int num = int.Parse(Console.ReadLine());
            if (1 <= num && num <= arr.Length)
            {
                Console.WriteLine(arr[num - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
