using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_HeroRecruitmentWithClass
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

        public override string ToString()
        {
            return $"== {this.Name}: {string.Join(", ", SpellBook)}"; 
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<Hero> heroes = new List<Hero>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] commandArgs = input.Split();
                string command = commandArgs[0];
                string heroName = commandArgs[1];

                if (command == "Enroll")
                {
                    Hero hero = heroes.FirstOrDefault(x => x.Name==heroName);
                    if (hero!=null)
                    {
                        Console.WriteLine($"{heroName} is already enrolled.");
                    }
                    else
                    {
                        hero = new Hero(heroName);
                        heroes.Add(hero);
                    }
                }
                else if (command == "Learn")
                {
                    Hero hero = heroes.FirstOrDefault(x => x.Name == heroName);
                    string spellName = commandArgs[2];
                    if (hero==null)
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                        continue;
                    }
                    if (hero.SpellBook.Contains(spellName))
                    {
                        Console.WriteLine($"{heroName} has already learnt {spellName}.");
                        continue;
                    }
                    hero.SpellBook.Add(spellName);
                }
                else if (command == "Unlearn")
                {
                    Hero hero = heroes.FirstOrDefault(x => x.Name == heroName);
                    string spellName = commandArgs[2];
                    if (hero == null)
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                        continue;
                    }
                    if (!hero.SpellBook.Contains(spellName))
                    {
                        Console.WriteLine($"{heroName} doesn't know {spellName}.");
                        continue;
                    }
                    hero.SpellBook.Remove(spellName);
                }
            }
            Console.WriteLine("Heroes:");
            foreach (var hero in heroes)
            {
                Console.WriteLine(hero);
            }
        }
    }
}
