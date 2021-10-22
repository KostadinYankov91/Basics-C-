using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var hB = double.Parse(Console.ReadLine());
           var B = double.Parse(Console.ReadLine());

            var area = hB * B / 2;

            Console.WriteLine(area.ToString("0.00"));

        }
    }
}
