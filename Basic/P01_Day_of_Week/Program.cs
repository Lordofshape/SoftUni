using System;
using System.Linq;

namespace P01_Day_of_Week
{
    internal class Program
    {
        static void Main()
        {
            //1.	Day of Week
            /*string[] arr =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            int num = int.Parse(Console.ReadLine());
            if (1 <= num && num <= arr.Length)
            {
                Console.WriteLine(arr[num - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
            */
            // 2.Print Numbers in Reverse Order
            int lengthArray = int.Parse(Console.ReadLine());
            int[] array = new int[lengthArray];


            for (int i = 0; i < array.Length; i++)
            {
                int number = int.Parse(Console.ReadLine());
                array[i] = number;
            }
            Array.Reverse(array);
            Console.WriteLine(string.Join(" ", array));
            //3.	Rounding Numbers
            /*double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} =>");
               
                Console.Write($" {Math.Round(numbers[i],MidpointRounding.AwayFromZero )}");
                Console.WriteLine("");
            }
            */
            //4.	Reverse Array of Strings
            /* var text = Console.ReadLine().Split(' ').ToArray();
             Array.Reverse(text);
             Console.WriteLine(string.Join(" ",text));*/
            //5.Sum Even Numbers
            /*    var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                var sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i]%2==0)
                    {
                        sum+=numbers[i];
                    }
                }
                Console.WriteLine(sum);*/
            //6.	Even and Odd Subtraction
            /*var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var evenNumbers = 0;
            var oddNumbers = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbers += numbers[i];
                }
                else
                {
                    oddNumbers += numbers[i];
                }
            }
            Console.WriteLine(evenNumbers-oddNumbers);*/
            //7.Equal Arrays
            /*var arrayOne = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var arrayTwo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var sum = 0;
            for (int i = 0; i < arrayOne.Length; i++)
            {
                if (arrayOne[i]!=arrayTwo[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
                else
                {
                    sum+=arrayOne[i];
                }
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");*/
            //8.Condense Array to Number
            /* var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
             int firstLength=array.Length;
             for (int i = 0; i < firstLength-1; i++)
             {
                 int[] condenced= new int[array.Length -1 ];
                 for (int j = 0; j < array.Length-1; j++)
                 {
                     condenced[j]=array[j] + array[j+1];
                 }
                 array = condenced;
             }
             Console.WriteLine(array[0]);*/


        }
    }
}
