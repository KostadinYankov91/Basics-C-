using System;

namespace maxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string stop = Console.ReadLine();
            int min = int.MaxValue;

            while (stop != "Stop")
            {
                int number = int.Parse(stop);

                if (number < min)
                {
                    min = number;
                }
                
                stop = Console.ReadLine();
                
            }

            Console.WriteLine(min);
        }
    }
}
