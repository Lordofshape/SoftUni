using System;

namespace T04_Steps
{
    class Program
    {
        static void Main(string[] args)
        {
            const int goal= 10000;
            string steps = Console.ReadLine();
            int daySteps = 0;

            while (steps!="Going home")
            {
                int currSteps = int.Parse(steps);
                daySteps += currSteps;
              
                if (daySteps>=goal)
                {

                    Console.WriteLine("Goal reached! Good job!");
                    if (daySteps>goal)
                    {
                        daySteps -= goal;
                        Console.WriteLine($"{daySteps} steps over the goal!");
                    }
                    break;
                }
                steps = Console.ReadLine();
            }
            if (steps == "Going home")
            {
                steps = Console.ReadLine();
                int stepsToHome = int.Parse(steps);
                daySteps +=stepsToHome ;
                if (daySteps<goal)
                {
                daySteps -= goal;
                Console.WriteLine($"{Math.Abs(daySteps)} more steps to reach goal.");
                }
                else
                {
                    Console.WriteLine("Goal reached! Good job!");
                    if (daySteps > goal)
                    {
                        daySteps -= goal;
                        Console.WriteLine($"{daySteps} steps over the goal!");
                    }
                }

                
            }

        }
    }
}
