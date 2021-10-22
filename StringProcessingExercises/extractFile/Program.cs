using System;
using System.Linq;

namespace extractFile
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(@"\");

            string file = input.Last();
            string[] lastFile = file.Split(".");

            Console.WriteLine($"File name: {lastFile[0]}");
            Console.WriteLine($"File extension: {lastFile[1]}");

        }
    }
}
