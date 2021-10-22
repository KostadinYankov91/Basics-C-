using System;
using System.Collections.Generic;
using System.Text;

namespace Selling2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[,] field = new string[n, n];
            int playerCoordsRow = 0;
            int playerCoordsCol = 0;
            int pillarCoordsRow = 0;
            int pillarCoordsCol = 0;
            int starsCollected = 0;
            StringBuilder stringStarsCollected = new StringBuilder();
            int[] player = new int[2];

            List<int[]> pillars = new List<int[]>();

            for (int row = 0; row < n; row++)
            {
                string currChar = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    field[row, col] = currChar[col].ToString();
                }
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (field[row, col] == "S")
                    {
                        playerCoordsRow = row;
                        playerCoordsCol = col;
                        player[0] = playerCoordsRow;
                        player[1] = playerCoordsCol;

                    }
                    else if (field[row, col] == "O")
                    {
                        pillarCoordsRow = row;
                        pillarCoordsCol = col;
                        pillars.Add(new[] { pillarCoordsRow, pillarCoordsCol });
                    }
                }
            }

            string direction = Console.ReadLine();

            while (true)
            {
                Move(field, player, direction, pillars, stringStarsCollected);
                starsCollected += int.Parse(stringStarsCollected.ToString());
                if (!IsInBounds(field, player))
                {
                    Console.WriteLine($"Bad news, you are out of the bakery.\r\n" +
                                      $"Money: {starsCollected}");
                    for (int row = 0; row < field.GetLength(0); row++)
                    {
                        for (int col = 0; col < field.GetLength(1); col++)
                        {
                            Console.Write(field[row, col]);
                        }

                        Console.WriteLine();
                    }
                    return;
                }

                if (starsCollected >= 50)
                {
                    Console.WriteLine("Good news! You succeeded in collecting enough money!\r\n" +
                                      $"Money: {starsCollected}");
                    for (int row = 0; row < field.GetLength(0); row++)
                    {
                        for (int col = 0; col < field.GetLength(1); col++)
                        {
                            Console.Write(field[row, col]);
                        }

                        Console.WriteLine();
                    }
                    return;
                }

                direction = Console.ReadLine();
            }

        }

        public static void Move(string[,] field, int[] player, string direction, List<int[]> pillars, StringBuilder stringStarsCollected)
        {
            int[] currPlayer = { player[0], player[1] };
            int currStarCollected = 0;
            switch (direction)
            {
                case "right":
                    currPlayer[1]++;
                    if (!IsInBounds(field, currPlayer))
                    {
                        field[player[0], player[1]] = "-";
                        player[0] = currPlayer[0];
                        player[1] = currPlayer[1];
                        break;
                    }
                    if (IsOnPillar(field, currPlayer))
                    {
                        player[1]++;
                        field[player[0], player[1] - 1] = "-";
                        Teleport(field, player, pillars);
                        break;
                    }
                    if (IsOnClient(field, currPlayer))
                    {
                        player[1]++;
                        currStarCollected = currStarCollected + StarsAdder(field, player, currStarCollected);
                        stringStarsCollected.Append(currStarCollected.ToString());
                        field[player[0], player[1]] = "S";
                        field[player[0], player[1] - 1] = "-";
                        break;
                    }
                    field[player[0], player[1] + 1] = "S";
                    field[player[0], player[1]] = "-";
                    break;
                case "left":
                    currPlayer[1]--;
                    if (!IsInBounds(field, currPlayer))
                    {
                        field[player[0], player[1]] = "-";
                        player[0] = currPlayer[0];
                        player[1] = currPlayer[1];
                        break;
                    }
                    if (IsOnPillar(field, currPlayer))
                    {
                        player[1]--;
                        field[player[0], player[1] + 1] = "-";
                        Teleport(field, player, pillars);
                        break;
                    }
                    if (IsOnClient(field, currPlayer))
                    {
                        player[1]--;
                        currStarCollected = currStarCollected + StarsAdder(field, player, currStarCollected);
                        stringStarsCollected = currStarCollected.ToString();
                        field[player[0], player[1]] = "S";
                        field[player[0], player[1] + 1] = "-";
                        break;
                    }
                    field[player[0], player[1] - 1] = "S";
                    field[player[0], player[1]] = "-";
                    break;
                case "up":
                    currPlayer[0]--;
                    if (!IsInBounds(field, currPlayer))
                    {
                        field[player[0], player[1]] = "-";
                        player[0] = currPlayer[0];
                        player[1] = currPlayer[1];
                        break;
                    }
                    if (IsOnPillar(field, currPlayer))
                    {
                        player[0]--;
                        field[player[0] + 1, player[1]] = "-";
                        Teleport(field, player, pillars);
                        break;
                    }
                    if (IsOnClient(field, currPlayer))
                    {
                        player[0]--;
                        currStarCollected = currStarCollected + StarsAdder(field, player, currStarCollected);
                        stringStarsCollected = currStarCollected.ToString();
                        field[player[0], player[1]] = "S";
                        field[player[0] + 1, player[1]] = "-";
                        break;
                    }
                    field[player[0] - 1, player[1]] = "S";
                    field[player[0], player[1]] = "-";
                    break;
                case "down":
                    currPlayer[0]++;
                    if (!IsInBounds(field, currPlayer))
                    {
                        field[player[0], player[1]] = "-";
                        player[0] = currPlayer[0];
                        player[1] = currPlayer[1];
                        break;
                    }
                    if (IsOnPillar(field, currPlayer))
                    {
                        player[0]++;
                        field[player[0] - 1, player[1]] = "-";
                        Teleport(field, player, pillars);
                        break;
                    }
                    if (IsOnClient(field, currPlayer))
                    {
                        player[0]++;
                        currStarCollected = currStarCollected + StarsAdder(field, player, currStarCollected);
                        stringStarsCollected = currStarCollected.ToString();
                        field[player[0], player[1]] = "S";
                        field[player[0] - 1, player[1]] = "-";
                        break;
                    }
                    field[player[0] + 1, player[1]] = "S";
                    field[player[0], player[1]] = "-";
                    break;
            }
        }

        public static bool IsInBounds(string[,] field, int[] player)
        {
            if (player[0] > field.GetLength(0) - 1 || player[1] > field.GetLength(1) - 1)
            {
                return false;
            }

            return true;
        }

        public static bool IsOnPillar(string[,] field, int[] player)
        {
            if (field[player[0], player[1]] == "O")
            {
                return true;
            }

            return false;
        }

        public static void Teleport(string[,] field, int[] player, List<int[]> pillars)
        {
            if (field[player[0], player[1]] == field[pillars[0][0], pillars[0][1]])
            {
                field[player[0], player[1]] = "-";
                field[pillars[1][0], pillars[1][1]] = "S";
                player[0] = pillars[1][0];
                player[1] = pillars[1][1];
            }
            else if (field[player[0], player[1]] == field[pillars[1][0], pillars[1][1]])
            {
                field[player[0], player[1]] = "-";
                field[pillars[0][0], pillars[0][1]] = "S";
                player[0] = pillars[0][0];
                player[1] = pillars[0][1];
            }
        }

        public static bool IsOnClient(string[,] field, int[] player)
        {
            if (field[player[0], player[1]] != "-" &&
                field[player[0], player[1]] != "O")
            {
                return true;
            }

            return false;
        }
        public static int StarsAdder(string[,] field, int[] player, int starsCollected)
        {
            starsCollected += int.Parse(field[player[0], player[1]]);

            return starsCollected;
        }
    }
}
