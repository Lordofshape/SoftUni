using System;
using System.Collections.Generic;
using System.Text;

namespace P01_Extract_Person_Information
{
    internal class Program
    {
        static void Main()
        { 
            int n = int.Parse(Console.ReadLine());
            Dictionary<string,string> dic = new Dictionary<string,string>();
            for (int i = 0; i < n; i++)
            {
                string rawText = Console.ReadLine();

                StringBuilder age = new StringBuilder();
                StringBuilder name = new StringBuilder();
                for (int j = 0; j < rawText.Length; j++)
                {
                    if (rawText[j]=='@')
                    {
                        for (int k = j+1; k < rawText.Length; k++)
                        {
                            if (rawText[k]== '|')
                            {
                                break;
                            }
                            name.Append(rawText[k]);
                        }
                    }
                    if (rawText[j]== '#')
                    {
                        for (int k = j+1; k < rawText.Length; k++)
                        {
                            if (rawText[k]== '*')
                            {
                                break;
                            }
                            age.Append(rawText[k]);
                        }
                    }
                }
                string currAge = age.ToString();
                string currName = name.ToString();
               dic[currName] = currAge;
            }
            foreach (var person in dic)
            {
                Console.WriteLine($"{person.Key} is {person.Value} years old.");
            }
        }
    }
}
