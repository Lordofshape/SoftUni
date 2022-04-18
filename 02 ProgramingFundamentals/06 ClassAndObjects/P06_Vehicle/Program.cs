using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace P06_Vehicle
{
    public class Program
    {
        static void Main()
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                string[] args = command.Split(" ");
                if (args[0] == "car")
                {
                    Car car = new Car("Car", args[1], args[2], double.Parse(args[3]));
                    cars.Add(car);
                }
                else if (args[0] == "truck")
                {
                    Truck truck = new Truck("Truck", args[1], args[2], double.Parse(args[3]));
                    trucks.Add(truck);
                }
            }
            string input;
            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {
                foreach (var car in cars)
                {
                    if (car.Model == input)
                    {
                        Console.WriteLine(car);
                        break;
                    }
                }
                foreach (var truck in trucks)
                {
                    if (truck.Model == input)
                    {
                        Console.WriteLine(truck);
                        break;
                    }
                }
            }
            double carH = 0;
            double carC = 0;
            foreach (var car in cars)
            {
                carH += car.HorsePower;
                carC++;
            }
        
            double truckH = 0;
            double truckC = 0;
            foreach (var truck in trucks)
            {
                truckH += truck.HorsePower;
                truckC++;
            }
            double averageTruck = truckH / truckC;
            double averageCar = carH/ carC;
         

            if (averageTruck > 0 && averageCar > 0
                    )
            {
                Console.WriteLine($"Cars have average horsepower of: {averageCar:f2}.");
                Console.WriteLine($"Trucks have average horsepower of: {averageTruck:f2}.");
               
            }
            else if (trucks.Count == 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {averageCar:f2}.");
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
                
            }
            else if (cars.Count == 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
                Console.WriteLine($"Trucks have average horsepower of: {averageTruck:f2}.");
                
            }


        }
    }
    public class Car
    {
        public Car(string type, string model, string color, double horsePower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }

        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public double HorsePower { get; set; }
        public override string ToString()
        {
            return $"Type: {this.Type}\n" + $"Model: {this.Model}\n" + $"Color: {this.Color}\n" + $"Horsepower: {this.HorsePower}";

        }
    }
    public class Truck
    {
        public Truck(string type, string model, string color, double horsePower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }

        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public double HorsePower { get; set; }

        public override string ToString()
        {
            return $"Type: {this.Type}\n" + $"Model: {this.Model}\n" + $"Color: {this.Color}\n" + $"Horsepower: {this.HorsePower}";

        }
    }
}
