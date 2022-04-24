namespace P03_Man_O_War
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] pirateShip = Console.ReadLine().Split('>').Select(int.Parse).ToArray();

            int[] warship = Console.ReadLine().Split('>').Select(int.Parse).ToArray();

            int maxHealth = int.Parse(Console.ReadLine());

            string input;

            while ((input=Console.ReadLine())!= "Retire")
            {
                string[] cmdArgs = input.Split();
                string cmd = cmdArgs[0];
                if (cmd == "Fire")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int damage = int.Parse(cmdArgs[2]);
                    if (index<0 || index>=warship.Length)
                    {
                        continue;
                    }
                    warship[index] -= damage;
                    if (warship[index]<=0)
                    {
                        Console.WriteLine("You won! The enemy ship has sunken.");
                        return;
                    }
                }
                else if (cmd == "Defend")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);
                    int damage = int.Parse(cmdArgs[3]);
                    if (startIndex<0 || endIndex>pirateShip.Length-1 || startIndex>endIndex || startIndex > pirateShip.Length - 1)
                    {
                        continue;
                    }
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        pirateShip[i] -= damage;
                        if (pirateShip[i]<=0)
                        {
                            Console.WriteLine("You lost! The pirate ship has sunken.");
                            return;
                        }
                    }
                }
                else if (cmd == "Repair")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int health = int.Parse(cmdArgs[2]);
                    if (index < 0 || index > pirateShip.Length - 1)
                    {
                        continue;
                    }
                    int requiredHealth = maxHealth - pirateShip[index];
                    if (health>requiredHealth)
                    {
                        pirateShip[index] += requiredHealth;
                    }
                    else
                    {
                        pirateShip[index] += health;
                    }
                }
                else
                {
                    double percentage = maxHealth * 0.2;
                    int count = pirateShip.Where(x => x < percentage).Count();
                    Console.WriteLine($"{count} sections need repair.");
                }
            }
            int pirateShipStatus = 0;
            for (int i = 0; i < pirateShip.Length; i++)
            {
                pirateShipStatus += pirateShip[i];
            }
            Console.WriteLine($"Pirate ship status: {pirateShipStatus}");
            int warshipStatus = 0;
            for (int i = 0; i < warship.Length; i++)
            {
                warshipStatus += warship[i];
            }
            Console.WriteLine($"Warship status: {warshipStatus}");
        }
    }
}
