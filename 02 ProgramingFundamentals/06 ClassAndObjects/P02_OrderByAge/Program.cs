using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_OrderByAge
{
    public class Program
    {
        static void Main()
        {
            List<Person> people = new List<Person>(); 
            string command;
            while ((command=Console.ReadLine())!="End")
            {
                string[] args = command.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string name = args[0];
                int id = int.Parse(args[1]);
                int age = int.Parse(args[2]);
                Person person = new Person(name, id, age);
                if (people.Any(p => id == p.Id))
                {
                    person.Update(id, name, age);
                    continue;
                }
                people.Add(person);

            }
            List<Person> orderedPeopleByAge = new List<Person>(people.OrderBy(p => p.Age));
            foreach (var person in orderedPeopleByAge)
            {
                Console.WriteLine(person);
            }
        }
    }
    public class Person
    {
        public Person(string name, int id, int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;

            Update(id,name,age);
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public void Update(int id, string name, int age)
        {
            this.Name= name;
            this.Age= age;
        }
        public override string ToString()
        {
            return $"{this.Name} with ID: {this.Id} is {this.Age} years old.";
        }
    }
}
