using System;

namespace Square
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());

            double area = side * side;

            Console.WriteLine(area);

        }
    }
}