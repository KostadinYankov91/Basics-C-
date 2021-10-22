using System;
using System.Collections.Generic;

namespace repeatSTrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string reuslt;

            string input = Console.ReadLine();

            string[] arguments = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in arguments)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    Console.Write(word);
                }
            }
        }
    }
}
