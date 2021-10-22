using System;
using System.Linq;
using System.Collections.Generic;

namespace listManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (command[0].ToUpper() != "END")
            {
                switch (command[0].ToUpper())
                {
                    case "ADD":
                        nums.Add(int.Parse(command[1]));
                        break;
                    case "REMOVE":
                        nums.Remove(int.Parse(command[1]));
                        break;
                    case "REMOVEAT":
                        nums.RemoveAt(int.Parse(command[1]));
                        break;
                    case "INSERT":
                        nums.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                    default:
                        break;

                }

                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
