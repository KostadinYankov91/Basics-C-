using System;
using System.Collections.Generic;
using System.Linq;

namespace deckOfCards
{
    class Program
    {

        static void Main(string[] args)
        {

            List<string> vehicles = Console.ReadLine().Split(", ").ToList();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string[] arguments = input.Split(", ");

                string command = arguments[0];
                string tokenOne = arguments[1];
                if (arguments.Length > 2)
                {
                    string tokentwo = arguments[2];

                    if (command == "Insert")
                    {
                        int index = int.Parse(tokenOne);

                        if (index > vehicles.Count - 1 || index < 0)
                        {
                            Console.WriteLine("Index out of range");
                        }
                        if (index > -1 && index <= vehicles.Count - 1
                            && vehicles.Contains(tokentwo))
                        {
                            Console.WriteLine("Card is already bought");
                        }
                        else if (index > -1 && index <= vehicles.Count - 1
                            && !vehicles.Contains(tokentwo))
                        {
                            vehicles.Insert(index, tokentwo);
                            Console.WriteLine("Card successfully bought");
                        }

                    }
                    else
                    {
                        continue;
                    }
                }


                if (command == "Add")
                {
                    if (!vehicles.Contains(tokenOne))
                    {
                        vehicles.Add(tokenOne);
                        Console.WriteLine("Card successfully bought");
                    }
                    else
                    {
                        Console.WriteLine("Card is already bought");
                    }
                }
                else if (command == "Remove")
                {
                    if (vehicles.Contains(tokenOne))
                    {
                        vehicles.Remove(tokenOne);
                        Console.WriteLine("Card successfully sold");
                    }
                    else
                    {
                        Console.WriteLine("Card not found");
                    }
                }
                else if (command == "Remove At")
                {
                    int index = int.Parse(tokenOne);
                    if (index < 0 || index > vehicles.Count - 1)
                    {
                        Console.WriteLine("Index out of range");
                        continue;
                    }
                    else if (index > -1 && index <= vehicles.Count - 1)
                    {
                        vehicles.RemoveAt(index);
                        Console.WriteLine("Card successfully sold");
                    }
                }
            }

            Console.WriteLine(string.Join(", ", vehicles));
        }
    }
}
