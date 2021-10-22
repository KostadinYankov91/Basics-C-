using System;

namespace digitsLettersNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] symbols = input.ToCharArray();
            if (true)
            {

            }
            foreach (var item in symbols)
            {
                if (Char.IsDigit(item))
                {
                    Console.Write(item);
                }
            }
            Console.WriteLine();
            foreach (var item in symbols)
            {
                if (Char.IsLetter(item))
                {
                    Console.Write(item);
                }
            }
            Console.WriteLine();
            foreach (var item in symbols)
            {
                if (!Char.IsDigit(item) && !Char.IsLetter(item))
                {
                    Console.Write(item);
                }
            }
        }
    }
}
