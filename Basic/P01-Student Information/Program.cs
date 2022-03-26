namespace P01_Student_Information
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            var studentname = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var averagegrade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {studentname}, Age: {age}, Grade: {averagegrade:f2}");
        }
    }
}