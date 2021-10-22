using System;
using System.Linq;

namespace stringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int punch = 0;

            for (int i = 0; i < input.Length; i++)
            {
                var currentChar = input[i];

                if (currentChar == '>')
                {
                    punch += int.Parse(input[i + 1].ToString());
                    //Console.Write(input[i]);
                    continue;
                }
                if (punch > 0)
                {
                    input = input.Remove(i, 1);
                    i--;
                    punch--;
                }
            }

            Console.WriteLine(input);
        }
    }
}
