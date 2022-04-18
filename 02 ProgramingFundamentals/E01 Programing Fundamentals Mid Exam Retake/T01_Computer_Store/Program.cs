using System;
using System.Collections.Generic;
using System.Linq;

namespace T01_Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            string command;
            bool flag = false;
            List<double> componentsPrice = new List<double>();

            while ((command = Console.ReadLine()) != string.Empty)
            {
                if (command == "regular")
                {
                    break;
                }
                else if (command == "special")
                {
                    flag = true;
                    break;
                }
                double componentPrice = double.Parse(command);
                if (componentPrice < 0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }
                componentsPrice.Add(double.Parse(command));

            }
            double priceWithTaxes = componentsPrice.Sum() * 1.2;
            double taxes = componentsPrice.Sum() * 0.2;
            if (flag)
            {
                priceWithTaxes = priceWithTaxes * 0.9;
            }
            if (componentsPrice.Sum() == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {componentsPrice.Sum():f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {priceWithTaxes:f2}$");
            }
        }
    }
}
