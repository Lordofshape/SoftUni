using System;
using System.Linq;

namespace P04_Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split(' ').ToArray();
            Array.Reverse(text);
            Console.WriteLine(string.Join(" ", text));
        }
    }
}
