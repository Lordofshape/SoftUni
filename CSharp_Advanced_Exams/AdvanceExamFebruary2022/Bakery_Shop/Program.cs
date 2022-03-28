using System;
using System.Collections.Generic;
using System.Linq;

namespace Bakery_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] firstInput = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double[] secondInput = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Queue<double> waterResource = new Queue<double>();
            Stack<double> flourResource = new Stack<double>();
            Dictionary<string, int> bakeryProducts = new Dictionary<string, int>();
            bakeryProducts.Add("Croissant", 0);
            bakeryProducts.Add("Muffin", 0);
            bakeryProducts.Add("Baguette", 0);
            bakeryProducts.Add("Bagel", 0);
            for (int i = 0; i < firstInput.Length; i++)
            {
                waterResource.Enqueue(firstInput[i]);
            }
            for (int i = 0; i < secondInput.Length; i++)
            {
                flourResource.Push(secondInput[i]);
            }
            while (waterResource.Count>0 && flourResource.Count>0)
            {
                 double water = waterResource.Dequeue();
                double flour = flourResource.Pop();
               double percentage = water + flour;
                double waterPercentage = (water * 100) / percentage;
                double flourPercentage = 100 - waterPercentage;
                if (waterPercentage==40&&flourPercentage==60)
                {
                    bakeryProducts["Muffin"]++;
                }
                else if (waterPercentage == 30 && flourPercentage == 70)
                {
                    bakeryProducts["Baguette"]++;
                }
                else if(waterPercentage ==20 && flourPercentage == 80)
                {
                    bakeryProducts["Bagel"]++;
                }
                else
                {
                    flour -= water;
                    if (flour>0)
                    {
                        flourResource.Push(flour);
                    }
                    bakeryProducts["Croissant"]++;
                }
            }
            bakeryProducts.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Where(x => x.Value>0).ToList().ForEach(x => Console.WriteLine($"{x.Key}: {x.Value}"));
            if (waterResource.Count>0)
            {
                Console.Write("Water left: ");
                Console.WriteLine(string.Join(", ",waterResource));
            }
            else
            {
                Console.WriteLine("Water left: None");
            }
            if (flourResource.Count > 0)
            {
                Console.Write("Flour left: ");
                Console.WriteLine(string.Join(", ", flourResource));
            }
            else
            {
                Console.WriteLine("Flour left: None");
            }

        }
    }
}
