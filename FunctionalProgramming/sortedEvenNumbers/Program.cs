using System;
using System.Linq;

namespace sortedEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(", ").Select(n => int.Parse(n)).Where(x => x % 2 == 0).OrderBy(x => x).ToArray();

            Console.WriteLine(string.Join(", ", array).ToString());
        }
    }
}
