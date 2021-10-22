using System;
using System.Collections.Generic;
using System.Linq;

namespace heartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> neighborhood = Console.ReadLine().Split("@").ToList();

            string input = Console.ReadLine();
            int lastIndexVisited = 0;

            while (input != "Love!")
            {
                string[] arguments = input.Split();

                int jumpLenght = int.Parse(arguments[1]);
                lastIndexVisited += jumpLenght;

                if (lastIndexVisited < neighborhood.Count)
                {
                    int currentIndex = int.Parse(neighborhood[lastIndexVisited]);

                    if (currentIndex == 0)
                    {
                        Console.WriteLine($"Place {lastIndexVisited} already had Valentine's day.");

                    }

                    else if (currentIndex > 1)
                    {
                        currentIndex -= 2;
                    }

                    if (currentIndex == 0)
                    {
                        Console.WriteLine($"Place {lastIndexVisited} has Valentine's day.");
                    }

                }
                else
                {
                    int againAtIndexZero = int.Parse(neighborhood[0]);
                    int againAtZeroLastValue = againAtIndexZero;
                    lastIndexVisited = 0;
                    if (againAtZeroLastValue > 1)
                    {
                        againAtZeroLastValue -= 2;
                        if (againAtZeroLastValue == 0)
                        {
                            Console.WriteLine($"Place {lastIndexVisited} has Valentine's day.");
                        }
                    }
                    else if (againAtZeroLastValue > 0)
                    {
                        neighborhood.Insert(lastIndexVisited, againAtZeroLastValue.ToString());
                        neighborhood.RemoveAt(lastIndexVisited + 1);
                    }

                }

                input = Console.ReadLine();

            }

            int counterLoved = 0;
            int counterNotLoved = 0;
            foreach (string house in neighborhood)
            {
                int houseValue = int.Parse(house);
                if (houseValue == 0)
                {
                    counterLoved++;
                }
                else
                {
                    counterNotLoved++;
                }
            }

            Console.WriteLine($"Cupid's last position was {lastIndexVisited}.");

            if (counterLoved == neighborhood.Count)
            {
                Console.WriteLine("Mission was successful.");
            }
            else if (counterLoved < neighborhood.Count)
            {
                Console.WriteLine($"Cupid has failed {counterNotLoved} places.");
            }

        }
    }
}
