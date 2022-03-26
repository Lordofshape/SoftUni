using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();

            long n = input[0];

            long s = input[1];

            long numberToLook = input[2];

            Queue<long> q = new Queue<long>();

            long[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
            int Index = 0;
            while (n>0)
            {
                long currNum = arr[Index];
                q.Enqueue(currNum);

                n--;

                Index++;
            }
            while (s>0)
            {
                q.Dequeue();
                s--;
            }

            

            if (q.Count==0)
            {
                Console.WriteLine(0);
                return;
            }
            long min = q.Min();

            while (q.Count>0)
            {
                long currNum = q.Dequeue();
                if (currNum==numberToLook)
                {
                    Console.WriteLine("true");
                    return;
                }
            }

            Console.WriteLine(min);
            
            

            
            
        }
    }
}
