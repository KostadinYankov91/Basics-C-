using System;
using System.Collections.Generic;
using System.Linq;

namespace Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> stones = Console.ReadLine().Split(", ").Select(int.Parse).ToList();

            Lake<int> lake = new Lake<int>(stones);


            Console.WriteLine(string.Join(", ", lake));

        }
    }
}
