using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = int.Parse(Console.ReadLine());
            int[] n = new int[r];

            for (int i = 0; i < n.Length; i++)
            {
                n[i] = int.Parse(Console.ReadLine());
            }

            for (int j = n.Length - 1; j >= 0; j--)
            {
                Console.Write($"{n[j]} ");
            }

        }
    }
}
