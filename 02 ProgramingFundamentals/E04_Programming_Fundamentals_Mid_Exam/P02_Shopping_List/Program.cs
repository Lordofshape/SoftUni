 using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_Shopping_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine().Split("!").ToList();

            string input;
            while ((input=Console.ReadLine())!="Go Shopping!")
            {
                string[] cmdArgs = input.Split(" ");
                string cmd = cmdArgs[0];
                if (cmd == "Urgent")
                {
                    string item = cmdArgs[1];
                    if (groceries.Contains(item))
                    {
                        continue;
                    }
                    groceries.Insert(0,item);
                }
                else if (cmd == "Unnecessary")
                {
                    string item = cmdArgs[1];
                    if (!groceries.Contains(item))
                    {
                        continue;
                    }
                    groceries.Remove(item);
                }
                else if (cmd == "Correct")
                {
                    string oldItem = cmdArgs[1];
                    string newItem = cmdArgs[2];
                    if (!groceries.Contains(oldItem))
                    {
                        continue;
                    }
                    for (int i = 0; i < groceries.Count; i++)
                    {
                        if (groceries[i]==oldItem)
                        {
                            groceries[i] = newItem;
                        }
                    }
                }
                else
                {
                    string item = cmdArgs[1];
                    if (!groceries.Contains(item))
                    {
                        continue;
                    }
                    groceries.Remove(item);
                    groceries.Add(item);
                }
            }
            Console.WriteLine(string.Join(", ",groceries));
        }
    }
}
