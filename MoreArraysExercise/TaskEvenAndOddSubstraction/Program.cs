using System;
using System.Linq;

namespace evenAndOddSubstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentN = numbers[i];
                if (currentN % 2 == 0)
                {
                    sumEven += currentN;
                }
                else
                {
                    sumOdd += currentN;
                }
            }

            int sumDiff = sumEven - sumOdd;

            Console.WriteLine($"{sumDiff}");
        }
    }
}
