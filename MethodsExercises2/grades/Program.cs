using System;

namespace grades
{
    class Program
    {
        static void Main()
        {
            printGrade(double.Parse(Console.ReadLine()));
        }

        static void printGrade(double grade)
        {
            if (grade >= 2.00 && grade <= 6.00)
            {
                switch (grade)
                {
                    case double n when (grade >= 2.00 & grade <= 2.99):
                        Console.WriteLine("Fail");
                        break;
                    case double n when (grade >= 3.00 & grade <= 3.49):
                        Console.WriteLine("Poor");
                        break;
                    case double n when (grade >= 3.50 & grade <= 4.49):
                        Console.WriteLine("Good");
                        break;
                    case double n when (grade >= 4.50 & grade <= 5.49):
                        Console.WriteLine("Very good");
                        break;
                    case double n when (grade >= 5.50 & grade <= 6.00):
                        Console.WriteLine("Excellent");
                        break;   

                    default:
                        break;
                }
            }
        }
    }
}
