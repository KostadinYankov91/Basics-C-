using System;
using System.Collections;
using System.Collections.Generic;

namespace matchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            Stack<int> bracketIndicies = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    bracketIndicies.Push(i);
                }
                if (input[i] == ')')
                {
                    int startIndex = bracketIndicies.Pop();
                    Console.WriteLine(input.Substring(startIndex, i - startIndex + 1));
                }
            }
        }
    }
}
