using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace computerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<double> items = new List<double>();
            double sum = 0.0;
            string input = Console.ReadLine();

            while (input != "special" && input != "regular")
            {
                double price = double.Parse(input);
                //items.Add(price);
                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    sum += price;
                }

                input = Console.ReadLine();

            }
            if (sum == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {

                double taxes = sum * 0.2;
                double priceSpecial = 0;
                double priceWithTaxes = sum + sum * 0.2;

                if (input == "special")
                {
                    priceSpecial = priceWithTaxes - priceWithTaxes * 0.1;
                    Console.WriteLine($"Congratulations you've just bought a new computer!\n" +
                        $"Price without taxes: {sum:f2}$\n" +
                        $"Taxes: {taxes:f2}$\n" +
                        $"-----------\n" +
                        $"Total price: {priceSpecial:f2}$");
                }
                else if (input == "regular")
                {
                    Console.WriteLine($"Congratulations you've just bought a new computer!\n" +
                       $"Price without taxes: {sum:f2}$\n" +
                       $"Taxes: {taxes:f2}$\n" +
                       $"-----------\n" +
                       $"Total price: {priceWithTaxes:f2}$");
                }
            }
        }
    }
}

