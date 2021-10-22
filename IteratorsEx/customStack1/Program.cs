using System;
using System.Linq;

namespace customStack1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> myStack = new MyStack<int>();

            string arguments;

            while ((arguments = Console.ReadLine()) != "END")
            {
                //string[] commandData = arguments.Split(" ");
                string[] commandDataFixed = arguments.Split(new string[] {" ",", "}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = commandDataFixed[0];

                switch (command)
                {
                    case "Push":
                        for (int i = 1; i < commandDataFixed.Length; i++)
                        {
                            int item = int.Parse(commandDataFixed[i]);
                            myStack.Push(item);
                        }
                        break;
                    case "Pop":
                        try
                        {
                            myStack.Pop();
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                }
            }

            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }
             foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }

        }
    }
}
