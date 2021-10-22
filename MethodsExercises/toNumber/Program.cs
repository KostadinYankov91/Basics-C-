using System;

namespace toNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintTopNumber(number);
        }

        private static void PrintTopNumber(int number)
        {
            for (int i = 0; i <= number; i++)
            {
                string currNumber = i.ToString();
                bool isOddDigit = false;
                int sumOfDigits = 0;

                foreach (var current in currNumber)
                {
                    int parseNumber = (int)current;

                    if (parseNumber % 2 != 0)
                    {
                        isOddDigit = true;
                    }

                    sumOfDigits += parseNumber;
                }

                if (sumOfDigits % 8 == 0 && 
                    isOddDigit)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
