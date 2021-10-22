using System;

namespace fishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishers = int.Parse(Console.ReadLine());
            double expences = 0.0;


            switch (season)
            {
                case "Spring":
                    expences = 3000;
                    if (fishers <= 6)
                    {
                        expences = expences - expences * 0.1;
                    }
                    else if (fishers >= 7 && fishers <= 11)
                    {
                        expences = expences - expences * 0.15;
                    }
                    else if (fishers >= 12)
                    {
                        expences = expences - expences * 0.25;
                    }
                    if (fishers % 2 == 0)
                    {
                        expences = expences - expences * 0.05;
                    }
                    break;
                case "Summer":
                    expences = 4200;
                    if (fishers <= 6)
                    {
                        expences = expences - expences * 0.1;
                    }
                    else if (fishers >= 7 && fishers <= 11)
                    {
                        expences = expences - expences * 0.15;
                    }
                    else if (fishers >= 12)
                    {
                        expences = expences - expences * 0.25;
                    }
                    if (fishers % 2 == 0)
                    {
                        expences = expences - expences * 0.05;
                    }
                    break;
                case "Autumn":
                    expences = 4200;
                    if (fishers <= 6)
                    {
                        expences = expences - expences * 0.1;
                    }
                    else if (fishers >= 7 && fishers <= 11)
                    {
                        expences = expences - expences * 0.15;
                    }
                    else if (fishers >= 12)
                    {
                        expences = expences - expences * 0.25;
                    }
                    break;
                case "Winter":
                    expences = 2600;
                    if (fishers <= 6)
                    {
                        expences = expences - expences * 0.1;
                    }
                    else if (fishers >= 7 && fishers <= 11)
                    {
                        expences = expences - expences * 0.15;
                    }
                    else if (fishers >= 12)
                    {
                        expences = expences - expences * 0.25;
                    }
                    if (fishers % 2 == 0)
                    {
                        expences = expences - expences * 0.05;
                    }
                    break;

            }

            if (budget >= expences)
            {
                Console.WriteLine($"Yes! You have {budget - expences:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {expences - budget:F2} leva.");
            }
        }
    }
}
