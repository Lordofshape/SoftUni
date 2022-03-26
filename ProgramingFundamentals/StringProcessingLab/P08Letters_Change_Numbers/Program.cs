using System;
using System.Linq;

namespace P08Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] upperCaseAlphabets = { '0', 'A', 'B' , 'C','D','E','F','G','H', 'I','J','K','L','M','N', 'O','P','Q','R','S','T','U','V','W','X','Y','Z'};
            char[] lowerCaseAplhabets = { '0', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            string[] text = Console.ReadLine().Split(new char[] {' ','\t'},StringSplitOptions.RemoveEmptyEntries);
            double totalSum = 0;
            foreach (var t in text)
            {
                string rawNumber = t.Substring(1, t.Length - 2);
                var rawFirstLetter = t.Substring(0, 1).ToCharArray();
                var rawSecondLetter = t.Substring(t.Length - 1, 1);
                double number = double.Parse(rawNumber);
                char firstLetter = rawFirstLetter[0];
                char lastLetter = rawSecondLetter[0];
                double currSum = 0;
               
                for (int i = 0; i < upperCaseAlphabets.Length; i++)
                {
                    if (firstLetter == upperCaseAlphabets[i])
                    {
                        currSum += number / i;
                        
                    }
                    else if (firstLetter == lowerCaseAplhabets[i])
                    {
                        currSum += number * i;
                    }
                    if (lastLetter == upperCaseAlphabets[i])
                    {
                        currSum -= i;
                        
                    }
                    else if (lastLetter == lowerCaseAplhabets[i])
                    {
                        currSum += i;
                    }
                }
               totalSum+=currSum;
            }
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
