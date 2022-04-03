using System;
using System.Text.RegularExpressions;

namespace P02_BossRush
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Regex regex = new Regex(@"\|(?<name>[A-Z]{4,})\|:\#(?<title>[A-Za-z]+ [A-Za-z]+)#");
                Match match = regex.Match(input);
                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string title = match.Groups["title"].Value;
                    int strength = name.Length;
                    int armor = title.Length;
                    Console.WriteLine(@$"{name}, The {title}
>> Strength: {strength}
>> Armor: {armor}");
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }
            }
        }
    }
}
