using System;

namespace bit
{
    class Program
    {
        static void Main(string[] args)
        {
            double equity = double.Parse(Console.ReadLine());
            double openingRate = double.Parse(Console.ReadLine());
            double contracts = double.Parse(Console.ReadLine());

            double investmentValue = openingRate * contracts;
            double initialMarginToPay = investmentValue * 0.5;
            double maintenanceMargin = investmentValue * 0.25;
            equity -= initialMarginToPay;

            if (maintenanceMargin < equity * 0.25)
            {
                Console.WriteLine($"You can buy maximum {investmentValue}");
            }

            Console.WriteLine();
            int positionCount = 0;

            if (maintenanceMargin < equity * 0.25)
            {
                //positionCount++;
                //equity -= maintenanceMargin;
                Console.WriteLine($"You paid {initialMarginToPay} initial margin\n" +
                    $"Maintenance margin is: {maintenanceMargin}\n" +
                    $"Current equity is: {equity}");
            }
            else
            {
                Console.WriteLine("Not enough equity");

            }






        }
    }
}
