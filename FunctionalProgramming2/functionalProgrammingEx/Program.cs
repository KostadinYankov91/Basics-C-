using System;
using System.Collections.Generic;
using System.Linq;

namespace functionalProgrammingEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> predicate = n => n % 2 == 0;

            List<string> names = Console.ReadLine().Split(" ").ToList();

            List<string> newNames = names.Select(name => $"Sir {name}").Where(.ToList();

            Action<List<string>> printNames = names => Console.WriteLine(string.Join(Environment.NewLine, names));

            printNames(newNames);
        }


    }
}
