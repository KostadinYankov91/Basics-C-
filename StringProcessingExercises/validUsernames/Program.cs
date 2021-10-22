using System;
using System.Collections.Generic;
using System.Linq;

namespace validUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            for (int i = 0; i < input.Length; i++)
            {
                var cur = input[i];
                if (IsValid(cur))
                {
                    Console.WriteLine(cur);
                }
            }
        }

        public static bool IsValid(string current)
        {
            return current.Length >= 3 &&
                   current.Length <= 15 &&
                   current.All(c => char.IsLetterOrDigit(c)) ||
                   current.Contains("-") || current.Contains("_");
        }
    }
}
