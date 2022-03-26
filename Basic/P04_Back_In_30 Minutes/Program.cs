namespace P04_Back_In_30_Minutes 
{
    using System;
    public class Program 
    {
        static void Main()
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            minutes += 30;
           if (minutes >= 59)
            {
                hours += 1;
                minutes -= 60;
            }
            if (hours >= 24)
            {
                hours = 0;
            }
            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}