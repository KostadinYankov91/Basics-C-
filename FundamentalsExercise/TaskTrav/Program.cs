using System;

namespace traveling
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double expences = 0.0;
            string season = Console.ReadLine();
            string vacationType = "";
            string destination = "";

            //if (season == "summer")
            //{
            //vacationType = "Camp";
            //if (budget > 0 && budget <= 100)
            //{
            //destination = "Bulgaria";
            //expences = budget * 0.3;
            //}
            //else if (budget > 100 && budget <= 1000)
            //{
            //destination = "Balkans";
            //expences = budget * 0.4;
            //}
            //else if (budget > 1000)
            //{
            //destination = "Europe";
            //expences = budget * 0.8;
            //}
            //}
            //else if (season == "winter")
            //{
            //vacationType = "Hotel";
            //if (budget > 0 && budget <= 100)
            //{
            //destination = "Bulgaria";
            //expences = budget * 0.7;
            //}
            //else if (budget > 100 && budget <= 1000)
            //{
            //destination = "Balkans";
            //expences = budget * 0.8;
            //}
            //else if (budget > 1000)
            //{
            //destination = "Europe";
            //expences = budget * 0.9;
            //}
            //}

            if (budget > 0 && budget <= 100)
            {
                destination = "Bulgaria";
                switch (season)
                {
                    case "summer":
                        vacationType = "Camp";
                        expences = budget * 0.3;
                        break;
                    case "winter":
                        vacationType = "Hotel";
                        expences = budget * 0.7;
                        break;
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                destination = "Balkans";
                switch (season)
                {
                    case "summer":
                        vacationType = "Camp";
                        expences = budget * 0.4;
                        break;
                    case "winter":
                        vacationType = "Hotel";
                        expences = budget * 0.8;
                        break;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                if (season == "summer" || season == "winter")
                {
                        vacationType = "Hotel";
                        expences = budget * 0.9;
                }
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{vacationType} - {expences:F2}");
        }
    }
}
