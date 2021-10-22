using System;
using System.Collections.Generic;
using System.Linq;

namespace shoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split('!').ToList();

            string input = Console.ReadLine();
            string newItem = string.Empty;

            while (input != "Go Shopping!")
            {
                string[] arguments = input.Split();
                string command = arguments[0];
                string item = arguments[1];
                
                if (arguments.Length > 2)
                {
                    newItem = arguments[2];
                }

                if (command == "Urgent")
                {
                    if (!items.Contains(item))
                    {
                        items.Insert(0, item);
                    }
                   
                }
                else if (command == "Unnecessary")
                {
                    if (items.Contains(item))
                    {
                        items.Remove(item);
                    }
                }
                else if (command == "Correct")
                {
                    if (items.Contains(item))
                    {
                        int indexToCorrect = items.FindIndex(x => x == item);
                        items.Insert(indexToCorrect, newItem);
                        items.RemoveAt(indexToCorrect + 1);
                    }
                }
                else if (command == "Rearrange")
                {
                    if (items.Contains(item))
                    {
                        int indexToCorrect = items.FindIndex(x => x == item);
                        items.Add(item);
                        items.RemoveAt(indexToCorrect);
                    }
                }

                input = Console.ReadLine();

            }

            Console.WriteLine(string.Join(", ", items));
        }
    }
}
