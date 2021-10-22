using System;
using System.Collections.Generic;
using System.Linq;

namespace customMidFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<List<int>, int> minNumber =
                numbers =>
                {
                    int minNum = int.MaxValue;
                    foreach (int item in numbers)
                    {
                        if (item < minNum)
                        {
                            minNum = item;
                        }
                    }

                    return minNum;
                };

            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int number = minNumber(numbers);

            Console.WriteLine(number);
                
        }


        
    }
}
