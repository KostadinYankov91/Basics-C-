using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string f = Console.ReadLine();
            if (f == "square")
            {
                double b = double.Parse(Console.ReadLine());
                double area = b * b;
                Console.WriteLine(area.ToString("0.000"));
            }
            
            if (f == "rectangle") 
            {
            
                double side = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                double areaR = side * side2;

                Console.WriteLine(areaR.ToString("0.000"));

            }
            
            if (f == "circle")
            
            { 
            
                double r = double.Parse(Console.ReadLine());
                double PI = Math.PI;
                double areaC = PI * r * r;
                
                Console.WriteLine(areaC.ToString("0.000"));
            
            }
            
            if (f == "triangle")

            { 
            
                double side1 = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double areaT = side1 * h / 2;

                Console.WriteLine(areaT.ToString("0.000"));

            }

        }
       
    }
}
