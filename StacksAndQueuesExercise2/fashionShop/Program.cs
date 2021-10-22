using System;
using System.Collections.Generic;
using System.Linq;

namespace fashionShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] allClothesInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> allClothes = new Stack<int>(allClothesInput);

            int boxCapacity = int.Parse(Console.ReadLine());
            int currentBoxCapacity = boxCapacity;
            int racksCount = 1;

            while (allClothes.Any())
            {
                int clothes = allClothes.Pop();

                currentBoxCapacity -= clothes;

                if (currentBoxCapacity < 0)
                {
                    racksCount++;
                    currentBoxCapacity = boxCapacity - clothes;
                    //currentBoxCapacity -= clothes;
                }
            }

            Console.WriteLine(racksCount);
        }
    }
}
