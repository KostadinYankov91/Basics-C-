using System;
using System.Collections.Generic;
using System.Linq;

namespace customStack
{
    class Program
    {
        static void Main(string[] args)
        {
            string arguments = Console.ReadLine();
            List<int> nums = arguments.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Skip(1).ToList();

            MyStackTest<int> stack = new MyStackTest<int>();
            string[] commands = arguments.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string primeCommand = commands[0];
            while (primeCommand != "END")
            {
                switch (primeCommand)
                {
                    case "Push":
                        foreach (int item in nums)
                        {
                            stack.Push(item);
                        }
                        break;
                    case "Pop":
                        stack.Pop();
                        break;
                    case "END":
                        foreach (int item in stack)
                        {

                        }
                        break;
                }
            }

        }
    }
}
