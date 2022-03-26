using ShopingCar;
using System;
using System.IO;

namespace Project_21b
{
    class Program
    {
        static void Main(string[] args)
        {


            
            

           
            




            //DirectoryInfo[] cDirs = new DirectoryInfo(@"c:\").GetDirectories();             
            //Write each directory name to a file.
            /*using (StreamWriter sw = new StreamWriter("text1.txt"))
            {
                foreach (DirectoryInfo dir in cDirs)
                { sw.WriteLine(dir.Name); }
            }
            string line = ""; using (StreamReader sr = new StreamReader("text1.txt"))
            {
                while
                 ((line = sr.ReadLine()) != null)
                { Console.WriteLine(line); }
            }*/
            /* int s = int.Parse(Console.ReadLine());
             if (s==1)
             {
                 Car car1 = new Car() { Brand="Audi", Value = 30000, Year = 2016, Millage=10000 };
                 Console.WriteLine($"{car1.Brand}: {car1.Millage} km, {car1.GetPrice} ");
             }
             else if (s==2)
             {
                 Truck truck1 = new Truck() {  Brand="Volvo", Value = 100000, Year = 2006, Millage=10000, Tonnage=14 };
                 Console.WriteLine($"{truck1.Brand}: {truck1.Millage} km, {truck1.GetPrice} ");
             }*/
        }
    }
}