using System;
using System;

namespace TrainingRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double desksOnRow = ((h * 100) - 100) / 70;
            double desksOnCol = w * 100 / 120;
            int desks = (int)desksOnRow * (int)desksOnCol - 3;

            Console.WriteLine(desks);

        }
    }
}