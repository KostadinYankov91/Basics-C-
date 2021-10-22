using System;

namespace func
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(agePrinter(5, DateTime.Now));
            //Console.WriteLine(GetAge(5));

            //(age, date) => $"{age} years by {date}";
            //(age, date) => $"{age} years by {date}";
            
            Console.WriteLine("Age now or then?");
            string input = Console.ReadLine();

            Func<int, DateTime, string> agePrinterInTenYears = null;
                //(age, date) => $"Your age will be {age + 10} years {date}";
            Func<int, DateTime, string> agePrinter = null;
            
            if (input == "now")
            {
                agePrinter = GetAge;
            }
            else if (input == "then")
            {
                agePrinter = GetAgeInTenYears;
            }
            
            Console.WriteLine(agePrinter(23, DateTime.Now));
            //Console.WriteLine(agePrinterInTenYears(23, DateTime.Now));

        }

        static string GetAge(int age, DateTime date)
        {
            return $"Your age is: {age} at {date}";
        }

        static string GetAgeInTenYears(int age, DateTime date)
        {
            return $"Your age is: {age + 10} at {date}";
        }
    }
}
