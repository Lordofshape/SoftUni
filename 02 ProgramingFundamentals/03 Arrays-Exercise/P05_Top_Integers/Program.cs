using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_Top_Integers
{
    internal class Program
    {
        static void Main()
        {
           int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> topIntegers = new();

            for (int i = 0; i < nums.Length; i++)
            {
                bool flag = false;
                if (nums.Length == 1)
                {
                    topIntegers.Add(nums[i]);
                }
                else
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] > nums[j])
                        {
                            if (flag == false)
                            {
                                topIntegers.Add(nums[i]);
                                flag = true;
                            }
                            continue;
                        }
                        topIntegers.Remove(nums[i]);
                        break;
                    }
                    if (nums.Length - 1 == i)
                    {
                        topIntegers.Add(nums[i]);
                    }
                }

            }
            Console.WriteLine(String.Join(" ", topIntegers));
        }
    }
}
