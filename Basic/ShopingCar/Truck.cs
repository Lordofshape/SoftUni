using Project_21b;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingCar
{
    public class Truck : Car
    {
        public int Tonnage { get; set; }

        public override double GetPrice()
        {
            int age = DateTime.Now.Year - Year;
            if (age <= 5)
            {
                double v = Value;
                return v;
            }
            else if (age>5&&Tonnage<=5)
            {
                double v = Value *= 0.7;
                return v;
            }
            else if (age>5&&Tonnage<=10)
            {
                double v = Value *= 0.4;
                return v;
            }
            else if (age>5&&Tonnage>10)
            {
                double v = Value *= 0.2;
                return v;
            }
            else
            {
                return Value;
            }
            
        }

    }
}

