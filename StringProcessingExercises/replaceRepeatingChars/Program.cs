using System;

namespace replaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (input.Length - 1 == i)
                {
                    result += input[i];
                    break;
                }
                else if (input[i] != input[i + 1])
                {
                    result += input[i];
                }
            }

            Console.WriteLine(result);

        }
    }
}
