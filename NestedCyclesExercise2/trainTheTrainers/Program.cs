using System;

namespace trainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int judges = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            double allGrades = 0;
            int gradeCount = 0;

            while (input != "Finish")
            {

                string presenation = input;
                double currGrades = 0;

                for (int i = 0; i < judges; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    currGrades += grade;
                    allGrades += grade;
                    gradeCount++;
                }

                Console.WriteLine($"{presenation} - {currGrades / judges:F2}.");

                input = Console.ReadLine();
            }
            double averegeGrades = allGrades / gradeCount;
            Console.WriteLine($"Student's final assessment is {averegeGrades:F2}.");

        }
    }
}
