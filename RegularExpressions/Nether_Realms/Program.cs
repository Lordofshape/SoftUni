using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Nether_Realms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] demonNames = Regex.Split(Console.ReadLine(), @" *,{1} *")
                      .Select(x => x.Trim())
                      .ToArray();
            List<Demon> demons = new List<Demon>();
            foreach (var demonName in demonNames)
            {
                int demonHealth = DemonHealth(demonName);
                double demonDemage = DemonDemage(demonName);
                Demon demon = new Demon(demonName,demonDemage,demonHealth);
                demons.Add(demon);
            }
            List<Demon> Orderdemons = demons.OrderBy(x => x.Name).ToList();
            foreach (var demon in Orderdemons)
            {
                Console.WriteLine(demon);
            }
        }
        static double DemonDemage(string name)
        {
            Regex regex = new Regex(@"(?<number>(-)?\d+(\.\d+)?)|(?<multiplication>\*)|(?<division>/)");
            MatchCollection matches = regex.Matches(name);

            double sum = 0;
            List<char> multiplacteOrDivide = new List<char>();

            foreach (Match match in matches)
            {
                if (match.Value == "*")
                {
                    multiplacteOrDivide.Add('m');
                }
                else if (match.Value == "/")
                {
                    multiplacteOrDivide.Add('d');
                }
                else
                {
                    sum += double.Parse(match.Value);
                }
            }
            foreach (var item in multiplacteOrDivide)
            {
                if (item == 'm')
                {
                    sum = sum * 2;
                }
                else if (item == 'd')
                {
                    sum = sum / 2;
                }
            }
            return sum;
        }
        static int DemonHealth(string name)
        {
            int sum = 0;
            Regex regex = new Regex(@"[^\d\*\+\-\/\.]{1}");
            MatchCollection matches = regex.Matches(name);
            foreach (Match match in matches)
            {
                 char[] c = match.Value.ToCharArray();
                 sum += (int)c[0];
            }
            return sum;
        }

    }
    public class Demon
    {
        public Demon(string name, double demage, int healt)
        {
            this.Name = name;
            this.Demage = demage;
            this.Health = healt;
        }
        public string Name { get; set; }
        public double Demage { get; set; }
        public int Health { get; set; }

        public override string ToString()
        {
            return $"{this.Name} - {this.Health} health, {this.Demage:f2} damage"; 
        }
    }
}
