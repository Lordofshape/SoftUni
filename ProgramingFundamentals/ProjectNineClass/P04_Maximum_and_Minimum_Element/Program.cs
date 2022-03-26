using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());
            Stack<int> colllectionOfNumbers = new Stack<int>();
            int minNumberInStack = int.MaxValue;
            int maxNumberInStack = int.MinValue;

            for (int i = 0; i < numberOfOperations; i++)
            {
                var input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                if (input[0]==1)
                {
                    colllectionOfNumbers.Push(input[1]);
                
                }
                else if (input[0] == 2)
                {
                    if (colllectionOfNumbers.Count>0)
                    {
                        colllectionOfNumbers.Pop();
                    }
                }
                else if (input[0] == 3)
                {
                    if (colllectionOfNumbers.Count>0)
                    {
                        foreach (var number in colllectionOfNumbers)
                        {
                            if (number > maxNumberInStack)
                            {
                                maxNumberInStack = number;
                            }
                        }
                        Console.WriteLine(maxNumberInStack);
                    }
                   
                }
                else if (input[0] == 4)
                {
                    if (colllectionOfNumbers.Count>0)
                    {
                        foreach (var number in colllectionOfNumbers)
                        {
                            if (number < minNumberInStack)
                            {
                                minNumberInStack = number;
                            }
                        }
                        Console.WriteLine(minNumberInStack);
                    }
                    
                }
            }
            if (colllectionOfNumbers.Count>0)
            {
            Console.WriteLine(string.Join(", ",colllectionOfNumbers));
            }
        }
    }
}
