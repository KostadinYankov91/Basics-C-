using System;

namespace methodsLab
{
    class Program
    {
        static void Main()
        {
            PrintSign(int.Parse(Console.ReadLine()));    
        }

        static void PrintSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("The number {0} is positive.", number);

            }
            else if (number < 0)
            {
                Console.WriteLine("The number {0} is negative.", number);
            }
            else if (number == 0)
            {
                Console.WriteLine("The number {0} is 0", number);
            }
        }



    }
}
