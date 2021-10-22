using System;
using System.Linq;

namespace roundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
          
            double[] n = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine($"{n[i]} => {(int)Math.Round(n[i], MidpointRounding.AwayFromZero)}");
            }

        } 
    }
}
