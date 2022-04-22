namespace P03Need_for_Speed_III
{
    using System.Collections.Generic;
    using System;
    class Program
    {
        

        static void Main(string[] args)
        {
            const int maxCarMileage = 100000;
            const int maxCarTank = 75;
            Dictionary<string, Tuple<int, int>> carsCollection = new Dictionary<string, Tuple<int, int>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] car = Console.ReadLine().Split("|");
                string model = car[0];
                int mileage = int.Parse(car[1]);
                int fuel = int.Parse(car[2]);
                Tuple<int, int> fuelMileage = Tuple.Create(fuel, mileage);
                carsCollection.Add(model, fuelMileage);
            }
            string input;
            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] cmdArgs = input.Split(" : ");
                string cmd = cmdArgs[0];
                string car = cmdArgs[1];
                if (cmd == "Drive")
                {
                    int distance = int.Parse(cmdArgs[2]);
                    int needenFuel = int.Parse(cmdArgs[3]);
                    int currFuel = carsCollection[car].Item1;
                    int currMileage = carsCollection[car].Item2;
                    if (currFuel < needenFuel)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        currFuel -= needenFuel;
                        currMileage += distance;
                        Tuple<int, int> tuple = Tuple.Create(currFuel, currMileage);
                        carsCollection[car] = tuple;
                        Console.WriteLine($"{car} driven for {distance} kilometers. {needenFuel} liters of fuel consumed.");
                        if (currMileage >= maxCarMileage)
                        {
                            carsCollection.Remove(car);
                            Console.WriteLine($"Time to sell the {car}!");
                        }
                    }
                }
                else if (cmd == "Refuel")
                {
                    int fuel = int.Parse(cmdArgs[2]);
                    int currFuel = carsCollection[car].Item1;
                    int needenFuel = maxCarTank - currFuel; 
                    int currMileage = carsCollection[car].Item2;
                    if (fuel >= needenFuel)
                    {
                        Tuple<int, int> tuple = Tuple.Create(maxCarTank, currMileage);
                        carsCollection[car] = tuple;
                        Console.WriteLine($"{car} refueled with {needenFuel} liters");
                    }
                    else
                    {
                        needenFuel = fuel + currFuel;
                        Tuple<int, int> tuple = Tuple.Create(needenFuel, currMileage);
                        carsCollection[car] = tuple;
                        Console.WriteLine($"{car} refueled with {fuel} liters");
                    }
                }
                else
                {
                    int kilometers = int.Parse(cmdArgs[2]);
                    int currFuel = carsCollection[car].Item1;
                    int currMileage = carsCollection[car].Item2;
                    currMileage -= kilometers;
                    if (currMileage<10000)
                    {
                        currMileage = 10000;
                    }
                    else
                    {
                        Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                    }
                    Tuple<int, int> tuple = Tuple.Create(currFuel, currMileage);
                    carsCollection[car] = tuple;

                }
            }
            foreach (var car in carsCollection)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value.Item2} kms, Fuel in the tank: {car.Value.Item1} lt.");
            }
        }
    }
}

