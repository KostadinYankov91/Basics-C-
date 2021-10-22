using System;

namespace charsInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());

            PrintRange(first, second);
        }

        private static void PrintRange(char first, char second)
        {
            if (first > second)
            {
                char firstChar = first;
                first = second;
                second = firstChar;
            }
            
            for (int i = first + 1; i < second; i++)
            {

                Console.Write($"{(Char)i} ");
            }
        }


    }
}
