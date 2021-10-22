using System;

namespace movement
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            int freeSpace = width * lenght * hight;
            int boxSize = 0;
            int boxSum = 0;
            
            string box = Console.ReadLine();

            while (box != "Done")
            {
                boxSize = int.Parse(box);
                boxSum += boxSize;


                if (boxSum > freeSpace)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(boxSum - freeSpace)} Cubic meters more.");
                    break;
                }
                
                box = Console.ReadLine();

            }

                if (box == "Done")
                {
                    Console.WriteLine($"{freeSpace - boxSum} Cubic meters left.");
                }

        }
    }
}
