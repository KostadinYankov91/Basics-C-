using System;
using System.Collections.Generic;
using System.Linq;

namespace stachSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(numbers);

            string[] command = Console.ReadLine().ToUpper().Split();

            while (command[0] != "END")
            {
                if (command[0] == "ADD")
                {
                    stack.Push(int.Parse(command[1]));
                    stack.Push(int.Parse(command[2]));
                }
                if (command[0] == "REMOVE")
                {
                    var count = int.Parse(command[1]);

                    if (count <= stack.Count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stack.Pop();
                        }
                    }
                }

                command = Console.ReadLine().ToUpper().Split();

            }

            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
