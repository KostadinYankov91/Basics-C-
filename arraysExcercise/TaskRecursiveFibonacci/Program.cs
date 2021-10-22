using System;

namespace _3._recursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = 0;

            

            Console.WriteLine(GetFibonacci(n));
           
        }

        static int GetFibonacci(int n)
        {
            if (n >= 1 && n <= 2)
            {
                return n = 1;
            }
            else
            {


                return GetFibonacci(n - 1) + GetFibonacci(n - 2);
            }

            
        }
    }
}
