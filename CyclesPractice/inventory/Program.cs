using System;
using System.Collections.Generic;
using System.Linq;

namespace inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(", ").ToList();

            string input = Console.ReadLine();

            while (input != "Craft!")
            {
                string[] arguments = input.Split(new string[] { " - ", ":" }, StringSplitOptions.RemoveEmptyEntries);
                string command = arguments[0];
                string material = arguments[1];
                string newMaterial = string.Empty;

                if (arguments.Length > 2)
                {
                    newMaterial = arguments[2];
                }

                if (command == "Collect")
                {
                    if (!items.Contains(material))
                    {
                        items.Add(material);
                    }
                   
                }
                if (command == "Drop")
                {
                    if (items.Contains(material))
                    {
                        items.Remove(material);
                    }
                }
                else if (command == "Combine Items")
                {
                    if (items.Contains(material))
                    {
                        int oldItemIndex = items.FindIndex(x => x == material);
                        items.Insert(oldItemIndex + 1, newMaterial);
                    }
                   
                }
                else if (command == "Renew")
                {
                    if (items.Contains(material))
                    {
                        int itemToRenew = items.FindIndex(x => x == material);
                        items.Add(material);
                        items.RemoveAt(itemToRenew);
                    }
                }

                input = Console.ReadLine();

            }

            Console.WriteLine(string.Join(", ", items));

        }
    }
}
