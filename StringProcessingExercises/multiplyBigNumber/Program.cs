using System;
using System.Numerics;

namespace multiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal inputOne = decimal.Parse(Console.ReadLine());
            byte multiplier = byte.Parse(Console.ReadLine());

            decimal sum = inputOne * multiplier;
            Console.WriteLine(sum);
        }
    }
}
