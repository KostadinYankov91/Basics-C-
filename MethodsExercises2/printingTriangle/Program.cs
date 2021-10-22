using System;
using System.ComponentModel.DataAnnotations;

namespace printingTriangle
{
    class Program
    {
        static void PrintLine(int start = 1, int end = 100)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = start; i < n; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }

        static void PrintTriangle(int n)
        {

            for (int line = 1; line <= n; line++)
            {
                PrintLine(1, line);
            }

            for (int line = n - 1; line >= 1; line--)
            {
                PrintLine(1, line);
            }
        }
    }
}
