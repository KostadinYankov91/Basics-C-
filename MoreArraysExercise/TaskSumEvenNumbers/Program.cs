using System;
using System.Linq;

namespace sumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentN = numbers[i];
                if (currentN % 2 == 0)
                {
                    sum += currentN;
                }
            }

            

            Console.WriteLine(sum);
        }
    }
}
