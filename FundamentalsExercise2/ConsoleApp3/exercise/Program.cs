using System;

namespace exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0.00;
            double totalPrice = 0.00;

            switch (type)
            {
                case "Students":
                    if (day == "Friday")
                    {
                        price = 8.45;
                        totalPrice = number * price;
                    }
                    else if (day == "Saturday")
                    {
                        price = 9.80;
                        totalPrice = number * price;
                    }
                    else if (day == "Sunday")
                    {
                        price = 10.46;
                        totalPrice = number * price;
                    }
                    if (number >= 30)
                    {
                        totalPrice = totalPrice - totalPrice * 0.15;
                        break;
                    }
                    break;
                case "Business":
                    if (number >= 100)
                    {
                        number -= 10;
                    }
                    if (day == "Friday")
                    {
                        price = 10.90;
                        totalPrice = number * price;
                    }
                    else if (day == "Saturday")
                    {
                        price = 15.60;
                        totalPrice = number * price;
                    }
                    else if (day == "Sunday")
                    {
                        price = 16;
                        totalPrice = number * price;
                    }
                    break;
                case "Regular":
                    if (day == "Friday")
                    {
                        price = 15;
                        totalPrice = number * price;
                    }
                    else if (day == "Saturday")
                    {
                        price = 20;
                        totalPrice = number * price;
                    }
                    else if (day == "Sunday")
                    {
                        price = 22.50;
                        totalPrice = number * price;
                    }
                    if (number >= 10 && number <= 20)
                    {
                        totalPrice = totalPrice - totalPrice * 0.05;
                    }
                    break;
                default:
                    break;
            }

            Console.WriteLine($"Total price: {totalPrice:F2}");



        }
    }
}
