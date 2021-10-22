using System;
using System.Collections.Generic;
using System.Linq;

namespace listManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> friends = Console.ReadLine().Split(", ").ToList();

            string input = Console.ReadLine();
            int blackListed = 0;
            int lost = 0;

            while (input != "Report")
            {
                string[] arguments = input.Split(' ');
                string command = arguments[0];
                string word = arguments[1];
                string wordTwo;

                if (arguments.Length > 2)
                {
                    wordTwo = arguments[2];

                    if (command == "Change")
                    {
                        int index = int.Parse(word);
                        if (index <= friends.Count - 1 && index > -1)
                        {
                            Console.WriteLine($"{friends[index]} changed his username to {wordTwo}.");
                            friends[index] = wordTwo;
                        }
                    }
                }

                 if (command == "Blacklist")
                {

                    if (friends.Contains(word))
                    {
                        int wordIndex = friends.IndexOf(word);
                        Console.WriteLine($"{word} was blacklisted.");
                        friends[wordIndex] = "Blacklisted";
                        blackListed++;
                    }
                    else
                    {
                        Console.WriteLine($"{word} was not found.");
                    }
                }
                else if (command == "Error")
                {
                    int index = int.Parse(word);
                    if (friends[index] != "Blacklisted" && friends[index] != "Lost")
                    {
                        Console.WriteLine($"{friends[index]} was lost due to an error.");
                        friends[index] = "Lost";
                        lost++;
                    }
                }

                input = Console.ReadLine();

            }

            Console.WriteLine($"Blacklisted names: {blackListed}");
            Console.WriteLine($"Lost names: {lost}");
            Console.WriteLine($"{string.Join(' ', friends)}");

        }
    }
}
