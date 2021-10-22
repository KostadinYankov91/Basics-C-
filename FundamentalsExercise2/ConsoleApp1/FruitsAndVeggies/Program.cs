using System;

namespace FruitsAndVeggies
{
    class Program
    {
        static void Main(string[] args)
        {
            double Flv = double.Parse(Console.ReadLine());
            double Vlv = double.Parse(Console.ReadLine());
            double Fkg = double.Parse(Console.ReadLine());
            double Vkg = double.Parse(Console.ReadLine());

            double euro = Flv * Fkg + Vlv * Vkg;
            double euroIncome = euro / 1.94;

            Console.WriteLine(euroIncome.ToString("0.00"));

        }
    }
}
