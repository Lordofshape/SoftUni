namespace P02_Emoji_Detector
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\:\:|\*\*)(?<emoji>[A-Z][a-z]{2,})\1";
            string input = Console.ReadLine();
            long threshold = 1L;
            List<string> coolEmojies = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    threshold *= long.Parse(string.Join("",input[i]));
                }
            }
            MatchCollection collection = Regex.Matches(input,pattern);
            int emojiCounter = collection.Count;
            foreach (Match item in collection)
            {
                string emoji = item.Groups["emoji"].Value;

                long coolness = 0;
                for (int i = 0; i < emoji.Length; i++)
                {
                    coolness += (int)emoji[i];
                }
                if (coolness>=threshold)
                {
                    coolEmojies.Add(item.Groups[0].Value);
                }
            }
            Console.WriteLine($"Cool threshold: {threshold}");
            Console.WriteLine($"{emojiCounter} emojis found in the text. The cool ones are:");
            foreach (var emoji in coolEmojies)
            {
                Console.WriteLine(emoji);
            }
        }
    }
}
