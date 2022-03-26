using System;
using System.Collections.Generic;

namespace P00_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            Dictionary<string,List<string>> dictionaryOfSynonyms = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string keyValue = Console.ReadLine();
                string synonim = Console.ReadLine();
                if (dictionaryOfSynonyms.ContainsKey(keyValue))
                {
                    dictionaryOfSynonyms[keyValue].Add(synonim);
                }
                else
                {
                    dictionaryOfSynonyms.Add(keyValue, new List<string>());
                    dictionaryOfSynonyms[keyValue].Add(synonim);
                }
            }
            foreach (var word in dictionaryOfSynonyms)
            {
                Console.Write($"{word.Key} - ");
                for (int i = 0; i < word.Value.Count; i++)
                {
                    
                    if (i==word.Value.Count-1)
                    {
                        Console.Write(word.Value[i]);
                    }
                    else
                    {
                        Console.Write($"{word.Value[i]}, ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
