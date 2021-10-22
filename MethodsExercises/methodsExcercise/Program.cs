using System;

namespace methodsExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            int minNumber = SmallestNumber(number1, number2, number3);
            Console.WriteLine(minNumber);

        }

        public static int SmallestNumber(int number1, int number2, int number3)
        {
            int minNum = Math.Min(number1, Math.Min(number2, number3));
            return minNum;
        }


    }
}
