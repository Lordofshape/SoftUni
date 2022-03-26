namespace T02_Exam_Preparation
{
using System;

    class Program
    {
        static void Main(string[] args)
        {
            int failExam = int.Parse(Console.ReadLine());
            string exam = Console.ReadLine();
            int mark = int.Parse(Console.ReadLine());

            int counter = 0;
            int numberOfProblems = 0;
            double averageScore = 0;
            string lastExam = "";

            while (exam!="Enough")
            {
                numberOfProblems++;
                if (mark<=4)
                {
                    counter++;
                    if (failExam==counter)
                    {
                        Console.WriteLine($"You need a break, {counter} poor grades.");
                        break;
                    }
                }
                
                averageScore += mark; 
                exam = Console.ReadLine();
                if (exam!="Enough")
                {
                    mark = int.Parse(Console.ReadLine());
                    lastExam = exam;
                }
            }
               

            if (counter<failExam)
            {
                Console.WriteLine($"Average score: {averageScore/numberOfProblems:f2}");
                Console.WriteLine($"Number of problems: {numberOfProblems}");
                Console.WriteLine($"Last problem: {lastExam}");
            }

        }
    }
}
