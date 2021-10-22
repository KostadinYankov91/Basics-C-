using System;
using System.Collections.Generic;
using System.Linq;

namespace softUniExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            Dictionary<string, int> students = new Dictionary<string, int>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();

            while ((input = Console.ReadLine()) != "exam finished")
            {
                string[] arguments = input.Split("-");
                string user = arguments[0];

                if (arguments.Length > 2)
                {
                    string language = arguments[1];
                    int points = int.Parse(arguments[2]);

                    if (!students.ContainsKey(user))
                    {
                        students.Add(user, points);
                    }
                    else
                    {
                        if (students[user] < points)
                        {
                            students[user] = points;
                        }
                    }

                    if (!submissions.ContainsKey(language))
                    {
                        submissions.Add(language, 0);
                    }

                    submissions[language]++;

                }
                else
                {
                    students.Remove(user);
                }

            }

            Console.WriteLine("Results:");
            foreach (var currentStudent in students.OrderByDescending(x => x.Value)
                                                   .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{currentStudent.Key} | {currentStudent.Value}");
            }
            Console.WriteLine("Submissions:");

            foreach (var submission in submissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{submission.Key} - {submission.Value}");
            }

        }
    }
}
