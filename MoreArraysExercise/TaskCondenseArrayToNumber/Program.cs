using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace condenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;
            int currentCondensed = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                int[] condensed = new int[nums.Length - 1];

                condensed[i] = nums[i] + nums[i + 1];
                currentCondensed = condensed[i];

                sum += currentCondensed;

                if (i == nums.Length)
                {
                    Console.WriteLine(sum);
                    break;
                }
            }


        }
    }
}
