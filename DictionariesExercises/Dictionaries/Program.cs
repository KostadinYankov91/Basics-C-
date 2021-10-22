using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {


            Dictionary<char, int> letters = new Dictionary<char, int>();
            char[] input = Console.ReadLine().ToCharArray();

            foreach (var letter in input)
            {
                if (letter != ' ')
                {
                    if (!letters.ContainsKey(letter))
                    {
                        letters.Add(letter, 0);
                    }
                    letters[letter]++;
                }
            }

            foreach (var c in letters)
            {
                char currentKey = c.Key;
                int currentValue = c.Value;

                Console.WriteLine($"{currentKey} -> {currentValue}");
            }
        }
    }
}
