using System;

namespace ceaserCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string noSpaceInput = string.Join("#", input);

            for (int i = 0; i < noSpaceInput.Length; i++)
            {

                if (noSpaceInput[i] != '#')
                {
                    char currentChar = noSpaceInput[i];
                    char encrypted = (char)(currentChar + 3);
                    Console.Write(encrypted);
                }
                else
                {
                    Console.Write('#');
                }
            }
        }
    }
}
