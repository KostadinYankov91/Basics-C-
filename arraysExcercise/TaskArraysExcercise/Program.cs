using System;
using System.Diagnostics.CodeAnalysis;

namespace arraysExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWagons = int.Parse(Console.ReadLine());

            int[] wagons = new int[numberOfWagons];
            int sum = 0;

            for (int i = 0; i < wagons.Length; i++)
            {
                wagons[i] = int.Parse(Console.ReadLine());
                sum += wagons[i];
            }
            
            Console.WriteLine(string.Join(" ", wagons));
            Console.WriteLine(sum);

        }
    }
}
