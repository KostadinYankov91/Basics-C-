using System;

namespace matrixReVolt
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int commandCount = int.Parse(Console.ReadLine());

            var matrix = new char[n, n];
            int[] playerCoords = new int[2];
            int[] finalMarkCoors = new int[2];

            for (int row = 0; row < n; row++)
            {
                string rowInput = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowInput[col];
                    if (rowInput[col] == 'f')
                    {
                        playerCoords[0] = row;
                        playerCoords[1] = col;
                    }
                    if (rowInput[col] == 'F')
                    {
                        finalMarkCoors[0] = row;
                        finalMarkCoors[1] = col;
                    }
                }
            }

            int x = playerCoords[0];
            int y = playerCoords[1];

            for (int i = 1; i <= commandCount; i++)
            {
                string command = Console.ReadLine();

                Move(matrix, x, y, command);

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row, col] == 'f')
                        {
                            playerCoords[0] = row;
                            playerCoords[1] = col;

                            x = playerCoords[0];
                            y = playerCoords[1];
                            break;
                        }
                        if (matrix[x, y] == matrix[finalMarkCoors[0], finalMarkCoors[1]])
                        {
                            matrix[x, y] = 'f';
                            for (int row1 = 0; row1 < matrix.GetLength(0); row1++)
                            {
                                for (int col1 = 0; col1 < matrix.GetLength(1); col1++)
                                {
                                    Console.Write($"{matrix[row1, col1]}");
                                }

                                Console.WriteLine();
                            }

                            return;
                        }

                    }

                    if (matrix[x, y] == 'f')
                    {
                        break;
                    }
                }
            }

            Console.WriteLine("Player lost!");
            for (int row1 = 0; row1 < matrix.GetLength(0); row1++)
            {
                for (int col1 = 0; col1 < matrix.GetLength(1); col1++)
                {
                    Console.Write($"{matrix[row1, col1]}");
                }

                Console.WriteLine();
            }


        }

        public static bool IsInBounds(char[,] matrix, int x, int y)
        {

            if (x >= 0 && x <= matrix.GetLength(0) - 1 && y >= 0 && y <= matrix.GetLength(1) - 1)
            {
                return true;
            }

            return false;
        }

        public static char[,] Move(char[,] matrix, int x, int y, string direction)
        {

            switch (direction)
            {
                case "up":

                    matrix[x, y] = '-';
                    x--;
                    if (IsInBounds(matrix, x, y))
                    {
                        matrix = BonusMoves(matrix, x, y, "up");
                        if (IsF(matrix, x, y))
                        {
                            matrix[x, y] = 'f';
                            Console.WriteLine("Player won!");
                            break;
                        }
                    }
                    if (!IsInBounds(matrix, x, y))
                    {
                        MoveOutside(matrix, x, y, "up");
                    }
                    break;
                case "down":
                    if (IsInBounds(matrix, x, y))
                    {
                        matrix[x, y] = '-';
                        x++;
                        matrix = BonusMoves(matrix, x, y, "down");
                        if (IsF(matrix, x, y))
                        {
                            matrix[x, y] = 'f';
                            Console.WriteLine("Player won!");
                            break;
                        }

                    }
                    if (!IsInBounds(matrix, x, y))
                    {
                        MoveOutside(matrix, x, y, "down");
                    }
                    break;
                case "left":
                    if (IsInBounds(matrix, x, y))
                    {
                        matrix[x, y] = '-';
                        y--;
                        matrix = BonusMoves(matrix, x, y, "left");
                        if (IsF(matrix, x, y))
                        {
                            matrix[x, y] = 'f';
                            Console.WriteLine("Player won!");
                            break;
                        }
                    }
                    if (!IsInBounds(matrix, x, y))
                    {
                        MoveOutside(matrix, x, y, "left");
                    }
                    break;
                case "right":
                    if (IsInBounds(matrix, x, y))
                    {
                        matrix[x, y] = '-';
                        y++;
                        matrix = BonusMoves(matrix, x, y, "right");
                        if (IsF(matrix, x, y))
                        {
                            matrix[x, y] = 'f';
                            Console.WriteLine("Player won!");
                            break;
                        }

                    }
                    if (!IsInBounds(matrix, x, y))
                    {
                        MoveOutside(matrix, x, y, "right");
                    }
                    break;
                default:
                    break;
            }

            return matrix;

        }

        public static bool IsF(char[,] matrix, int x, int y)
        {
            if (matrix[x, y] == 'F')
            {
                return true;
            }

            return false;

        }
        public static void MoveOutside(char[,] matrix, int x, int y, string direction)
        {
            switch (direction)
            {
                case "up":
                    x = matrix.GetLength(0) - 1;
                    matrix[x, y] = 'f';
                    matrix = BonusMoves(matrix, x, y, "up");
                    break;
                case "down":
                    x = 0;
                    matrix[x, y] = 'f';
                    matrix = BonusMoves(matrix, x, y, "down");
                    break;
                case "left":
                    y = matrix.GetLength(1) - 1;
                    matrix[x, y] = 'f';
                    matrix = BonusMoves(matrix, x, y, "left");
                    break;
                case "right":
                    matrix[x, y] = '-';
                    y = 0;
                    matrix[x, y] = 'f';
                    matrix = BonusMoves(matrix, x, y, "right");
                    break;
                default:
                    break;
            }

        }
        public static char[,] BonusMoves(char[,] matrix, int x, int y, string command)
        {
            if (command == "up")
            {
                if (IsB(matrix, x, y))
                {
                    x--;
                    matrix[x, y] = 'f';
                }
                else if (IsT(matrix, x, y))
                {
                    x++;
                    matrix[x, y] = 'f';
                }
                else
                {
                    matrix[x, y] = 'f';
                }
            }
            if (command == "down")
            {
                if (IsB(matrix, x, y))
                {
                    x++;
                    matrix[x, y] = 'f';
                }
                else if (IsT(matrix, x, y))
                {
                    x--;
                    matrix[x, y] = 'f';
                }
                else
                {
                    matrix[x, y] = 'f';
                }
            }
            if (command == "left")
            {
                if (IsB(matrix, x, y))
                {
                    y--;
                    matrix[x, y] = 'f';
                }
                else if (IsT(matrix, x, y))
                {
                    y++;
                    matrix[x, y] = 'f';
                }
                else
                {
                    matrix[x, y] = 'f';
                }
            }
            if (command == "right")
            {
                if (IsB(matrix, x, y))
                {
                    y++;
                    matrix[x, y] = 'f';
                }
                else if (IsT(matrix, x, y))
                {
                    y--;
                    matrix[x, y] = 'f';
                }
                else
                {
                    matrix[x, y] = 'f';
                }
            }

            return matrix;

        }

        public static bool IsB(char[,] matrix, int x, int y)
        {
            if (matrix[x, y] != 'B')
            {
                return false;
            }

            return true;
        }
        public static bool IsT(char[,] matrix, int x, int y)
        {
            if (matrix[x, y] != 'T')
            {
                return false;
            }

            return true;
        }
    }
}
