namespace P03Heroes_of_Code_and_Logic_VII
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Tuple<int, int>> heroes = new Dictionary<string, Tuple<int, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] hero = Console.ReadLine().Split();
                string heroName = hero[0];
                int health = int.Parse(hero[1]);
                int mana = int.Parse(hero[2]);
                heroes.Add(heroName, Tuple.Create(health, mana));
            }
            
            string input;

            while ((input=Console.ReadLine())!="End")
            {
                string[] cmdArgs = input.Split(" - ");
                string cmd = cmdArgs[0];
                string heroName = cmdArgs[1];
                if (cmd== "CastSpell")
                {                
                    int requiredMana = int.Parse(cmdArgs[2]);
                    string spellName = cmdArgs[3];
                    int mana = heroes[heroName].Item2;
                    if (mana>=requiredMana)
                    {
                        mana -= requiredMana;
                        int health = heroes[heroName].Item1;
                        heroes[heroName] = Tuple.Create(health,mana);
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {mana} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if(cmd== "TakeDamage")
                {
                    int damage = int.Parse(cmdArgs[2]);
                    string attacker = cmdArgs[3];
                    int health = heroes[heroName].Item1;
                    health -= damage;
                    if (health>0)
                    {
                        int mana = heroes[heroName].Item2;
                        heroes[heroName] = Tuple.Create(health, mana);
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {health} HP left!");
                    }
                    else
                    {
                        heroes.Remove(heroName);
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                    }
                }
                else if(cmd== "Recharge")
                {
                    int mana = heroes[heroName].Item2;
                    int health = heroes[heroName].Item1;
                    int requiredMana = 200 - mana;
                    int amount = int.Parse(cmdArgs[2]);
                    if (amount >= requiredMana)
                    {
                        mana += requiredMana;
                        heroes[heroName] = Tuple.Create(health, mana);
                        Console.WriteLine($"{heroName} recharged for {requiredMana} MP!");
                    }
                    else
                    {
                        mana += amount; ;
                        heroes[heroName] = Tuple.Create(health, mana);
                        Console.WriteLine($"{heroName} recharged for {amount} MP!");
                    }
                }
                else
                {
                    int mana = heroes[heroName].Item2;
                    int health = heroes[heroName].Item1;
                    int requiredHealth = 100 - health;
                    int amount = int.Parse(cmdArgs[2]);
                    if (amount >= requiredHealth)
                    {
                        health += requiredHealth;
                        heroes[heroName] = Tuple.Create(health, mana);
                        Console.WriteLine($"{heroName} healed for {requiredHealth} HP!");
                    }
                    else
                    {
                        health += amount; ;
                        heroes[heroName] = Tuple.Create(health, mana);
                        Console.WriteLine($"{heroName} healed for {amount} HP!");
                    }
                }
            }
            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($"HP: {hero.Value.Item1}");
                Console.WriteLine($"MP: {hero.Value.Item2}");
            }
        }
    }
}
