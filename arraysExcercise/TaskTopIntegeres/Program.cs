using System;
using System.Linq;

namespace topIntegeres
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            bool isBigger = true;

            for (int i = 0; i < arr.Length; i++)
            {
                int currentInt = arr[i];

                for (int k = i + 1; k < arr.Length; k++)
                {
                    if (arr[k] >= currentInt)
                    {
                        isBigger = false;
                        break;
                    }
                }

                if (isBigger)
                {
                    Console.Write(currentInt + " ");
                }

                isBigger = true;

            }
        }
    }
}
