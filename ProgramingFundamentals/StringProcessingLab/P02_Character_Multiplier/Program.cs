using System;

namespace P02_Character_Multiplier
{
    internal class Program
    {
        static void Main()
        {
            string[] args = Console.ReadLine().Split();
            string firstStr = args[0];
            string secondStr = args[1];
            int minvalue = Math.Min(firstStr.Length, secondStr.Length);
            int maxvalue = Math.Max(firstStr.Length, secondStr.Length);
            int counter = 0;
            int totalSum = 0;
            for (int i = 0; i < minvalue; i++)
            {
                int currFirstChar = (int)firstStr[i];
                int currSecondChar = (int)secondStr[i];
                totalSum += currFirstChar * currSecondChar;
                counter++;
            }
            for (int i = counter; i < maxvalue; i++)
            { 
                if (firstStr.Length-1>=counter)
                {
                    int currFirstChar = (int)firstStr[i];
                    totalSum += currFirstChar;
                }
                if (secondStr.Length-1>=counter)
                {
                    int currSecondChar = (int)secondStr[i];
                    totalSum += currSecondChar;
                }
                    
            }
            Console.WriteLine(totalSum);
        }
    }
}
