using System;

namespace T06_Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            double marksForOscar = 1250.5;
            string name = Console.ReadLine();
            double pointOfAccademy = double.Parse(Console.ReadLine());
            int examers = int.Parse(Console.ReadLine());

            for (int i = 0; i < examers; i++)
            {
                string examerName = Console.ReadLine();
                double markOfExamer = double.Parse(Console.ReadLine());
                pointOfAccademy += (examerName.Length * markOfExamer) / 2;
                if (pointOfAccademy >= marksForOscar)
                {
                    Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {pointOfAccademy:f1}!");
                    return;
                }
            }
                marksForOscar -= pointOfAccademy;
                Console.WriteLine($"Sorry, {name} you need {marksForOscar:f1} more!"); 
        }   
    }
}