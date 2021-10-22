using System;

namespace FruitStore
{
    class Program
    {
        static void Main()
        {

            // read input
            double strawberryCost = double.Parse(Console.ReadLine());
            double bananaKg = double.Parse(Console.ReadLine());
            double orangeKg = double.Parse(Console.ReadLine());
            double rasberryKg = double.Parse(Console.ReadLine());
            double strawberryKg = double.Parse(Console.ReadLine());

            // calculation
            double rasberryCost = strawberryCost / 2;
            double orangeCost = rasberryCost - (rasberryCost * 0.4);
            double bananaCost = rasberryCost - (rasberryCost * 0.8);
            double moneyNeeded = bananaKg * bananaCost + orangeKg * orangeCost + rasberryKg * rasberryCost + strawberryKg * strawberryCost;

            // print output
            Console.WriteLine(moneyNeeded);

        }       
    }
}