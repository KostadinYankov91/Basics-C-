using System;
using System.Collections.Generic;
using System.Linq;

namespace easterShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shops = Console.ReadLine().Split().ToList();

            int n = int.Parse(Console.ReadLine());
    
            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();
                string[] arguments = input.Split(' ');

                string command = arguments[0];
                string shop = arguments[1];
                if (command == "Include")
                {
                    shops.Add(shop);
                }
                else if (command == "Visit")
                {
                    int numberOfShops = int.Parse(arguments[2]);

                    if (numberOfShops <= shops.Count)
                    {
                        if (shop == "first")
                        {
                            for (int l = 1; l <= numberOfShops; l++)
                            {
                                shops.RemoveAt(0);
                            }
                            //shops.RemoveAt(1);
                            //shops.RemoveAt(0);


                        }
                        else if (shop == "last")
                        {
                            for (int l = 1; l <= numberOfShops; l++)
                            {
                                shops.RemoveAt(shops.Count - 1);
                            }

                            //shops.RemoveAt(shops.Count - 2);
                            //shops.RemoveAt(shops.Count - 1);
                        }
                       
                    }
                }
                else if (command == "Prefer")
                {
                    int firstIndex = int.Parse(arguments[1]);
                    int secondIndex = int.Parse(arguments[2]);

                    if (firstIndex < shops.Count && secondIndex < shops.Count 
                        && firstIndex > -1 && secondIndex > -1)
                    {
                        string temp = shops[firstIndex];
                        shops[firstIndex] = shops[secondIndex];
                        shops[secondIndex] = temp;
                    }

                }
                else if (command == "Place")
                {
                    int shopIndex = int.Parse(arguments[2]);
                    if (shopIndex + 1 <= shops.Count - 1 && shopIndex > -1)
                    {
                        shops.Insert(shopIndex + 1, shop);
                    }
                    else if (shopIndex == shops.Count - 1)
                    {
                        shops.Add(shop);
                    }
                }

            }

            Console.WriteLine("Shops left:\n" +
                    string.Join(" ", shops)); 
        }
    }
}
