using System;
using System.Collections.Generic;

namespace radioactiveMutantVampireBunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dimension = Console.ReadLine().Split();

            int n = int.Parse(dimension[0]);
            int m = int.Parse(dimension[1]);

            char[,] field = new char[n, m];

            int playerRow = 0;
            int playerCol = 0;

            for (int row = 0; row < n; row++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();

                for (int col = 0; col < m; col++)
                {
                    field[row, col] = rowData[col]; 
                }
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    if (field[row, col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            char[] directions = Console.ReadLine().ToCharArray();
            bool IsEscaped = false;
            bool isDead = false;

            foreach (char direction in directions)
            {
                int newRowPosition = playerRow;
                int newColPosition = playerCol;

                if (direction == 'U')
                {
                    newRowPosition--;
                }
                else if (direction == 'D')
                {
                    newRowPosition++;
                }
                else if (direction == 'L')
                {
                    newColPosition--;
                }
                else if (direction == 'R')
                {
                    newColPosition++;
                }

                if (!IsValidPosition(newRowPosition, newColPosition, n, m))
                {
                    IsEscaped = true;
                    field[playerRow, playerCol] = '.';
                    // spread bunnies
                    List<int[]> bunniesCoordinates = GetBunniesCoordinates(field);
                    SpreadBunnies(bunniesCoordinates, field);

                }
                else if (field[newRowPosition, newColPosition] == '.')
                {
                    field[playerRow, playerCol] = '.';
                    field[newRowPosition, newColPosition] = 'P';
                    playerRow = newRowPosition;
                    playerCol = newColPosition;
                    // spread bunnies
                    // chekc if dead
                    List<int[]> bunniesCoordinates = GetBunniesCoordinates(field);
                    SpreadBunnies(bunniesCoordinates, field);

                    if (field[playerRow, playerCol] == 'B')
                    {
                        isDead = true;
                    }

                }
                else if (field[newRowPosition, newColPosition] == 'B')
                {
                    isDead = true;
                    field[playerRow, playerCol] = '.';
                    playerRow = newRowPosition;
                    playerCol = newColPosition;
                    List<int[]> bunniesCoordinates = GetBunniesCoordinates(field);
                    SpreadBunnies(bunniesCoordinates, field);
                    //spread bunnies
                }

                

                if (isDead || IsEscaped)
                {
                    break;
                }            
            }

            PrintField(field);
            string result = string.Empty;

            if (IsEscaped)
            {
                result += "won";
            }
            else
            {
                result += "dead";
            }

            result += $": {playerRow} {playerCol}";
            Console.WriteLine(result);
        }

        private static void PrintField(char[,] field)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    Console.Write(field[row, col]);
                }

                Console.WriteLine();

            }
        }

        private static void SpreadBunnies(List<int[]> bunniesCoordinates, char[,] field)
        {
            foreach (int[] bunnyCoordinate in bunniesCoordinates)
            {
                int row = bunnyCoordinate[0];
                int col = bunnyCoordinate[1];

                SpreadBunny(row - 1, col, field);
                SpreadBunny(row + 1, col, field);
                SpreadBunny(row, col - 1, field);
                SpreadBunny(row, col + 1, field);
            }
        }

        private static void SpreadBunny(int rows, int col, char[,] field)
        {
            int rowsLength = field.GetLength(0);
            int colsLength = field.GetLength(1);

            if (IsValidPosition(rows, col, rowsLength, colsLength))
            {
                field[rows, col] = 'B';
            }

        }

        private static List<int[]> GetBunniesCoordinates(char[,] field)
        {
            List<int[]> bunniesCoordinates = new List<int[]>();

            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if (field[row, col] == 'B')
                    {
                        bunniesCoordinates.Add(new int[] { row, col});
                    }
                }
            }

            return bunniesCoordinates;

        }

        private static bool IsValidPosition(int newRowPosition, int newColPosition, int n, int m)
        {
            return newRowPosition >= 0 && newRowPosition < n && newColPosition >= 0 && newColPosition < m;
        }
    }
}
