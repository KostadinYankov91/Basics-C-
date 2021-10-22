using System;
using System.Collections.Generic;
using System.Linq;

namespace maximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int queriesCount = int.Parse(Console.ReadLine());

            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < queriesCount; i++)
            {
                string[] n = Console.ReadLine().Split().ToArray();

                if (n.Length > 1)
                {
                    if (int.Parse(n[0]) == 1)
                    {
                        numbers.Push(int.Parse(n[1]));
                    }
                }
                else if (int.Parse(n[0]) == 2)
                {
                    if (numbers.Count > 0)
                    {
                        numbers.Pop();
                    }
                }
                else if (int.Parse(n[0]) == 3)
                {
                    Console.WriteLine(numbers.Max());
                }
                else if (int.Parse(n[0]) == 4)
                {
                    Console.WriteLine(numbers.Min());
                }

            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
