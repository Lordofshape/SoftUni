using System;
using System.Collections.Generic;

namespace P01_HeroRecruitment
{
    internal class Program
    {
        public class Hero
        {
            public Hero(string name)
            {
                this.Name = name;
                this.SpellBook = new List<string>();
            }
            public string Name { get; set; }
            public List<string> SpellBook { get; set; }
        }
        static void Main(string[] args)
        {
            Dictionary<string,List<string>> heroes = new Dictionary<string,List<string>>();
            string input;
            while ((input=Console.ReadLine())!="End")
            {
                string[] commandArgs = input.Split();
                string command = commandArgs[0];
                string heroName = commandArgs[1];

                if (command=="Enroll")
                {
                    if (heroes.ContainsKey(heroName))
                    {
                        Console.WriteLine($"{heroName} is already enrolled.");
                    }
                    else
                    {
                        heroes.Add(heroName, new List<string>());
                    }
                }
                else if (command == "Learn")
                {
                    string spellName = commandArgs[2];
                    if (!heroes.ContainsKey(heroName))
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                        continue;
                    }
                    if (heroes[heroName].Contains(spellName))
                    {
                        Console.WriteLine($"{heroName} has already learnt {spellName}.");
                        continue;
                    }
                    heroes[heroName].Add(spellName);
                }
                else if (command == "Unlearn")
                {
                    string spellName = commandArgs[2];
                    if (!heroes.ContainsKey(heroName))
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                        continue;
                    }
                    if (!heroes[heroName].Contains(spellName))
                    {
                        Console.WriteLine($"{heroName} doesn't know {spellName}.");
                        continue;
                    }
                    heroes[heroName].Remove(spellName);
                }
            }
            PrintHeroes(heroes);
        
        }
        public static void PrintHeroes(Dictionary<string,List<string>> heroes)
        {
            Console.WriteLine("Heroes:");
            foreach (var hero in heroes)
            {
                Console.WriteLine($"== {hero.Key}: {string.Join(", ", hero.Value)}");
            }
        }
    }
}
