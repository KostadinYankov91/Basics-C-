using System;

namespace poundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());
            decimal pndTodllr = 1.31M;

            decimal dollars = pounds * pndTodllr;

            Console.WriteLine($"{dollars:F3}");
        }
    }
}
