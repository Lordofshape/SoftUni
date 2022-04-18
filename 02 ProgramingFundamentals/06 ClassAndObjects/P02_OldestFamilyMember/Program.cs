using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_OldestFamilyMember
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> families = new List<Person>();
            Person person;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                person = new Person(input[0], int.Parse(input[1]));        
                families.Add(person);
            }
            Family family = new Family(families);
            Console.WriteLine(family.GetOldestMember(families));
        }
    }
    public class Person
    {
        public Person(string name , int age)
        {
            this.Name = name;
            this.Age=age; 
        }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{this.Name} {this.Age}";
        }
    }
    public class Family
    {
        public Family(List<Person> people)
        {
        
            GetOldestMember(people);
            this.Members = new List<Person>();
        }
        public List<Person> Members { get; set; }

        public Person GetOldestMember(List<Person> people)
        {
            int age = 0;
            foreach (var person in people)
            {
                if (person.Age>age)
                {
                    age = person.Age;
                }
            }
            return Members.FirstOrDefault(m => m.Age == age);
        }
    }
}
