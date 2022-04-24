namespace P03_Inventory
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine().Split(", ").ToList();
            string input;
            while ((input = Console.ReadLine()) != "Craft!")
            {
                string[] parts = input.Split(" - ");
                string cmd = parts[0];
                if (cmd== "Collect")
                {
                    string item = parts[1];
                    if (inventory.Contains(item))
                    {
                        continue;
                    }
                    inventory.Add(item);
                }
                else if (cmd == "Drop")
                {
                    string item = parts[1];
                    if (!inventory.Contains(item))
                    {
                        continue;
                    }
                    inventory.Remove(item);
                }
                else if (cmd == "Combine Items")
                {
                    string[] items = parts[1].Split(":");
                    string oldItem = items[0];
                    if (inventory.Contains(oldItem))
                    {
                        string newItem = items[1];
                        int index = inventory.IndexOf(oldItem)+1;
                        inventory.Insert(index, newItem);
                    }
                }
                else
                {
                    string item = parts[1];
                    if (inventory.Contains(item))
                    {
                        inventory.Remove(item);
                        inventory.Add(item);
                    }
                }
            }
            Console.WriteLine(string.Join(", ",inventory));
        }
    }
}
