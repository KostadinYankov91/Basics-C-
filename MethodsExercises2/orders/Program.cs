using System;

namespace ордерс
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double count = int.Parse(Console.ReadLine());

            CalcTotal(product, count);

        }

        static void CalcTotal(string product, double count)
        {

            switch (product)
            {
                case "coffee":
                    count *= 1.50;
                    break;
                case "water":
                    count *= 1.00;
                    break;
                case "coke":
                    count *= 1.40;
                    break;
                case "snacks":
                    count *= 2.00;
                    break;
            }

            Console.WriteLine($"{count:F2}");
        }
    }
}
