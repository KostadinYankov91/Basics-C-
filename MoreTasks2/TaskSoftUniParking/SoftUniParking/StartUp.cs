using System;

namespace SoftUniParking
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var car = new Car("Audi", "A6", 200, "wa1234ca");
            var carTwo = new Car("Audi", "A4", 300, "aa1234be");
            
            var parking = new Parking(5);
            Console.WriteLine(parking.AddCar(car));
            Console.WriteLine(parking.AddCar(car));
            Console.WriteLine(parking.AddCar(carTwo));

            Console.WriteLine(parking.GetCar("aa1234be"));
            Console.WriteLine(parking.RemoveCar("aa1234be"));

            Console.WriteLine(parking.Count);
        }
    }
}
