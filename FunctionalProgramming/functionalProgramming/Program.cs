using System;
using System.Linq;

namespace functionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] evenNumbers = array.Where((x, index) =>
            {
                Console.WriteLine($"Checking at array[{index}] {x} % 2 == 0 ->{x % 2 == 0}");
                return x % 2 == 0;
            }).ToArray();

            Console.WriteLine(string.Join(" ", evenNumbers));





            //array.OrderBy(n => n);

            //array.OrderBy(Sort);

            //Console.WriteLine();
        }

        static int Parser(string word)
        {
            int n = int.Parse(word);
            return n;
        }

        private static int Sort(int n)
        {
            return n;
        }
    }
}
