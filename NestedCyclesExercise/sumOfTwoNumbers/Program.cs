using System;

namespace sumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int combinations = 0;
            bool comsbFound = false;

            for (int i = start; i < stop; i++)
            {
                for (int j = start; j < stop; j++)
                {
                    combinations++;
                    if (i + j == magicNum)
                    {
                        Console.WriteLine($"Combination N:{combinations} ({i} + {j} = {magicNum})");
                        comsbFound = true;
                        break;
                    }
                }

                if (comsbFound)
                {
                    break;
                }

            }

            if (!comsbFound)
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicNum}");
            }

        }
    }
}
