using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            double excellentGrade = 5.50;

            if (grade >= excellentGrade)
            {
                Console.WriteLine("Excellent!");
            }
           

        }
    }
}
