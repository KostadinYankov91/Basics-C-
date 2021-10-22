using System;
using System.Collections.Generic;
using System.Linq;

namespace muOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialHealth = 100;
            int initialBitCoins = 0;
            int bestRoom = 0;
            int damageTaken = 0;

            List<string> rooms = Console.ReadLine().Split("|").ToList();

            foreach (string room in rooms)
            {
                bestRoom++;
                string[] argument = room.Split();
                string command = argument[0];
                int value = int.Parse(argument[1]);

                if (command == "potion")
                {
                    damageTaken = 100 - initialHealth;
                    initialHealth += value;

                    if (damageTaken < value)
                    {
                        value = damageTaken;
                    }
                    if (initialHealth > 100)
                    {
                        initialHealth = 100;
                    }
                    Console.WriteLine($"You healed for {value} hp.");
                    Console.WriteLine($"Current health: {initialHealth} hp.");
                }
                else if (command == "chest")
                {
                    initialBitCoins += value;
                    Console.WriteLine($"You found {value} bitcoins.");
                }
                else
                {
                    initialHealth -= value;
                    if (initialHealth > 0)
                    {
                        Console.WriteLine($"You slayed {command}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {bestRoom}");
                        return;
                    }
                }
            }

            Console.WriteLine($"You've made it!\nBitcoins: {initialBitCoins}\nHealth: {initialHealth}");
        }
    }
}
