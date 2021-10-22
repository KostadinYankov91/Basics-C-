using System;

namespace Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int amount = int.Parse(Console.ReadLine());
            double bugdet = double.Parse(Console.ReadLine());
            double cost = 0;
            double alteredCost = 0;

            switch (flowers)
            { 
                case "Roses":
                        
                    cost = amount * 5;
                    
                    if (amount > 80)
                    {
                        cost = cost - (cost * 0.1);
                    }
                    break;
                case "Dahlias":
                    break;
                case "Tulips":
                    break;
                case "Narcissus":
                    break;
                case "Gladiolus":
                    break;

            }

            //    [Range(10, 1000,
            // ErrorMessage = "Value for {0} must be between {1} and {2}.")]

        }
    }
}
