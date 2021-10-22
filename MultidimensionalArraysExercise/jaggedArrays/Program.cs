using System;

namespace jaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[3][];
            int[][] jagged = new int[5][]
                {
                    new int[] { 1,2,3,4,5},
                    new int[] { 1,2,3,4,5},
                    new int[] { 1,2,3,4,5},
                    new int[] { 1,2,3,4,5},
                    new int[] { 1,2,3,4,5}

                };
            for (int row = 0; row < jagged.Length; row++)
            {
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    Console.Write(jagged[row][col]);
                }
                
                Console.WriteLine();
            }

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[6];
            jaggedArray[2] = new int[7  ];

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    jaggedArray[row][col] = int.Parse(Console.ReadLine());
                }
            }

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write(jaggedArray[row][col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
