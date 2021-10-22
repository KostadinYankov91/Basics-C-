using System;

namespace graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int classes = 1;
            int exclusions = 0;
            double gradeSum = 0;

            while (classes <= 12)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade < 4.00)
                {
                    exclusions += 1;
                    if (exclusions >= 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {classes} grade");
                        break;
                    }
                    continue;
                }

                else if (grade >= 4.00)
                {
                    gradeSum += grade;
                    classes += 1;
                    if (classes == 12 + 1)
                    {
                        double average = gradeSum / 12;
                        Console.WriteLine($"{name} graduated. Average grade: {average:F2}");
                        break;
                    }
                }

            }


        }

    }
}

