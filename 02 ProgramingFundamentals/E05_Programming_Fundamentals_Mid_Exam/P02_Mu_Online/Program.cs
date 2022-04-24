namespace P02_Mu_Online
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxHealth = 100;
            int health = 100;
            int bitcoins = 0;
            string[] rooms = Console.ReadLine().Split("|");
            for (int i = 0; i < rooms.Length; i++)
            {
                string[] cmdNumber = rooms[i].Split();
                string cmd = cmdNumber[0];
                if (cmd== "potion")
                {
                    int requiredHealth = MaxHealth - health;
                    int heal = int.Parse(cmdNumber[1]);
                    if (heal>=requiredHealth)
                    {
                        health += requiredHealth;
                        Console.WriteLine($"You healed for {requiredHealth} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                    else
                    {
                        health += heal;
                        Console.WriteLine($"You healed for {heal} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                }
                else if (cmd == "chest")
                {
                    int amount = int.Parse(cmdNumber[1]);
                    bitcoins += amount;
                    Console.WriteLine($"You found {amount} bitcoins.");
                }
                else
                {
                    int damage = int.Parse(cmdNumber[1]);
                    health -= damage;
                    if (health>0)
                    {
                        Console.WriteLine($"You slayed {cmd}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {cmd}.");
                        Console.WriteLine($"Best room: {i+1}");
                        return;
                    }
                }
            }
            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
