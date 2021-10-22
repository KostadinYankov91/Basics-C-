using System;

namespace cozonacs
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double oneKgFlourprice = double.Parse(Console.ReadLine());
            double onePackEggs = oneKgFlourprice * 0.75;
            double fourCozunacsMilkprice = oneKgFlourprice + oneKgFlourprice * 0.25;
            int cozunacs = 0;

            double oneCozunacPrice = oneKgFlourprice + onePackEggs + fourCozunacsMilkprice * 0.25;
            double resto = 0;
            int coloredEggs = 0;
            int threeCozunacs = 0;

            while (budget > 0 && budget > oneCozunacPrice)
            {
                budget -= oneCozunacPrice;

                cozunacs++;
                coloredEggs += 3;
                threeCozunacs++;
                
                if (threeCozunacs % 3 == 0)
                {
                    coloredEggs = coloredEggs - (cozunacs - 2);
                    threeCozunacs = 0;
                }

            }

            resto = budget;
            Console.WriteLine($"You made {cozunacs} cozonacs! Now you have {coloredEggs} eggs and {resto:f2}BGN left.");
        }
    }
}
