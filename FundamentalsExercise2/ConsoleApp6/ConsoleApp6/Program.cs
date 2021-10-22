using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string input = Console.ReadLine();

            string result = DefineType(type, input);
            Console.WriteLine(result);
        }

        private static string DefineType(string type, string input)
        {
            if (type == "int")
            {
                int intNumber = int.Parse(input);
                intNumber *= 2;
                return $"{intNumber}";
            }
            else if (type == "real")
            {
                double doubleNumber = double.Parse(input);
                doubleNumber *= 1.5;
                return $"{doubleNumber:F2}";
            }
            else
            {
                return $"${input}$";
            }

            
        }
    }
}
