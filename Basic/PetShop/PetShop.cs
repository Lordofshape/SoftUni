namespace PetShop
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int dogFood = int.Parse(Console.ReadLine());
            int catFood = int.Parse(Console.ReadLine());
            double dogPackages = dogFood * 2.50;
            double catPackages = catFood * 4;
            double sumFood = dogPackages + catPackages;
            Console.WriteLine($"{sumFood} lv.");
        }
    }
}
