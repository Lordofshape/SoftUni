namespace Project_Creation
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string Name = Console.ReadLine();
            int project = int.Parse(Console.ReadLine());
            int hoursneed = project * 3;
            Console.WriteLine($"The architect {Name} will need {hoursneed} hours to complete {project} project/s.");

        }
    }
}
