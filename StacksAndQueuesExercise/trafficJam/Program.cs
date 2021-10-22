using System;
using System.Collections.Generic;

namespace trafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenPass = int.Parse(Console.ReadLine());
            string command;
            int count = 0;
            Queue<string> cars = new Queue<string>();

            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < greenPass; i++)
                    {
                        if (cars.Count > 0)
                        {
                            Console.WriteLine(cars.Dequeue() + " passed!");
                            count++;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }
            }

            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
