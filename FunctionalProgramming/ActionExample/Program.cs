using System;

namespace ActionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> printer = PrintSomething;

            printer(Console.ReadLine());
        }

        static void PrintSomething(string msg)
        {
            Console.WriteLine(msg);
        }

        
    }
}
