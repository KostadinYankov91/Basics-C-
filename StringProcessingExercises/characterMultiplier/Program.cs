using System;

namespace characterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            string stringOne = input[0];
            string stringTwo = input[1];

            string longerWord = stringOne;
            string shorterWord = stringTwo;

            if (longerWord.Length < shorterWord.Length)
            {
                longerWord = stringTwo;
                shorterWord = stringOne;
            }

            int sum = CharMultiplier(longerWord, shorterWord);

            Console.WriteLine(sum);

        }

        public static int CharMultiplier(string one, string two)
        {
            int sum = 0;

            for (int i = 0; i < two.Length; i++)
            {
                
                int multiply = one[i] * two[i];
                sum += multiply;
            }
            for (int i = two.Length; i < one.Length; i++)
            {
                sum += one[i];
            }

            return sum;
        }
    }
}
