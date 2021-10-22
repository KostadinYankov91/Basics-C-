using System;
using System.Collections.Generic;
using System.Linq;

namespace stacksAndQueuesEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = data[0];
            int s = data[1];
            int x = data[2];

            int[] numbersInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                numbers.Push(numbersInput[i]);
            }
            for (int i = 0; i < s; i++)
            {
                numbers.Pop();
            }

            if (numbers.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                int smallest = int.MaxValue;
                foreach (int number in numbers)
                {
                    if (number < smallest)
                    {
                        smallest = number;
                    }
                }
                if (smallest != int.MaxValue)
                {
                    Console.WriteLine(smallest);
                }
            }
            if (numbers.Count < 1)
            {
                Console.WriteLine("0");
            }

        }
    }
}
