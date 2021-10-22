using System;

namespace sumNums
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int simpleSum = 0;
            int complSum = 0;
            bool isCompl = false;

            while (input != "stop")
            {

                int number = int.Parse(input);
                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }

                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        isCompl = true;
                        break;
                    }

                }

                if (isCompl && number != 1)
                {
                    complSum += number;
                    isCompl = false;
                }
                else
                {
                    simpleSum += number;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {simpleSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {complSum}");
        }
    }
}
