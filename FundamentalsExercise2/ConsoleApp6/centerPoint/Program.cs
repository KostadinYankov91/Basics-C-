using System;

namespace centerPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstPoint = new int[2];
            int[] secondPoint = new int[2];

            CenterPoint(firstPoint, secondPoint);



            //int firstNum = int.Parse(Console.ReadLine());
            //int secondNum = int.Parse(Console.ReadLine());

            

        }

        private static string CenterPoint(int[] firstPoint, int[] secondPoint)
        {

             
            
            for (int i = 0; i < firstPoint.Length; i++)
            {
                int coord1 = int.Parse(Console.ReadLine());
                firstPoint[0] = coord1;
                int coord2 = int.Parse(Console.ReadLine());
                firstPoint[1] = coord2;
            }
            for (int k = 0; k < secondPoint.Length; k++)
            {
                int coord1 = int.Parse(Console.ReadLine());
                secondPoint[0] = coord1;
                int coord2 = int.Parse(Console.ReadLine());
                secondPoint[1] = coord2;
            }


            int sumFirstPoint = firstPoint[0] + firstPoint[1];
            int sumSecondPoint = secondPoint[0] + secondPoint[1];

            if (sumFirstPoint < sumSecondPoint)
            {
                return $"{firstPoint[0]}, {firstPoint[1]}";
            }
            else
            {
                return $"{secondPoint[0]}, {secondPoint[1]}";
            }
        }
    }
}
