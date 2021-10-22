using System;

namespace whilieCycles
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string stop = "Stop";

            while (word != stop)
            {
                Console.WriteLine(word);
                
                word = Console.ReadLine();

                if (word == stop)
                {
                    Console.WriteLine();
                    break;
                }

            }

        }
    }
}