using System;

namespace accBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double currIncrease = 0.0;
            double bankAcc = 0.0;

            while (input != "NoMoreMoney")
            {
                currIncrease = double.Parse(input);

                if (currIncrease < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                bankAcc += currIncrease;
                Console.WriteLine($"Increase: {currIncrease:F2}");

                input = Console.ReadLine();

            }

            Console.WriteLine($"Total: {bankAcc:F2}");

        }
    }
}
