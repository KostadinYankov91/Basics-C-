using System;
using System.Collections.Generic;
using System.Linq;

namespace appendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
                                 .Split("|")
                                 .ToList();

            items.Reverse();
            List<string> result = new List<string>();

            foreach (string currentItem in items)
            {
                string[] numbers = currentItem.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                foreach (string number in numbers)
                {
                    result.Add(number);
                }
            }

            Console.WriteLine(string.Join(" ", result));

        }
    }
}
