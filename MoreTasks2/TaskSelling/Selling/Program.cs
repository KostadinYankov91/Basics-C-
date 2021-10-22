using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Linq;

namespace Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] field = new char[n, n];
            //int playerCoordsRow = 0;
            //int playerCoordsCol = 0;
            //int pillarCoordsRow = 0;
            //int pillarCoordsCol = 0;
            int starsCollected = 0;

            int[] player = new int[2];
            List<int[]> pillars = new List<int[]>();

            for (int row = 0; row < n; row++)
            {
                string currChar = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    field[row, col] = currChar[col];
                }
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (field[row, col] == 'S')
                    {
                        player[0] = row;
                        player[1] = col;
                    }
                    else if (field[row, col] == 'O')
                    {
                        pillars.Add(new int[] { row, col });
                    }
                }
            }

            string direction;

            while (true)
            {
                direction = Console.ReadLine();
                if (IsNumber(field, player, direction))
                {
                    starsCollected = StarsCalculator(field, player, starsCollected, direction);
                }

                Move(field, player, pillars, direction);

                if (player[0] > field.GetLength(0) - 1 || player[1] > field.GetLength(1) - 1)
                {
                    break;
                }
                if (starsCollected >= 50)
                {
                    Console.WriteLine("Good news! You succeeded in collecting enough money!");
                    break;
                }
            }

            Console.WriteLine($"Money: {starsCollected}");
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(field[row, col]);
                }

                Console.WriteLine();
            }
        }

        public static bool IsNumber(char[,] field, int[] player, string direction)
        {
            int[] currPlayer = player;
            switch (direction)
            {
                case "right":
                    currPlayer[1]++;
                    if (IsInBounds(field, currPlayer))
                    {
                        if (field[currPlayer[0], currPlayer[1]] != '-' &&
                            field[currPlayer[0], currPlayer[1]] != 'O')
                        {
                            return true;
                        }
                    }
                    break;
                case "left":
                    currPlayer[1]--;
                    if (IsInBounds(field, currPlayer))
                    {
                        if (field[currPlayer[0], currPlayer[1]] != '-' &&
                            field[currPlayer[0], currPlayer[1]] != 'O')
                        {
                            return true;
                        }
                    }
                    break;
                case "up":
                    currPlayer[0]--;
                    if (IsInBounds(field, currPlayer))
                    {
                        if (field[currPlayer[0], currPlayer[1]] != '-' &&
                            field[currPlayer[0], currPlayer[1]] != 'O')
                        {
                            return true;
                        }
                    }
                    break;
                case "down":
                    currPlayer[1]++;
                    if (IsInBounds(field, currPlayer))
                    {
                        if (field[currPlayer[0], currPlayer[1]] != '-' &&
                            field[currPlayer[0], currPlayer[1]] != 'O')
                        {
                            return true;
                        }
                    }
                    break;
            }

            return false;

        }
        public static int StarsCalculator(char[,] field, int[] player, int starsCollected, string direction)
        {
            string starValue;
            if (direction == "right")
            {
                starValue = field[player[0], player[1] + 1].ToString();
                if (starValue == "-")
                {
                    return starsCollected;
                }
                starsCollected += int.Parse(starValue);
                return starsCollected;
            }
            if (direction == "left")
            {
                starValue = field[player[0], player[1] - 1].ToString();
                if (starValue == "-")
                {
                    return starsCollected;
                }
                starsCollected += int.Parse(starValue);
                return starsCollected;
            }
            if (direction == "up")
            {
                starValue = field[player[0] - 1, player[1]].ToString();
                if (starValue == "-")
                {
                    return starsCollected;
                }
                starsCollected += int.Parse(starValue);
                return starsCollected;
            }

            starValue = field[player[0] + 1, player[1]].ToString();
            if (starValue == "-")
            {
                return starsCollected;
            }
            starsCollected += int.Parse(starValue);
            return starsCollected;
        }
        public static bool IsOnPillar(char[,] field, int[] player)
        {
            if (field[player[0], player[1]] == 'O')
            {
                return true;
            }

            return false;
        }

        public static bool IsInBounds(char[,] field, int[] player)
        {
            if (player[0] > field.GetLength(0) - 1 || player[1] > field.GetLength(1) - 1)
            {
                return false;
            }

            return true;
        }
        public static void Move(char[,] field, int[] player, List<int[]> pillars, string direction)
        {
            string currClient = string.Empty;

            switch (direction)
            {
                case "right":
                    player[1]++;
                    if (!IsInBounds(field, player))
                    {
                        field[player[0], player[1] - 1] = '-';
                        Console.WriteLine("Bad news, you are out of the bakery.");
                    }
                    else if (IsOnPillar(field, player))
                    {
                        field[player[0], player[1]--] = '-';
                        field[player[0], player[1]] = '-';
                        player[0] = pillars[1][0];
                        player[1] = pillars[1][1];
                        field[player[0], player[1]] = 'S';
                    }
                    else if (field[player[0], player[1]] != '-')
                    {
                        field[player[0], player[1]] = 'S';
                        field[player[0], player[1] - 1] = '-';
                    }
                    else if (field[player[0], player[1]] == '-')
                    {
                        field[player[0], player[1]] = 'S';
                        field[player[0], player[1] + 1] = '-';
                    }
                    break;
                case "left":
                    player[1]--;
                    if (!IsInBounds(field, player))
                    {
                        field[player[0], player[1] + 1] = '-';
                        Console.WriteLine("Bad news, you are out of the bakery.");
                    }
                    else if (IsOnPillar(field, player))
                    {
                        field[player[0], player[1]--] = '-';
                        field[player[0], player[1]] = '-';
                        player[0] = pillars[1][0];
                        player[1] = pillars[1][1];
                        field[player[0], player[1]] = 'S';
                    }
                    else if (field[player[0], player[1]] != '-')
                    {
                        field[player[0], player[1]] = 'S';
                        field[player[0], player[1] + 1] = '-';
                    }
                    else if (field[player[0], player[1]] == '-')
                    {
                        field[player[0], player[1]] = 'S';
                        field[player[0], player[1] + 1] = '-';
                    }
                    break;
                case "up":
                    player[0]--;
                    if (!IsInBounds(field, player))
                    {
                        field[player[0] + 1, player[1]] = '-';
                        Console.WriteLine("Bad news, you are out of the bakery.");
                    }
                    else if (IsOnPillar(field, player))
                    {
                        field[player[0], player[1]--] = '-';
                        field[player[0], player[1]] = '-';
                        player[0] = pillars[1][0];
                        player[1] = pillars[1][1];
                        field[player[0], player[1]] = 'S';
                    }
                    else if (field[player[0], player[1]] != '-')
                    {
                        field[player[0], player[1]] = 'S';
                        field[player[0] + 1, player[1]] = '-';
                    }
                    else if (field[player[0], player[1]] == '-')
                    {
                        field[player[0], player[1]] = 'S';
                        field[player[0] + 1, player[1]] = '-';
                    }
                    break;
                case "down":
                    player[0]++;
                    if (!IsInBounds(field, player))
                    {
                        field[player[0] - 1, player[1]] = '-';
                        Console.WriteLine("Bad news, you are out of the bakery.");
                    }
                    else if (IsOnPillar(field, player))
                    {
                        field[player[0], player[1]--] = '-';
                        field[player[0], player[1]] = '-';
                        player[0] = pillars[1][0];
                        player[1] = pillars[1][1];
                        field[player[0], player[1]] = 'S';
                    }
                    else if (field[player[0], player[1]] != '-')
                    {
                        field[player[0], player[1]] = 'S';
                        field[player[0] - 1, player[1]] = '-';
                    }
                    else if (field[player[0], player[1]] == '-')
                    {
                        field[player[0], player[1]] = 'S';
                        field[player[0] - 1, player[1]] = '-';
                    }
                    break;
            }
        }
    }
}
