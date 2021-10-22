using System;

namespace C_to_F
{
    class Program
    {
        static void Main(string[] args)
        {
            double C = double.Parse(Console.ReadLine());
            double F = (C * 9 / 5) + 32;
           
            Console.WriteLine(F.ToString("0.00"));

        }
    }
}
