using System;
using System.Collections.Generic;
using System.Linq;

namespace listsLab
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> result = nums.Where(n => n >= 0).Reverse().ToList();
            
            //for (int i = 0; i < nums.Count; i++)
            //{
            //    if (nums[i] < 0) { nums.RemoveAt(i--); }
            //    {
            //
            //    }
            //}

            if (result.Count == 0)
            {
                Console.WriteLine("Empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", result));
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
