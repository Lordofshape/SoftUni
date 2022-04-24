namespace P02_Treasure_Hunt
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> treasure = Console.ReadLine().Split('|').ToList();
            string input;
            while ((input=Console.ReadLine())!= "Yohoho!")
            {
                string[] cmdArgs = input.Split();
                string cmd = cmdArgs[0];
                if (cmd=="Loot")
                {
                    for (int i = 1; i < cmdArgs.Length; i++)
                    {
                        if (treasure.Contains(cmdArgs[i]))
                        {
                            continue;
                        }
                        treasure.Insert(0,cmdArgs[i]);
                    }
                }
                else if (cmd== "Drop")
                {
                    int index = int.Parse(cmdArgs[1]);
                    if (index<0 || index>=treasure.Count)
                    {
                        continue;
                    }
                    string item = treasure[index];
                    treasure.RemoveAt(index);
                    treasure.Add(item);
                }
                else
                {
                    List<string> stolenItems = new List<string>();
                    int count = int.Parse(cmdArgs[1]);
                    if (count>=treasure.Count)
                    {
                        for (int i = 0; i < treasure.Count; i++)
                        {
                            stolenItems.Add(treasure[i]);
                        }
                        treasure.Clear();
                    }
                    else
                    {
                        for (int  i = 1;  i <= count;  i++)
                        {
                            stolenItems.Add(treasure[treasure.Count - i]);
                        }
                       int indexToRemove = treasure.Count - count;
                       treasure.RemoveRange(indexToRemove, count);
                       stolenItems.Reverse();
                    }
                    Console.WriteLine(string.Join(", ",stolenItems));
                }
            }
            if (treasure.Count==0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                double sum = 0;
                for (int i = 0; i < treasure.Count; i++)
                {
                    sum += treasure[i].Length;
                }
                sum = sum/treasure.Count;
                Console.WriteLine($"Average treasure gain: {sum:f2} pirate credits.");
            }
        }
    }
}
