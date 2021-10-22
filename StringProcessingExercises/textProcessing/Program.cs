using System;

namespace textProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                                    .Split(' ',StringSplitOptions.RemoveEmptyEntries);

            string result = string.Empty;

            foreach (var item in input)
            {
                int length = item.Length;

                for (int i = 0; i < item.Length; i++)
                {
                    result += item;
                }
            }

            Console.WriteLine(result);
        }
    }
}
