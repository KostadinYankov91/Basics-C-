using System;

namespace condStateEx
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowerCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double expences = 0.0;


            switch (flowerType)
            {
                case "Roses":
                    double priceRoses = flowerCount * 5;
                    if (flowerCount > 80)
                    {
                        expences = priceRoses - priceRoses * 0.1;
                    }
                    else
                    {
                        expences = priceRoses;
                    }
                    break;
                case "Dahlias":
                    double priceDahlias = flowerCount * 3.8;
                    if (flowerCount > 90)
                    {
                        expences = priceDahlias - priceDahlias * 0.15;
                    }
                    else
                    {
                        expences = priceDahlias;
                    }
                    break;
                case "Tulips":
                    double priceTulips = flowerCount * 2.8;
                    if (flowerCount > 80)
                    {
                        expences = priceTulips - priceTulips * 0.15;
                    }
                    else
                    {
                        expences = priceTulips;
                    }
                    break;
                case "Narcissus":
                    double priceNarcissus = flowerCount * 3;
                    if (flowerCount < 120)
                    {
                        expences = priceNarcissus + priceNarcissus * 0.15;
                    }
                    else
                    {
                        expences = priceNarcissus;
                    }
                    break;
                case "Gladiolus":
                    double priceGladiolus = flowerCount * 2.5;
                    if (flowerCount < 80)
                    {
                        expences = priceGladiolus + priceGladiolus * 0.2;
                    }
                    else
                    {
                        expences = priceGladiolus;
                    }
                    break;
            }


            if (budget >= expences)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flowerType} and {Math.Abs(budget - expences):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(expences - budget):F2} leva more.");
            }
        }

    }
}
