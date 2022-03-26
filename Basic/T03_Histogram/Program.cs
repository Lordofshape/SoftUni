using System;

namespace T03_Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;
           

            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (currentNum<200)
                {
                    p1++;
                   
                }
                else if (currentNum<=399)
                {
                    p2++;
                    
                }
                else if (currentNum <= 599)
                {
                    p3++;
                  
                }
                else if (currentNum <= 799)
                {
                    p4++;
                
                }
                else 
                {
                    p5++;
                   
                }

            }

            double converPercentP1 = (double)p1 / n * 100;
            double converPercentP2 = (double)p2 / n * 100;
            double converPercentP3 = (double)p3 / n * 100;
            double converPercentP4 = (double)p4 / n * 100;
            double converPercentP5 = (double)p5 / n * 100;

            Console.WriteLine($"{converPercentP1:f2}%");
            Console.WriteLine($"{converPercentP2:f2}%");
            Console.WriteLine($"{converPercentP3:f2}%");
            Console.WriteLine($"{converPercentP4:f2}%");
            Console.WriteLine($"{converPercentP5:f2}%");

        }
    }
}
