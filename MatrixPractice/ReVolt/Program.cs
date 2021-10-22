using System;

namespace ReVolt
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int commandsCount = int.Parse(Console.ReadLine());
            string command = string.Empty;
            var matrix = new char[n, n];
            int[] playerPosition = new int[2];
            int[] finishMark = new int[2];

            for (int row = 0; row < n; row++)
            {
                string chars = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = chars[col];
                    if (matrix[row, col] == 'f')
                    {
                        playerPosition[0] = row;
                        playerPosition[1] = col;
                    }
                    if (matrix[row, col] == 'F')
                    {
                        finishMark[0] = row;
                        finishMark[1] = col;
                    }
                }
            }

            while (commandsCount > 0)
            {
                command = Console.ReadLine();
                Move(matrix, command);
                if (matrix[finishMark[0], finishMark[1]] == 'f')
                {
                    Console.WriteLine("Player won!");
                    break;
                }

                commandsCount--;
                if (commandsCount == 0)
                {
                    Console.WriteLine("Player lost!");
                    break;
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }

        public static void Move(char[,] matrix, string command)
        {
            char[,] newMatrix = matrix;
            int[] playerSpot = new int[2];
            int xPlayer = 0;
            int yPlayer = 0;
            for (int row = 0; row < newMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < newMatrix.GetLength(1); col++)
                {
                    if (newMatrix[row, col] == 'f')
                    {
                        playerSpot[0] = row;
                        playerSpot[1] = col;
                        xPlayer = playerSpot[0];
                        yPlayer = playerSpot[1];
                        if (newMatrix[xPlayer, yPlayer] == 'f')
                        {
                            break;
                        }
                    }
                }
                if (newMatrix[xPlayer, yPlayer] == 'f')
                {
                    break;
                }
            }
            if (command == "up")
            {
                newMatrix[xPlayer, yPlayer] = '-';
                xPlayer--;
                if (xPlayer < 0)
                {
                    if (newMatrix[newMatrix.GetLength(0) - 1, yPlayer] == 'B')
                    {
                        newMatrix[newMatrix.GetLength(0) - 2, yPlayer] = 'f';
                        xPlayer = newMatrix.GetLength(0) - 2;
                    }
                    if (newMatrix[newMatrix.GetLength(0) - 1, yPlayer] == 'T')
                    {
                        newMatrix[0, yPlayer] = 'f';
                        xPlayer = 0;
                    }
                    if (newMatrix[newMatrix.GetLength(0) - 1, yPlayer] == '-')
                    {
                        newMatrix[newMatrix.GetLength(0) - 1, yPlayer] = 'f';
                        xPlayer = newMatrix.GetLength(0) - 1;
                    }
                    if (newMatrix[newMatrix.GetLength(0) - 1, yPlayer] == 'F')
                    {
                        newMatrix[newMatrix.GetLength(0) - 1, yPlayer] = 'f';
                        xPlayer = newMatrix.GetLength(0) - 1;
                    }
                }
                if (newMatrix[xPlayer, yPlayer] == 'B')
                {
                    if (xPlayer == 0)
                    {
                        if (newMatrix[newMatrix.GetLength(0) - 1, yPlayer] == 'T')
                        {
                            newMatrix[xPlayer + 1, yPlayer] = 'f';
                            xPlayer++;
                        }
                        else
                        {
                            newMatrix[newMatrix.GetLength(0) - 1, yPlayer] = 'f';
                            xPlayer = newMatrix.GetLength(0) - 1;
                        }
                    }
                    else
                    {
                        newMatrix[xPlayer - 1, yPlayer] = 'f';
                    }
                }
                if (newMatrix[xPlayer, yPlayer] == 'T')
                {
                    newMatrix[xPlayer + 1, yPlayer] = 'f';
                }
                if (newMatrix[xPlayer, yPlayer] == '-')
                {
                    newMatrix[xPlayer, yPlayer] = 'f';
                }
                if (newMatrix[xPlayer, yPlayer] == 'F')
                {
                    newMatrix[xPlayer, yPlayer] = 'f';
                }
            }

            if (command == "down")
            {
                newMatrix[xPlayer, yPlayer] = '-';
                xPlayer++;
                if (xPlayer > newMatrix.GetLength(0))
                {
                    if (newMatrix[0, yPlayer] == 'B')
                    {
                        newMatrix[1, yPlayer] = 'f';
                        xPlayer = 1;
                    }
                    if (newMatrix[0, yPlayer] == 'T')
                    {
                        newMatrix[xPlayer - 1, yPlayer] = 'f';
                        xPlayer--;
                    }
                    if (newMatrix[0, yPlayer] == 'F')
                    {
                        newMatrix[0, yPlayer] = 'f';
                        xPlayer = 0;
                    }
                    if (newMatrix[0, yPlayer] == '-')
                    {
                        newMatrix[0, yPlayer] = 'f';
                        xPlayer = 0;
                    }
                }
                if (newMatrix[xPlayer, yPlayer] == 'B')
                {
                    if (xPlayer == newMatrix.GetLength(0) - 1)
                    {
                        if (newMatrix[0, yPlayer] == 'T')
                        {
                            newMatrix[xPlayer - 1, yPlayer] = 'f';
                            xPlayer--;
                        }
                        else
                        {
                            newMatrix[0, yPlayer] = 'f';
                            xPlayer = 0;
                        }
                    }
                    else
                    {
                        newMatrix[xPlayer + 1, yPlayer] = 'f';
                    }
                }
                if (newMatrix[xPlayer, yPlayer] == 'T')
                {
                    newMatrix[xPlayer - 1, yPlayer] = 'f';
                }
                if (newMatrix[xPlayer, yPlayer] == '-')
                {
                    newMatrix[xPlayer, yPlayer] = 'f';
                }
                if (newMatrix[xPlayer, yPlayer] == 'F')
                {
                    newMatrix[xPlayer, yPlayer] = 'f';
                }
            }
            if (command == "left")
            {
                newMatrix[xPlayer, yPlayer] = '-';
                yPlayer--;
                if (yPlayer < 0)
                {
                    if (newMatrix[xPlayer, newMatrix.GetLength(1) - 1] == 'B')
                    {
                        newMatrix[xPlayer, newMatrix.GetLength(1) - 2] = 'f';
                        yPlayer = newMatrix.GetLength(1) - 2;
                    }
                    if (newMatrix[xPlayer, newMatrix.GetLength(1) - 1] == 'T')
                    {
                        newMatrix[xPlayer, yPlayer + 1] = 'f';
                        yPlayer++;
                    }
                    if (newMatrix[xPlayer, newMatrix.GetLength(1) - 1] == 'F')
                    {
                        newMatrix[0, yPlayer] = 'f';
                        yPlayer = newMatrix.GetLength(1) - 1;
                    }
                    if (newMatrix[xPlayer, newMatrix.GetLength(1) - 1] == '-')
                    {
                        newMatrix[0, yPlayer] = 'f';
                        yPlayer = newMatrix.GetLength(1) - 1;
                    }
                }
                if (newMatrix[xPlayer, yPlayer] == 'F')
                {
                    newMatrix[xPlayer, yPlayer] = 'f';
                }
                if (newMatrix[xPlayer, yPlayer] == 'T')
                {
                    newMatrix[xPlayer, yPlayer + 1] = 'f';
                }
                if (newMatrix[xPlayer, yPlayer] == '-')
                {
                    newMatrix[xPlayer, yPlayer] = 'f';
                }
                if (newMatrix[xPlayer, yPlayer] == 'B')
                {
                    if (yPlayer == 0)
                    {
                        if (newMatrix[xPlayer, newMatrix.GetLength(1) - 1] == 'T')
                        {
                            newMatrix[xPlayer, yPlayer + 1] = 'f';
                            yPlayer++;
                        }
                        else
                        {
                            newMatrix[xPlayer, newMatrix.GetLength(1) - 1] = 'f';
                            yPlayer = newMatrix.GetLength(1) - 1;
                        }
                    }
                    else
                    {
                        newMatrix[xPlayer, yPlayer - 1] = 'f';
                    }
                }
            }
            if (command == "right")
            {
                newMatrix[xPlayer, yPlayer] = '-';
                yPlayer++;
                if (yPlayer > newMatrix.GetLength(1))
                {
                    if (newMatrix[xPlayer, 0] == 'B')
                    {
                        newMatrix[xPlayer, 1] = 'f';
                        yPlayer = 1;
                    }
                    if (newMatrix[xPlayer, 0] == 'T')
                    {
                        newMatrix[xPlayer, yPlayer - 1] = 'f';
                        yPlayer--;
                    }
                    if (newMatrix[xPlayer, 0] == 'F')
                    {
                        newMatrix[xPlayer, 0] = 'f';
                        yPlayer = 0;
                    }
                    if (newMatrix[xPlayer, 0] == '-')
                    {
                        newMatrix[xPlayer, 0] = 'f';
                        yPlayer = 0;
                    }
                }
                if (newMatrix[xPlayer, yPlayer] == 'F')
                {
                    newMatrix[xPlayer, yPlayer] = 'f';
                }
                if (newMatrix[xPlayer, yPlayer] == 'T')
                {
                    newMatrix[xPlayer, yPlayer - 1] = 'f';
                }
                if (newMatrix[xPlayer, yPlayer] == '-')
                {
                    newMatrix[xPlayer, yPlayer] = 'f';
                }
                if (newMatrix[xPlayer, yPlayer] == 'B')
                {
                    if (yPlayer == newMatrix.GetLength(1) - 1)
                    {
                        if (newMatrix[xPlayer, 0] == 'T')
                        {
                            newMatrix[xPlayer, yPlayer - 1] = 'f';
                            yPlayer--;
                        }
                        else
                        {
                            newMatrix[xPlayer, 0] = 'f';
                            yPlayer = 0;
                        }
                    }
                    else
                    {
                        newMatrix[xPlayer, yPlayer + 1] = 'f';
                    }
                }
            }

        }
    }
}
