
namespace P04_Songs_Queue
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main(string[] args)
        {
            string[] songSequance = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);

            Queue<string> playlist = new Queue<string>();

            foreach (var song in songSequance)
            {
                playlist.Enqueue(song);
            }   
            string command;
            while (playlist.Count>0)
            {
                command=Console.ReadLine();
                if (command=="Play" && playlist.Count>0)
                {
                    playlist.Dequeue();
                    continue;
                }
                if (command=="Show" && playlist.Count>0)
                {
                    string[] vs = playlist.ToArray();
                    
                    Console.WriteLine(string.Join(", ",vs));
                    continue;
                }
                string[] songWithCommand = command.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string[] songToAdd = new string[songWithCommand.Length - 1];
                for (int i = 1; i < songWithCommand.Length; i++)
                {
                    songToAdd[i-1] = songWithCommand[i];
                }
                var song =  string.Join(" ",songToAdd);
                if (playlist.Contains(song))
                {
                    Console.WriteLine($"{song} is already contained!");
                    continue;
                }
                playlist.Enqueue(song);

            }
            Console.WriteLine("No more songs!");


        }
    }
}
