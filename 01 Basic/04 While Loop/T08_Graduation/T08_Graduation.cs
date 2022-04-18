namespace T08_Graduation
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();

            double gradeSum = 0;
            int grade = 1;
            int failsCounter = 0;

            while (grade<=12)
            { 
                double yearlyGrade = double.Parse(Console.ReadLine());
                if (yearlyGrade<4)
                {
                    failsCounter++;
                    if (failsCounter==2)
                    {
                        Console.WriteLine($"{studentName} has been excluded at {grade} grade");
                        break;
                    }
                    continue;
                }
                gradeSum += yearlyGrade;
                grade++;
            }

            double averageGrade = gradeSum / 12;
            if (grade>12)
            {
                Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:f2}");
            }

        }
    }
}
