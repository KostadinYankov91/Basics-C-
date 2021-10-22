using System;
using System.Collections.Generic;
using System.Linq;

namespace groceryList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine().Split("!").ToList();

            string input;

            while ((input = Console.ReadLine()) != "Go Shopping!")
            {
                string[] tokens = input.Split();
                string command = tokens[0];
                string item = tokens[1];

                if (command == "Urgent")
                {
                    if (!groceries.Contains(item))
                    {
                        groceries.Insert(0, item);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command == "Unnecessary")
                {
                    if (groceries.Contains(item))
                    {
                        groceries.Remove(item);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command == "Correct")
                {
                    if (groceries.Contains(item))
                    {
                        string newItem = tokens[2];
                        int index = groceries.FindIndex(x => x == item);
                        groceries.Insert(index, newItem);
                        groceries.RemoveAt(index + 1);
                                                    
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command == "Rearrange")
                {
                    if (groceries.Contains(item))
                    {
                        int index = groceries.FindIndex(x => x == item);
                        groceries.Add(item);
                        groceries.RemoveAt(index);
                    }
                    else
                    {
                        continue;
                    }
                }


            }

            Console.WriteLine(string.Join(", ", groceries));
            
        }
    }
}
