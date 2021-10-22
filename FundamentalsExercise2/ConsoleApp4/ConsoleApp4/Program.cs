using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            double number3 = double.Parse(Console.ReadLine());
           
            double min = double.MaxValue;
            double max = double.MinValue;
            double maxNumber = 0;
            double minNumber = 0;
            double midNumber = 0;

            if (number1 < min)
            {
                maxNumber = number1;
            }
            if (number2 > maxNumber)
            {
                maxNumber = number2;
            }
            if (number3 > maxNumber)
            {
                maxNumber = number3;
            }
            if (number1 > max)
            {
                minNumber = number1;
            }
            if (number2 < minNumber)
            {
                minNumber = number2;
            }
            if (number3 < minNumber)
            {
                minNumber = number3;
            }
            if (number1 < maxNumber && number1 > minNumber)
            {
                midNumber = number1;
            }
            if (number2 < maxNumber && number2 > minNumber)
            {
                midNumber = number2;
            }
            if (number3 < maxNumber && number3 > minNumber)
            {
                midNumber = number3;
            }
            

            Console.WriteLine(maxNumber);
            Console.WriteLine(midNumber);
            Console.WriteLine(minNumber);
        }
    }
}
