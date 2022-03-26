using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_Company_Roster
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Employee> employes = new List<Employee>();
            string bestDepartment = null;
            decimal bestDepartmentSalary = 0;
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                Employee employee = new Employee(input[0],decimal.Parse(input[1]),input[2]);
                employes.Add(employee);
            }
            for (int i = 0; i < employes.Count; i++)
            {
                decimal departmentSum = 0m;
                for (int j = i+1; j < employes.Count; j++)
                {
                    if (employes[i].Department==employes[j].Department)
                    {
                        departmentSum += employes[j].Salary;
                    }
                }
                departmentSum += employes[i].Salary;
                if (bestDepartmentSalary<departmentSum)
                {
                    bestDepartment = employes[i].Department;
                    bestDepartmentSalary = departmentSum;
                }
            }
            Console.WriteLine($"Highest Average Salary: {bestDepartment}");
            List<Employee> orderedEmployees = new List<Employee> (employes.OrderByDescending(e => e.Salary));
            foreach (var employee in orderedEmployees)
            {
                if (employee.Department==bestDepartment)
                {
                    Console.WriteLine(employee);
                }
            }
            
        
        }
    }
    public class Employee
    {
        public Employee(string name, decimal salary,string department)
        {
            this.Name = name;
            this.Salary=salary;
            this.Department = department;
        }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }

        public override string ToString()
        {
            return $"{this.Name} {this.Salary:f2}";
        }
    }
}
