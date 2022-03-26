using System;
using System.Collections.Generic;
using System.Linq;

namespace P00_Demo
{
    internal class Program
    {
        static void Main()
        {
            /*List<int> list = new List<int>();

            string command;
            bool flag = false;
            List<double> componentsPrice = new List<double>();

            while ((command = Console.ReadLine()) != string.Empty)
            {
                if (command == "regular")
                {
                    break;
                }
                else if (command == "special")
                {
                    flag = true;
                    break;
                }
                double componentPrice = double.Parse(command);
                if (componentPrice < 0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }
                componentsPrice.Add(double.Parse(command));

            }
            double priceWithTaxes = componentsPrice.Sum() * 1.2;
            double taxes = componentsPrice.Sum() * 0.2;
            if (flag)
            {
                priceWithTaxes = priceWithTaxes * 0.9;
            }
            if (componentsPrice.Sum() == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {componentsPrice.Sum():f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {priceWithTaxes:f2}$");
            }*/

            /*int people = int.Parse(Console.ReadLine());
            int[] wagons = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < wagons.Length; i++)
            {
                if (people>=0)
                {
                    while (wagons[i] < 4 && people != 0)
                    {
                        people--;
                        wagons[i] += 1;
                    }
                }
                else
                {
                    return;
                }
            }
            if (people>0)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                
            }

            if (wagons[^1] < 4)
            {
                Console.WriteLine("The lift has empty spots!");
            }
            Console.WriteLine(String.Join(" ", wagons));*/

            List<string> elements =Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();
            int movesCount = 0;

            string command;
            while ((command=Console.ReadLine())!="end")
            {
                string[] index = command.Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                int firstNumber = int.Parse(index[0]);
                int secondNumber = int.Parse(index[1]);
                if (elements.Count==0)
                {
                    continue;
                }
                if (index.Length>2 || firstNumber<0 || secondNumber<0 || firstNumber >= elements.Count || secondNumber >= elements.Count || firstNumber==secondNumber)
                {
                    counter(elements);
                    var indexToInsert = elements.Count / 2;
                    elements.Insert(indexToInsert, $"-{movesCount}a");
                    elements.Insert(indexToInsert, $"-{movesCount}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    continue;
                }

                if (elements[firstNumber]==elements[secondNumber])
                {
                    counter(elements);
                    Console.WriteLine($"Congrats! You have found matching elements - {elements[firstNumber]}!");
                    elements.RemoveAt(firstNumber);
                    if (secondNumber==0)
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
            if (elements.Count>0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ",elements));
            }
            else
            {
                Console.WriteLine($"You have won in {movesCount} turns!");
            }

            void counter(List<string> arrgs)
            {
                
                if (arrgs.Count>0)
                {
                    movesCount++;
                }
            }


        }
    }
}


