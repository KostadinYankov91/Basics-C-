using System;
using System.Collections.Generic;
using System.Linq;

namespace _9.List_of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            List<int> dividers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> numbers = Enumerable.Range(1, end).ToList();
            Func<int, int, bool> predicate =
                (num, d) => num % d == 0;

            for (int i = 1; i <= end; i++)
            {
                if (dividers.All(d => predicate(i, d)))
                {
                    Console.Write(i + " ");
                }
            }


            //foreach (int num in numbers)
            //{
                //if (dividers.All(d => predicate(num, d)))
                //{
                    //Console.Write(num + " ");
                //}
            //}

        }
    }
}
