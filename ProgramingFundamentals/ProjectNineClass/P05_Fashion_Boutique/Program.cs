using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var boxs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());
            var collectionOfClothBoxs = new Stack<int>();
            int counter = 0;
            int rack = 1;
            foreach (var box in boxs)
            {
                collectionOfClothBoxs.Push(box);
            }
            while (collectionOfClothBoxs.Count!=0)
            {
                counter += collectionOfClothBoxs.Peek();
                if (counter <= rackCapacity)
                {
                    collectionOfClothBoxs.Pop();
                }
                else
                {
                    rack++;
                    counter = 0;
                }

            }
            Console.WriteLine(rack);




        }
    }
}
