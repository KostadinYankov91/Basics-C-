using System;
using System.Collections.Generic;
using System.Linq;

namespace basicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = data[0];
            int s = data[1];
            int x = data[2];

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(numbers[i]);
            }
            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }
            if (queue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
            //else
            //{
            //    int smallest = int.MaxValue;
            //    foreach (int item in queue)
            //    {
            //        if (item < smallest)
            //        {
            //            smallest = item;
            //        }
            //    }
            //    if (smallest != int.MaxValue)
            //    {
            //        Console.WriteLine(smallest);
            //    }
            //}
        }
    }
}
