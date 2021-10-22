using System;

namespace rectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = GetRectArea(width, height);
            Console.WriteLine(area);
        }

        static double GetRectArea(double width, double height)
        {
            return width * height;
        }
    }
}
