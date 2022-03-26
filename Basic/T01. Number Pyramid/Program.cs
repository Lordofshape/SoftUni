using System;

namespace T01._Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int rows = 1;
            int currNum = 1;

            bool IsEqual = false;

            while (!IsEqual)
            {
                for (int i = 1; i <= rows; i++)
                {
                    Console.Write($"{currNum} ");
                    currNum++;
                    if (currNum>number)
                    {
                        IsEqual = true;
                        break;
                    }
                }
                Console.WriteLine();
                rows++;
            }
        }
    }
}
