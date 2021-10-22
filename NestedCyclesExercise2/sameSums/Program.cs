using System;

namespace sameSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            for (int i = n1; i <= n2; i++)
            {
                int oddSum = 0;
                int evenSum = 0;

                int number = i;

                for (int position = 6; position >= 1; position--)
                {
                    int digit = number % 10;
                    number = number / 10;

                    if (position % 2 == 0)
                    {
                        evenSum += digit;
                    }
                    else
                    {
                        oddSum += digit;
                    }

                }

                if (oddSum == evenSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
