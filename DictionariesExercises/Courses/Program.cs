using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while (command != "end")
            {
                string[] arguments = command.Split(" : ");

                string courseName = arguments[0];
                string studentNAme = arguments[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                }
                courses[courseName].Add(studentNAme);

                command = Console.ReadLine();
            }

            foreach (var currentCourse in courses.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{currentCourse.Key}: {currentCourse.Value.Count}");
                foreach (var item in currentCourse.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {item}");
                }

            }
        }
    }
}
