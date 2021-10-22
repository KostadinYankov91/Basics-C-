using System;

namespace examPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGradesLimit = int.Parse(Console.ReadLine());

            string task = Console.ReadLine();

            int badGrades = 0;
            bool isExcellent = true;

            double score = 0;
            int allGrades = 0;
            string lastProblem = "";

            while (task != "Enough")
            {
                int grade = int.Parse(Console.ReadLine());
                score += grade;
                allGrades++;
                lastProblem = task;

                if (grade <= 4)
                {
                    badGrades++;
                    if (badGrades == badGradesLimit)
                    {
                        isExcellent = false;
                        break;
                    }
                }


                task = Console.ReadLine();
            }

            string output = "";
            double avarageGrade = score / allGrades;

            if (isExcellent)
            {
                output = $"Average score: {avarageGrade:F2}\n Number of problems: {allGrades}\n Last problem: {lastProblem}";

            }
            else
            {
                output = $"You need a break, {badGrades} poor grades.";
            }

            Console.WriteLine(output);

        }
    }
}
