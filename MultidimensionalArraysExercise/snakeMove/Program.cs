using System;
using System.Linq;

namespace snakeMove
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int totalRows = dimensions[0];
            int totalCols = dimensions[1];

            string word = Console.ReadLine();
            
            int[,] matrix = new int[totalRows, totalCols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                //int fullStringLength = (totalRows * totalCols) / word.Length * word.Length; 
                char[] wordChars = new char[word.Length];

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    wordChars[col] = word[col];
                    matrix[row, col] = wordChars[col];
                }
            }
        }
    }
}
