using System;
using System.Net.Http.Headers;

namespace vendingMach
{
    class Program
    {
        static void Main(string[] args)
        {
            string moneyReceived = Console.ReadLine();
            double insertedMoney = 0;


            while (moneyReceived != "Start")
            {
                double currentCoin = double.Parse(moneyReceived);
                bool validCoin = currentCoin == 2 ||
                    currentCoin == 0.5 ||
                    currentCoin == 0.2 ||
                    currentCoin == 0.1 ||
                    currentCoin == 1;

                if (validCoin)
                {
                    insertedMoney += currentCoin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {currentCoin}");
                }

                moneyReceived = Console.ReadLine();
            }

            string product = Console.ReadLine();

            while (product != "End")
            {
                double productPrice = 0;

                switch (product)
                {
                    case "Nuts":
                        productPrice = 2.0;
                        break;
                    case "Water":
                        productPrice = 0.7;
                        break;
                    case "Crisps":
                        productPrice = 1.5;
                        break;
                    case "Soda":
                        productPrice = 0.8;
                        break;
                    case "Coke":
                        productPrice = 1.0;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        product = Console.ReadLine();
                        continue;
                }

                if (productPrice <= insertedMoney)
                {
                    insertedMoney -= productPrice;
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                product = Console.ReadLine();
            }

            Console.WriteLine($"Change: {insertedMoney:F2}");
        }
    }
}
