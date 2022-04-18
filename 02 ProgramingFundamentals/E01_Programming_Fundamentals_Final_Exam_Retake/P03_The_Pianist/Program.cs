using System;
using System.Collections.Generic;

namespace P03_The_Pianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,Tuple<string,string>> dic = new Dictionary<string,Tuple<string,string>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] song = Console.ReadLine().Split("|");
                var composerKey = Tuple.Create(song[1],song[2]);
                dic.Add(song[0], composerKey);
            }
            string input;
            while ((input=Console.ReadLine())!="Stop")
            {
                string[] cmdArgs = input.Split("|");
                string cmd = cmdArgs[0];
                string piece = cmdArgs[1];
                if (cmd=="Add")
                {
                    if (dic.ContainsKey(piece))
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                    else
                    {
                        Tuple<string, string> composerKey = Tuple.Create(cmdArgs[2], cmdArgs[3]);
                        dic.Add(piece, composerKey);
                        Console.WriteLine($"{piece} by {cmdArgs[2]} in {cmdArgs[3]} added to the collection!");
                    }
                }
                else if (cmd == "Remove")
                {
                    if (dic.ContainsKey(piece))
                    {
                        dic.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                else
                {
                    if (dic.ContainsKey(piece))
                    {
                        string newKey = cmdArgs[2];
                        Tuple<string, string> composerKey = Tuple.Create(dic[piece].Item1, newKey);
                        dic[piece] = composerKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                
            }
            foreach (var song in dic)
            {
                Console.WriteLine($"{song.Key} -> Composer: {song.Value.Item1}, Key: {song.Value.Item2}");
            }
        }
    }
}
