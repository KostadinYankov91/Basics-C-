using System;

namespace Calories
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter male age: ");
            double ageM = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter male weight (kg): ");
            double kgM = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter male height (m): ");
            double hM = double.Parse(Console.ReadLine());

            double CalMen = kgM * 13.7 + hM * 5 - ageM * 6.8 + 66;

            Console.WriteLine("Minimum callories entry for a Men per day is: " + CalMen.ToString("0"));

            double CalMenL = CalMen * 1.2;
            Console.WriteLine("Lazy Man's callories entry per day is: " + CalMenL.ToString("0"));
            double CalMenLight = CalMen * 1.375;
            Console.WriteLine("Man with light physycal activity callories entry per day is: " + CalMenLight.ToString("0"));
            double CalMenM = CalMen * 1.55;
            Console.WriteLine("Man with medium physycal activity callories entry per day is: " + CalMenM.ToString("0"));
            double CalMenH = CalMen * 1.725;
            Console.WriteLine("Man with high physycal activity callories entry per day is: " + CalMenH.ToString("0"));
            double CalMenVh = CalMen * 1.9;
            Console.WriteLine("Man with very high physycal activity callories entry per day is: " + CalMenVh.ToString("0"));

            Console.WriteLine("Enter woman age: ");
            double ageW = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter woman weight (kg): ");
            double kgW = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter woman height (m): ");
            double hW = double.Parse(Console.ReadLine());

            double CalWomen = kgW * 9.6 + hW * 1.8 - ageW * 4.7 + 655;

            Console.WriteLine("Minimum callories entry for a Women per day is: " + CalWomen.ToString("0"));
            double CalWomenL = CalWomen * 1.2;
            Console.WriteLine("Lazy Woman's minimum callories entry per day is: " + CalWomenL.ToString("0"));
            double CalWomenLight = CalWomen * 1.375;
            Console.WriteLine("Woman with light physycal activity callories entry per day is: " + CalWomenLight.ToString("0"));
            double CalWomenM = CalWomen * 1.55;
            Console.WriteLine("Woman with medium physycal activity callories entry per day is: " + CalWomenM.ToString("0"));
            double CalWomennH = CalWomen * 1.725;
            Console.WriteLine("Woman with high physycal activity callories entry per day is: " + CalWomennH.ToString("0"));
            double CalWomenVh = CalWomen * 1.9;
            Console.WriteLine("Woman with very high physycal activity callories entry per day is: " + CalWomenVh.ToString("0"));

        }
    }
}
