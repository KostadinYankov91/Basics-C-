using System;
using System.Collections.Generic;
using System.Linq;

namespace easterGifts
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> gifts = Console.ReadLine().Split().ToList();

            string input = Console.ReadLine();
            int indexToRemove = 0;

            while (input != "No Money")
            {
                string[] arguments = input.Split();

                string command = arguments[0];
                string gift = arguments[1];

                if (arguments.Length > 2)
                {
                    indexToRemove = int.Parse(arguments[2]);
                }

                if (command == "Required")
                {
                    if (indexToRemove < gifts.Count && indexToRemove > -1)
                    {
                        gifts.Insert(indexToRemove, gift);
                        gifts.RemoveAt(indexToRemove + 1);
                    }

                }
                else if (command == "OutOfStock")
                {
                    if (gifts.Contains(gift))
                    {
                        //int index = gifts.FindIndex(x => x == gift);

                        for (int i = 0; i < gifts.Count - 1; i++)
                        {
                            if (gifts[i] == gift)
                            {
                                indexToRemove = gifts.FindIndex(x => x == gifts[i]);
                                gifts.Insert(indexToRemove, "None");
                                gifts.RemoveAt(indexToRemove + 1);

                            }
                        }

                    }

                }
                else if (command == "JustInCase")
                {
                    gifts.RemoveAt(gifts.Count - 1);
                    gifts.Add(gift);
                }

                input = Console.ReadLine();

            }


            gifts.RemoveAll(x => x == "None");
            Console.WriteLine(string.Join(" ", gifts));

        }
    }
}
