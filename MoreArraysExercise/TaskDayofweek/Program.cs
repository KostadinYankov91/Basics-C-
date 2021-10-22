using System;

namespace dayofweek
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] daysOfWeek = new string[8];

            daysOfWeek[1] = "Monday";
            daysOfWeek[2] = "Tuesday";
            daysOfWeek[3] = "Wednesday";
            daysOfWeek[4] = "Thursday";
            daysOfWeek[5] = "Friday";
            daysOfWeek[6] = "Saturday";
            daysOfWeek[7] = "Sunday";


            if (n > 7 || n < 1)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(daysOfWeek[n]);
            }

        }
    }
}
