using System;

namespace addAndSubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int sum = Sum(firstNum, secondNum, thirdNum);
            Console.WriteLine(sum);
        }

        private static int Sum(int firstNum, int secondNum, int thirdNum)
        {
            int firstAndSecond = firstNum + secondNum;

            return Substract(firstAndSecond, thirdNum);

        }

        private static int Substract(int firstAndSecond, int thirdNum)
        {
            firstAndSecond -= thirdNum;

            return firstAndSecond;
        }
    }
}
