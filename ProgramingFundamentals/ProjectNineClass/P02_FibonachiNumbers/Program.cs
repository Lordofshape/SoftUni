using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class CubicMessages
{
    static void Main()
    {
        /*
                int n = int.Parse(Console.ReadLine());
                int num = 0;

                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        num = i + j - 1;

                        if (num > n)
                        {
                            for (int k = 1; k <= n - j + 1; k++)
                            {
                                Console.Write("{0} ", n - k);
                            }
                            break;
                        }

                        Console.Write("{0} ", num);
                    }
                    Console.WriteLine();
                }*/

        /* string path = @"C:\Users\metko\OneDrive\Работен плот\data.txt.TXT";
         string[] readText = File.ReadAllText(path).Split();

         Console.WriteLine(string.Join(" ",readText));*/
        int carsCrossGreenLight = int.Parse(Console.ReadLine());
        string input;
        Queue<string> cars = new Queue<string>();
        int allCarsCrossGreenLight = 0;
        while ((input=Console.ReadLine())!="end")
        {
            if (input=="green")
            {
                var counter = 0;
                while (cars.Count>0 && counter<=carsCrossGreenLight)
                {
                    Console.WriteLine($"{cars.Dequeue()} passed!");
                    counter++;
                }
                allCarsCrossGreenLight += counter;
            }
            else
            {
                cars.Enqueue(input);
            }
        }
        Console.WriteLine($"{allCarsCrossGreenLight} cars passed the crossroads!");

    }

}