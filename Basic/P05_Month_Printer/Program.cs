namespace P05_Month_Printer
{
    using System;
    public class Program
    {
        static void Main()
        {
            var month = int.Parse(Console.ReadLine());
            if (month <= 12 && month>0)
            {
                if (month==1)
                {
                    Console.WriteLine("January");
                }
                else if (month == 2)
                {
                    Console.WriteLine("February");
                }
                else if (month == 3)
                {
                    Console.WriteLine("March");

                }
                else if (month == 4)
                {
                    Console.WriteLine("April");
                }
                else if (month == 5)
                {
                    Console.WriteLine("May");

                }
                else if (month == 6)
                {
                    Console.WriteLine("June");
                }
                else if (month == 7)
                {
                    Console.WriteLine("June");
                }
                else if (month == 8)
                {
                    Console.WriteLine("August");
                }
                else if (month == 9)
                {
                    Console.WriteLine("August");
                }
                else if (month == 10)
                {
                    Console.WriteLine("October");
                }
                else if (month == 11)
                {
                    Console.WriteLine("November");
                }
                else
                {
                    Console.WriteLine("Decembe");
                }
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}