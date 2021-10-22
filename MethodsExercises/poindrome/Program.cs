using System;
using System.Runtime.InteropServices;

namespace poindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                int currNumber = int.Parse(input);
                string result = IsPalindrome(currNumber).ToString().ToLower();

                Console.WriteLine(result);

                input = Console.ReadLine();
            }
        }

        private static bool IsPalindrome(int currNumber)
        {
            if (currNumber < 0)
            {
                return false;
            }
            int div = 1;
            while (currNumber / div >= 10)
            {
                div *= 10;
            }
            while (currNumber != 0)
            {
                int l = currNumber / div;
                int r = currNumber % 10;
                if (l != r)
                {
                    return false;
                }
                currNumber = (currNumber % div) / 10;
                div /= 100;
            }
            return true;
        }
    }
}
