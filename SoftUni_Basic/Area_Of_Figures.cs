namespace Area_of_Figures
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if (figure=="square")
            {
                double sidesquare = double.Parse(Console.ReadLine());
                Console.WriteLine($"{sidesquare*sidesquare:F3}");

            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine($"{Math.PI*(radius*radius):F3}");
            }
            else if (figure == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                Console.WriteLine($"{sideA * sideB:F3}");
            }
            else if (figure == "triangle")
            {
                double lenght = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine($"{(height*lenght)/2:F3}");
            }
        }
    }
}
