using System;
using System.Collections.Generic;
using System.Linq;

namespace lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());

            List<int> wagons = Console.ReadLine()
                                  .Split()
                                  .Select(int.Parse)
                                  .ToList();

            for (int i = 0; i < wagons.Count; i++)
            {
                int currentWagonSpace = wagons[i];

                if (currentWagonSpace == 4)
                {
                    continue;
                } 
                else if (currentWagonSpace < 4)
                {
                    for (int l = currentWagonSpace; l < 4; l++)
                    {
                        people--;
                        if (people == 0)
                        {
                            Console.WriteLine($"The lift has empty spots!\n" +
                                $"{string.Join(" ", wagons)}");
                        }

                        currentWagonSpace++;
                    }

                    int currentIndex = wagons.FindIndex(x => x == wagons[i]);
                    wagons.RemoveAt(currentIndex);
                    wagons.Insert(currentIndex, currentWagonSpace);
                }
            }

            if (people > 0)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!\n" +
                    $"{string.Join(" ", wagons)}");

            }

            /*
            for (int i = 0; i < wagons.Count; i++)
            {
                int currentElevatorSpace = wagons[i];

                while (currentElevatorSpace < 4)
                {
                    if (currentElevatorSpace == 0)
                    {
                        for (int j = currentElevatorSpace; j <= 4; j++)
                        {
                            people--;
                            if (people == 0)
                            {
                                currentElevatorSpace++;
                                wagons[i] = currentElevatorSpace;
                                Console.WriteLine($"The lift has empty spots!\n" +
                                    $"{string.Join(" ", wagons)}");
                                break;
                            }
                        }

                    }
                    else if (currentElevatorSpace > 0 && currentElevatorSpace < 4)
                    {
                        for (int l = currentElevatorSpace; l <= 4; l++)
                        {
                            people--;
                            if (people == 0)
                            {
                                Console.WriteLine($"The lift has empty spots!\n" +
                                    $"{string.Join(" ", wagons)}");
                                break;
                            }
                            else if (currentElevatorSpace == 4)
                            {
                                continue;
                            }
                            else if (currentElevatorSpace < 4)
                            {
                                currentElevatorSpace++;
                            }
                        }

                    }
                }

                else if (currentElevatorSpace == 4)
                {
                    continue;
                }


            }
            */

        }
    }
}
