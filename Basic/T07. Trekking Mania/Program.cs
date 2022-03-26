using System;

namespace T07._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int climbersGroups = int.Parse(Console.ReadLine());
            double groupClimbers1 = 0;
            double groupClimbers2 = 0;
            double groupClimbers3 = 0;
            double groupClimbers4 = 0;
            double groupClimbers5 = 0;

            for (int i = 0; i < climbersGroups; i++)
            {
                int currentClimbers = int.Parse(Console.ReadLine());
                if (currentClimbers<6)
                {
                    groupClimbers1 += currentClimbers;
                }
                else if (currentClimbers<13)
                {
                    groupClimbers2 += currentClimbers;
                }
                else if (currentClimbers < 26)
                {
                    groupClimbers3 += currentClimbers;
                }
                else if (currentClimbers < 41)
                {
                    groupClimbers4 += currentClimbers;
                }
                else if (currentClimbers > 40)
                {
                    groupClimbers5 += currentClimbers;
                }
            }
            double allClimbers = groupClimbers1 + groupClimbers2 + groupClimbers3 + groupClimbers4 + groupClimbers5;
            double percentGroupClimber1 = groupClimbers1 / allClimbers * 100;
            double percentGroupClimber2 = groupClimbers2 / allClimbers * 100;
            double percentGroupClimber3 = groupClimbers3 / allClimbers * 100;
            double percentGroupClimber4 = groupClimbers4 / allClimbers * 100;
            double percentGroupClimber5 = groupClimbers5 / allClimbers * 100;

            Console.WriteLine($"{percentGroupClimber1:f2}%");
            Console.WriteLine($"{percentGroupClimber2:f2}%");
            Console.WriteLine($"{percentGroupClimber3:f2}%");
            Console.WriteLine($"{percentGroupClimber4:f2}%");
            Console.WriteLine($"{percentGroupClimber5:f2}%");
        }
    }
}
