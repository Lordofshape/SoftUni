namespace P03_P_rates
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,Tuple<int,int>> towns = new Dictionary<string,Tuple<int, int>>();
            string cmd;
            while ((cmd=Console.ReadLine())!="Sail")
            {
                string[] parts = cmd.Split("||");
                string town = parts[0];
                int population = int.Parse(parts[1]);
                int gold = int.Parse(parts[2]);
                if (towns.ContainsKey(town))
                {
                    towns[town] = Tuple.Create(towns[town].Item1 + population, towns[town].Item2 + gold);
                }
                else
                {
                    towns.Add(town, Tuple.Create(population,gold));
                }
            }
            string events;
            while ((events = Console.ReadLine()) != "End")
            {
                string[] eventsArgs = events.Split("=>");
                string command = eventsArgs[0];
                if (command== "Plunder")
                {
                    string town = eventsArgs[1];
                    int killedPeople = int.Parse(eventsArgs[2]);
                    int stealedGold = int.Parse(eventsArgs[3]);
                    int people = towns[town].Item1 - killedPeople;
                    int gold = towns[town].Item2 - stealedGold;
                    towns[town] = Tuple.Create(people, gold);
                    Console.WriteLine($"{town} plundered! {stealedGold} gold stolen, {killedPeople} citizens killed.");
                    if (gold<=0 || people<=0)
                    {
                        towns.Remove(town);
                        Console.WriteLine($"{town} has been wiped off the map!");
                    }
                }
                else
                {
                    string town = eventsArgs[1];
                    int gold = int.Parse(eventsArgs[2]);
                    if (gold<0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        continue;
                    }
                    int people = towns[town].Item1;
                    int tresure = towns[town].Item2 + gold;
                    towns[town] = Tuple.Create(people,tresure);
                    Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {tresure} gold.");
                }
            }
            if (towns.Count==0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {towns.Count} wealthy settlements to go to:");
                foreach (var town in towns)
                {
                    Console.WriteLine($"{town.Key} -> Population: {town.Value.Item1} citizens, Gold: {town.Value.Item2} kg");
                }
            }
        }
    }
}
