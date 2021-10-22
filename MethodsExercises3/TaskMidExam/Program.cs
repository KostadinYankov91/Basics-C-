using System;

namespace midExam
{
    class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());

            double flourPackPrice = double.Parse(Console.ReadLine());
            double singleEggPrice = double.Parse(Console.ReadLine());
            double eggPack = singleEggPrice * 10;
            double apronPrice = double.Parse(Console.ReadLine());

            int freeFlourPacks = students / 5;

            double allStudentsFlourPackPrice = flourPackPrice * (students - freeFlourPacks);
            double allStudentsEggPackPrice = eggPack * students;
            double allStudentsApronPrice = (Math.Ceiling(students + students * 0.2)) * apronPrice;
            

            double totalAllStudents = allStudentsApronPrice + allStudentsEggPackPrice + allStudentsFlourPackPrice;


            if (totalAllStudents <= budget)
            {
                Console.WriteLine($"Items purchased for {totalAllStudents:f2}$.");
            }
            else
            {
                double moneyNeeded = Math.Abs(totalAllStudents - budget);
                Console.WriteLine($"{moneyNeeded:f2}$ more needed.");
            }


        }
    }
}
