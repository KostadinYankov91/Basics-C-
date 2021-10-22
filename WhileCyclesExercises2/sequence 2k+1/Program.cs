using System;

namespace sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int K = 1;
            int n = 1;

            while (number >= n)
            {
                Console.WriteLine(n);
                n = n * 2 + K;
                
                if (number < n)
                {
                    break;
                }
            }

        }
    }
}
