using System;

namespace newHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();

            switch (flowers)
            {
                case "Tulips":
                    if (numFlowers > 80)
                    {
                        expenses = numFlowers * 5 * 0.85;
                    }
                    else
                    {
                        expenses = numFlowers * 5;
                    }
                    break;
                case "Narcissus":
                    if (numFlowers > 120)
                    {
                        expenses = numFlowers * 5 * 1.15;
                    }
                    else
                    {
                        expenses = numFlowers * 5;
                    }
                    break;
                case "Gladiolus":
                    if (numFlowers > 80)
                    {
                        expenses = numFlowers * 2.5 * 1.2;
                    }
                    else
                    {
                        expenses = numFlowers * 5;
                    }
                    break;
            }
            if (budget >= expenses)
            {
                Console.WriteLine($"Hey, you have a great garden with {} {} and {} leva left.");
            }
        }
    }
}
