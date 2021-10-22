using System;

namespace padawan
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int padawans = int.Parse(Console.ReadLine());
            double saberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltrPrice = double.Parse(Console.ReadLine());

            int freeBelts = 0;

            for (int i = 1; i <= padawans; i++)
            {
                if (i % 6 == 0)
                {
                    freeBelts++;
                }

            }


            double saberCost = saberPrice * Math.Ceiling(padawans + 1.1);
            double robesCost = robePrice * padawans;
            double beltCost = beltrPrice * (padawans - freeBelts);
            double equipmentCost = saberCost + robesCost + beltCost;

            equipmentCost += saberCost;


            if (budget >= equipmentCost)
            {
                Console.WriteLine($"The money is enough - it would cost {equipmentCost:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {Math.Abs(equipmentCost - budget):f2}lv more.");
            }
        }
    }
}
