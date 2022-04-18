namespace T06_Moving
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int freeSpaceLenght = int.Parse(Console.ReadLine());
            int freeSpaceHeight = int.Parse(Console.ReadLine());
            int freeSpaceWidth = int.Parse(Console.ReadLine());
            int freeSpace = freeSpaceHeight * freeSpaceLenght * freeSpaceWidth;

            string boxes = Console.ReadLine();

            while (boxes!="Done")
            {
                int currboxes = int.Parse(boxes);
                freeSpace -= currboxes;
                if (freeSpace<0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more.");
                    break;
                }
                boxes = Console.ReadLine();
            }
            if (boxes=="Done")
            {
                Console.WriteLine($"{freeSpace} Cubic meters left.");
            }
        }
    }
}
