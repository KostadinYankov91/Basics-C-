using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());

            decimal km = Convert.ToDecimal(m);
            decimal kmtom = 1000;
            
            decimal distance = km / kmtom;
            
            Console.WriteLine($"{distance:F2}");
        } 
    }
}
