namespace P06_Foreign_Languages
{
    using System;
    public class Program
    {
        static void Main()
        {
            var country=Console.ReadLine();
            if (country == "USA")
            {
                Console.WriteLine("English");
            }
            else if(country == "England")
            {
                Console.WriteLine("English");
            }
            else if (country == "Spain")
            {
                Console.WriteLine("Spanish");
            }
            else if (country == "Argentina")
            {
                Console.WriteLine("Spanish");
            }
            else if (country == "Mexico")
            {
                Console.WriteLine("Spanish");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}