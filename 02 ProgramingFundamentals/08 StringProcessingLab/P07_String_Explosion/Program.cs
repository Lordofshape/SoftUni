using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P07_String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rawText = Console.ReadLine();
            List<char> chars = rawText.ToList();
            StringBuilder sb = new StringBuilder();
            int bombCounter = 0;
            for (int i = 0; i < chars.Count; i++)
            {
                if (chars[i]=='>')
                {
                    string number = new string(chars[i + 1],1); 
                    bombCounter += int.Parse(number);
                    sb.Append(chars[i]);
                    continue;
                }
                if (bombCounter > 0)
                {
                    bombCounter--;
                    continue;
                }
                sb.Append(chars[i]);
            }
            Console.WriteLine(sb);
        }
    }
}
