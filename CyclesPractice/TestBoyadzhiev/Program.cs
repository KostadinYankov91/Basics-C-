using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace TestBoyadzhiev
{
    class Program
    {
        static List<string> shops = new List<string>();
        static int commandsCount;

        //public int MyProperty { get; set; }
        static void Include(string shop)
        {
            shops.Add(shop);
        }
        
        static void Visit(bool first, int numberOfShops)
        {
            if (first)
            {
                shops.RemoveRange(0, numberOfShops);
            }
            else
            {
                for (int i = 0; i < numberOfShops; i++)
                {
                    shops.RemoveAt(shops.Count - 1);
                }
                //shops.RemoveRange(shops.Count - 1 - numberOfShops, numberOfShops);
            }
        }

        static void Prefer(int i, int j)
        {
            string temp = shops[i];
            shops[i] = shops[j];
            shops[j] = temp;
        }

        static void Place(string shop, int i)
        {
            shops.Insert(i + 1, shop);
        }

        static void Main(string[] args)
        {

            List<string> command = new List<string>();
            //Console.WriteLine("Hello World!");
            shops = Console.ReadLine().Split().ToList();
            commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                command = Console.ReadLine().Split().ToList();

                if (command[0] == "Include")
                {
                    Include(command[1]);
                }
                else if(command[0] == "Visit")
                {
                    if (int.Parse(command[2]) < shops.Count) 
                    {
                        Visit((command[1] == "first") ? true : false, int.Parse(command[2]));
                    }                    
                }
                else if (command[0] == "Prefer")
                {
                    if (shops.Count > int.Parse(command[1]) 
                        && shops.Count > int.Parse(command[2])
                        && int.Parse(command[1]) >= 0
                        && int.Parse(command[2]) >= 0)
                    {
                        Prefer(int.Parse(command[1]), int.Parse(command[2]));
                    }
                    
                }
                else if (command[0] == "Place") 
                {
                    if (int.Parse(command[2]) + 1 <= shops.Count - 1 && int.Parse(command[2]) >= 0)
                    {
                        Place(command[1], int.Parse(command[2]));
                    }
                    else if (int.Parse(command[2]) == shops.Count - 1)
                    {
                        shops.Add(command[1]);
                    }
                }
            }
            
            Console.WriteLine("Shops left:\n" + string.Join(' ', shops));
        }
    }
}
