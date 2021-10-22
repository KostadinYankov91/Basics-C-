using System;
using System.Collections.Generic;

namespace fundsUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4 };
            Console.WriteLine(String.Join(" ", Where(array, n=> n < 0)));

            ReadStudents(PrintSoftUniStudent);
            ReadStudents((name, age) =>
            {
                Console.WriteLine("In Lambda ");
                return $"Labdas are cuul {name} {age}";
            });
        }

        static int[] Where(int[] array, Func<int, bool> condition)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (condition(array[i]))
                {
                    list.Add(array[i]);
                }
            }
        }

        static void ReadStudents(Func<string, int, string> printer)
        {

            string name;
            int age = 0;
            do 
            {
                Console.WriteLine("Student name:");
                name = Console.ReadLine();
                Console.WriteLine("Student age:");
                age = int.Parse(Console.ReadLine());

                Console.WriteLine(printer(name, age));

            }
            while (name != "end");
        }
        static string PrintStudent(string name, int age)
        {
            return $"Student is at {age} and named {name}";
        }

        static string PrintSoftUniStudent(string name, int age)
        {
            return $"SoftUni student is at {age} and named {name}";
        }

        static string PrintBulgarianStudent(string name, int age)
        {
            return $"Bulgarian student is at {age} and named {name}";
        }
    }
}
