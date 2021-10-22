using System;

namespace breakk
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            int days = 0;
            int spendDays = 0;
            bool savedMoney = true;

            while (moneyNeeded > budget)
            {
                string action = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());

                days++;

                if (action == "spend")
                {
                    spendDays++;
                    if (spendDays == 5)
                    {
                        savedMoney = false;
                        break;
                    }
                    budget -= money;
                    if (budget < 0)
                    {
                        budget = 0;
                    }
                }
                else if (action == "save")
                {
                    spendDays = 0;
                    budget += money;
                }
            }

            if (savedMoney)
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
            else
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{days}");
            }
        }
    }
}
