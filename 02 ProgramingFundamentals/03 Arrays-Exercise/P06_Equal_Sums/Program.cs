using System;
using System.Linq;

namespace P06_Equal_Sums
{
    internal class Program
    {
        static void Main()
        {
            int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (num.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = 0; i < num.Length; i++)
            {
                int leftSum = num.Take(i).Sum();

                int rightSum = num.Skip(i + 1).Sum();

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
