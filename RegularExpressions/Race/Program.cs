using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            string[] array = Console.ReadLine().Split(", ");
            Dictionary<string, int> participants = new Dictionary<string, int>();
            foreach (var name in array)
            {
                participants.Add(name, 0);
            }
            string input;
            while ((input = Console.ReadLine()) != "end of race")
            {

                StringBuilder name = new StringBuilder();
                int distance = 0;
                foreach (var ch in input)
                {
                    if (char.IsDigit(ch))
                    {
                        distance += int.Parse(string.Join("", ch));
                    }
                    if (char.IsLetter(ch))
                    {
                        name.Append(ch);
                    }
                }
                string nameParticipant = string.Join("",name);
                if (participants.ContainsKey(nameParticipant))
                {
                    participants[nameParticipant] += distance;
                }


            }
            var topThreePlayers = participants.OrderByDescending(x => x.Value).Take(3).ToDictionary(x => x.Key, y => y.Value);

            int counter = 0;

            foreach (var player in topThreePlayers)
            {
                counter++;
                if (counter == 1)
                {
                    Console.WriteLine($"{counter}st place: {player.Key}");
                }
                else if (counter == 2)
                {
                    Console.WriteLine($"{counter}nd place: {player.Key}");
                }
                else
                {
                    Console.WriteLine($"{counter}rd place: {player.Key}");
                }

            }

        }
    }
}
