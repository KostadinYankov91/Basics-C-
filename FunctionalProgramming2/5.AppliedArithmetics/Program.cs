using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            
            //string operation;

            //while ((operation = Console.ReadLine()) != "end")
            //{
            //    if (operation == "print")
            //    {
            //        Console.WriteLine(string.Join(" ", numbers));
            //    }
            //    else
            //    {
            //        numbers = Applier(numbers, operation);
            //    }
            //}

            //static List<int> Applier(List<int> numbers, string operation)
            //{
            //    List<int> processedNumbers = new List<int>();

            //    switch (operation)
            //    {
            //        case "add":
            //            List<int> numsAdded = new List<int>();

            //            foreach (int item in numbers)
            //            {
            //                int currNum = item + 1;
            //                numsAdded.Add(currNum);
            //                processedNumbers = numsAdded;
            //            }
            //            break;
            //        case "multiply":
            //            List<int> numsMultiplied = new List<int>();
            //            foreach (var item in numbers)
            //            {
            //                int currNum = item * 2;
            //                numsMultiplied.Add(currNum);
            //                processedNumbers = numsMultiplied;
            //            }
            //            break;
            //        case "subtract":
            //            List<int> numsSubstracted = new List<int>();
            //            foreach (var item in numbers)
            //            {
            //                int currNum = item - 1;
            //                numsSubstracted.Add(currNum);
            //                processedNumbers = numsSubstracted;
            //            }
            //            break;
            //        default:
            //            break;
            //    }

            //    return processedNumbers;
            //}
        }
    }
}
