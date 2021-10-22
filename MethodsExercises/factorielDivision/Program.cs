using System;

namespace factorielDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            double factorialFirst = GetFactorial(first);
            double factorialSecond = GetFactorial(second);

            double result = factorialFirst / factorialSecond;

            Console.WriteLine($"{result:F2}");
        }

        public static double GetFactorial(int number)
        {
            double result = 1;
            while (number != 1)
            {
                result = result * number;
                number = number - 1;
            }

            return result;

        }
    }
}
