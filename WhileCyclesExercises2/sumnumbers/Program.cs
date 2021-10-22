using System;

namespace sumnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            while (number > sum)
            {
                sum += int.Parse(Console.ReadLine());

                if (sum >= number)
                {
                    Console.WriteLine(sum);
                    break;
                }
            }

        }
    }
}
