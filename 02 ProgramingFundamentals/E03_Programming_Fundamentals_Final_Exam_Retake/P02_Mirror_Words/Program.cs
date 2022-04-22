namespace P02_Mirror_Words
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"((@|#)(?<firstWord>[A-Za-z]{3,})\2)(\2(?<secondWord>[A-Za-z]{3,})\2)";
            var mirrorWords = new List<Tuple<string, string>>();
            MatchCollection matches = Regex.Matches(input, pattern);
            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
                return;
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
                foreach (Match match in matches)
                {
                    string firstWord = match.Groups["firstWord"].Value;
                    string secondWord = string.Join("", match.Groups["secondWord"].Value.Reverse());
                    if (firstWord == secondWord)
                    {
                        secondWord = match.Groups["secondWord"].Value;
                        Tuple<string,string> tuple = Tuple.Create(firstWord, secondWord);
                        mirrorWords.Add(tuple);
                        
                    }
                }
                if (mirrorWords.Count == 0)
                {
                    Console.WriteLine("No mirror words!");
                }
                else
                {
                    Console.WriteLine("The mirror words are:");
                    for (int i = 0; i < mirrorWords.Count; i++)
                    {
                        if (i==mirrorWords.Count-1)
                        {
                            Console.Write($"{mirrorWords[i].Item1} <=> {mirrorWords[i].Item2}");
                        }
                        else
                        {
                            Console.Write($"{mirrorWords[i].Item1} <=> {mirrorWords[i].Item2}, ");
                        }
                    }
                    
                }
            }
        }
    }
}
