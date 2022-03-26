namespace T05_Cake
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int pieces = height * lenght;
            string input = Console.ReadLine();

            while (input != "STOP")
            {
                int currPieces = int.Parse(input);
                pieces -= currPieces;
                if (pieces < 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(pieces)} pieces more.");
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "STOP")
            {
                Console.WriteLine($"{pieces} pieces are left.");
            }
        }
    }
}
