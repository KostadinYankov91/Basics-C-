using System;
using System.ComponentModel.DataAnnotations;

namespace cakePieces
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            int cakePieces = length * width;

            string line = Console.ReadLine();
            bool isCakeEnough = true;

            while (line != "STOP")
            {
                int guestPieces = int.Parse(line);
                cakePieces -= guestPieces;

                if (cakePieces < 0)
                {
                    isCakeEnough = false;
                    break;
                }
                else
                {

                }

                line = Console.ReadLine();
            }

            if (isCakeEnough == true)
            {
                Console.WriteLine($"{cakePieces} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cakePieces)} pieces more.");
            }

        }
    }
}
