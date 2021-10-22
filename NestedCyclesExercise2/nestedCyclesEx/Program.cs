using System;

namespace nestedCyclesEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int count = 0;
            bool bigger = false;

            for (int rows = 1; rows <= n; rows++)
            {
                
                for (int cols = 1; cols <= rows; cols++)
                {
                    count++;
                    
                    if (count > n)
                    {
                        bigger = true;
                        break;
                    }

                    Console.Write(count + " ");
                }

                if (bigger)
                {
                    break;
                }

                Console.WriteLine();
            }
        
        }
    }
}
