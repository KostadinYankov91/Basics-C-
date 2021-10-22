using System;

namespace middleCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string output = string.Empty;

            if (str.Length % 2 == 0)
            {
                output = GetMiddleTwo(str);
            }
            else
            {
                output = GetMiddleChar(str);
            }

            Console.WriteLine(output);

        }

        private static string GetMiddleChar(string str)
        {
            int index = str.Length / 2;
            string chars = str.Substring(index, 1);
            return chars;
        }

        private static string GetMiddleTwo(string str)
        {
            int index = str.Length / 2;
            string chars = str.Substring(index - 1, 2);
            return chars;
        }
    }
}
