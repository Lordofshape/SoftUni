using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace P01_Students
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int numberOFStudents = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOFStudents; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string firstName = input[0];
                string lastName = input[1];
                double grade = double.Parse(input[2]);
                Student student = new Student(firstName, lastName, grade);
                students.Add(student);
            }
            List<Student> orderedStudents = new List<Student>(students.OrderByDescending(s => s.Grade));
            foreach (var student in orderedStudents)
            {
                Console.WriteLine(student);
            }

        }
    }
    public class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
          
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}: {this.Grade:f2}";
        }
        
    }
}
