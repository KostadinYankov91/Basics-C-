using System;
using System.Linq;

namespace reverseArrayOfString
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(string.Join(' ', Console.ReadLine().Split().Reverse()));

        }
    }
}
