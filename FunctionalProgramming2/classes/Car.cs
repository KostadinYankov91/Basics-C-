using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }

        public Car(string make, string model, int year)
            : this()
        {
            Make = make;
            Model = model;
            Year = year;

        }

        public Car(string mark, string model, int year, double fuelQuan, double fuelConsum)
            :this(mark, model, year)
        {
            FuelQuantity = fuelQuan;
            FuelConsumption = fuelConsum;
        
        }
        public Car(string mark, string model, int year, double fuelQuan, double fuelConsum,
            Engine engine, Tire[] tires)
            : this(mark, model, year, fuelQuan, fuelConsum)
        {
            Engine = engine;
            Tires = tires;

        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelConsumption { get; set; }
        public double FuelQuantity { get; set; }

        public Engine Engine { get; set; }
        public Tire[] Tires { get; set; }
        public void Drive(double distance)
        {
            double fuelToConsume = distance * FuelConsumption;
        
            if (FuelQuantity - fuelToConsume >= 0)
            {
                FuelQuantity -= fuelToConsume;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip");
            }
        }
        public string WhoAmI()
        {
            return $"Mark: {Make}\nModel: {Model}\nYear: {Year}\nFuel: {FuelQuantity:F2}L";
        }


    }
}
