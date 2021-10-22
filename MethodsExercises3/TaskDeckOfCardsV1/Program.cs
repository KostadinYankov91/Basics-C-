using System;
using System.Collections.Generic;
using System.Linq;

namespace deckOfCards
{
    class Program
    {
        static List<string> cards = new List<string>();

        public static void InsertCard(int index, string tokentwo)
        {
            if (index > cards.Count - 1 || index < 0)
            {
                Console.WriteLine("Index out of range");
            }
            if (index > -1 && index <= cards.Count - 1
                && cards.Contains(tokentwo))
            {
                Console.WriteLine("Card is already bought");
            }
            else if (index > -1 && index <= cards.Count - 1
                && !cards.Contains(tokentwo))
            {
                cards.Insert(index, tokentwo);
                Console.WriteLine("Card successfully bought");
            }

        }

        static void Main(string[] args)
        {

            cards = Console.ReadLine().Split(", ").ToList();

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

                        cards.

                    }
                    else
                    {
                        continue;
                    }
                }


                if (command == "Add")
                {
                    if (!cards.Contains(tokenOne))
                    {
                        cards.Add(tokenOne);
                        Console.WriteLine("Card successfully bought");
                    }
                    else
                    {
                        Console.WriteLine("Card is already bought");
                    }
                }
                else if (command == "Remove")
                {
                    if (cards.Contains(tokenOne))
                    {
                        cards.Remove(tokenOne);
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
                    if (index < 0 || index > cards.Count - 1)
                    {
                        Console.WriteLine("Index out of range");
                        continue;
                    }
                    else if (index > -1 && index <= cards.Count - 1)
                    {
                        cards.RemoveAt(index);
                        Console.WriteLine("Card successfully sold");
                    }
                }
            }

            Console.WriteLine(string.Join(", ", cards));
        }
    }
}
