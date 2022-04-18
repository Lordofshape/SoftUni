using System;
using System.Text.RegularExpressions;

namespace P02_Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            MatchCollection match = Regex.Matches(text, @"(\||\#)(?<name>[A-Za-z0-9 ]{1,})\1(?<date>[0-9]{2}\/[0-9]{2}\/[0-9]{2})\1([0-9]{1,4}|10000)\1");
            int productCalories = 0;
            int days = 0;
            foreach (Match m in match)
            {
                productCalories += int.Parse(m.Groups[2].Value);
            }
            while (productCalories >= 2000)
            {
                productCalories -= 2000;
                days++;
            }
            Console.WriteLine($"You have food to last you for: {days} days!");
            foreach (Match m in match)
            {
                Console.WriteLine($"Item: {m.Groups["name"].Value}, Best before: {m.Groups["date"].Value}, Nutrition: {m.Groups[2].Value}");
            }
        }
    }
}
