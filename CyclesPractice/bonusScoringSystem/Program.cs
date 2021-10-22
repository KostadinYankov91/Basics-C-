using System;
using System.Collections.Generic;

namespace bonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());

            int lecturesPerCourse = int.Parse(Console.ReadLine());
            int bonusPerCourse = int.Parse(Console.ReadLine());

            List<int> attendances = new List<int>(countOfStudents);
            for (int j = 0; j < countOfStudents; j++)
            {
                int currentAppearance = int.Parse(Console.ReadLine());
                attendances.Add(currentAppearance);
            }

            decimal bonus = 0;
            decimal biggestBonus = 0;
            int mostAttendancies = 0;

            for (int i = 0; i < attendances.Count; i++)
            {
                decimal currApp = attendances[i];

                bonus = currApp / lecturesPerCourse
                * (5 + bonusPerCourse);

                if (bonus > biggestBonus)
                {
                    biggestBonus = bonus;
                    mostAttendancies = attendances[i];
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(biggestBonus)}.");
            Console.WriteLine($"The student has attended {mostAttendancies} lectures.");

        }
    }
}
