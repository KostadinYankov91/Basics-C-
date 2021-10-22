using System;

namespace exactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            decimal numberSum = 0;

            for (int i = 0; i < numbersCount; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                numberSum += number;
            }

            Console.WriteLine(numberSum);
        }
    }
}
