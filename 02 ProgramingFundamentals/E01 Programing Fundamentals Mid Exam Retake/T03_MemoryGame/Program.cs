using System;
using System.Collections.Generic;
using System.Linq;

namespace T03_MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            int movesCount = 0;

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] index = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                int firstNumber = int.Parse(index[0]);
                int secondNumber = int.Parse(index[1]);
                if (elements.Count == 0)
                {
                    continue;
                }
                if (index.Length > 2 || firstNumber < 0 || secondNumber < 0 || firstNumber >= elements.Count || secondNumber >= elements.Count || firstNumber == secondNumber)
                {
                    counter(elements);
                    var indexToInsert = elements.Count / 2;
                    elements.Insert(indexToInsert, $"-{movesCount}a");
                    elements.Insert(indexToInsert, $"-{movesCount}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    continue;
                }

                if (elements[firstNumber] == elements[secondNumber])
                {
                    counter(elements);
                    Console.WriteLine($"Congrats! You have found matching elements - {elements[firstNumber]}!");
                    elements.RemoveAt(firstNumber);
                    if (secondNumber == 0)
                    {
                        elements.RemoveAt(secondNumber);
                    }
                    else
                    {
                        elements.RemoveAt(secondNumber - 1);
                    }

                }
                else
                {
                    counter(elements);
                    Console.WriteLine("Try again!");
                }


            }
            if (elements.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", elements));
            }
            else
            {
                Console.WriteLine($"You have won in {movesCount} turns!");
            }

            void counter(List<string> arrgs)
            {

                if (arrgs.Count > 0)
                {
                    movesCount++;
                }
            }
        }
    }
}
