using System;
using System.Collections.Generic;
using System.Linq;

namespace genericsExc
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int n = int.Parse(Console.ReadLine());
            //List<Box<int>> boxes = new List<Box<int>>();
            List<Box<double>> boxes = new List<Box<double>>();

            for (int i = 0; i < n; i++)
            {
                //Box<int> box = new Box<int>(int.Parse(Console.ReadLine()));
                Box<double> boxStr = new Box<double>(double.Parse(Console.ReadLine()));
                boxes.Add(boxStr);
            }

            double value = double.Parse(Console.ReadLine());
            Box<double> box = new Box<double>(value);
            int count = GetGreaterCount(boxes, box);

            Console.WriteLine(count);
        }

        private static int GetGreaterCount<T>(List<Box<T>> boxes, Box<T> box)
            where T: IComparable
        {
            int count = 0;

            foreach (Box<T> item in boxes)
            {
                int compare = item.Value.CompareTo(box.Value);
                if (compare > 0)
                {
                    count++;
                }
            }

            return count;

        }

        private static void SwapIndicies<T>(List<Box<T>> boxes, int firstIndex, int secondIndex)
        where T: IComparable
        {
            Box<T> temp = boxes[secondIndex];
            boxes[secondIndex] = boxes[firstIndex];
            boxes[firstIndex] = temp;
        }

    }
}
