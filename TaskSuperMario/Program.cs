using System;
using System.Data;

namespace SUperMario
{
    class Program
    {
        static void Main(string[] args)
        {
            int e = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string[,] field = new string[n, n];

            int[] marioCoords = new int[2];
            int[] princessCoors = new int[2];

            for (int row = 0; row < n; row++)
            {
                string currRow = Console.ReadLine();

                for (int col = 0; col < currRow.Length; col++)
                {
                    field[row, col] = currRow[col].ToString();
                }
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (field[row, col] == "M")
                    {
                        marioCoords[0] = row;
                        marioCoords[1] = col;
                    }

                    if (field[row, col] == "P")
                    {
                        princessCoors[0] = row;
                        princessCoors[1] = col;
                    }

                }
            }

            string input = Console.ReadLine();
            string[] inputSplitted = input.Split();
            while (inputSplitted[0] == "W" ||
                   inputSplitted[0] == "S" ||
                    inputSplitted[0] == "A" ||
                     inputSplitted[0] == "D")
            {
                if (e < 0)
                {
                    break;
                }
                if (marioCoords[0] == princessCoors[0] &&
                    marioCoords[1] == princessCoors[1])
                {
                    break;
                }
                string[] arguments = input.Split();
                string command = arguments[0];
                int rowInput = int.Parse(arguments[1]);
                int colInput = int.Parse(arguments[2]);
                int[] currMarioCoords = new int[2];
                currMarioCoords[0] = marioCoords[0];
                currMarioCoords[1] = marioCoords[1];

                switch (command)
                {
                    case "W":
                        Spawner(field, rowInput, colInput);
                        currMarioCoords[0]--;
                        e--;
                        if (!IsInBounds(field, currMarioCoords))
                        {
                            e--;
                        }

                        if (IsOnEnemy(field, currMarioCoords))
                        {
                            e -= 2;
                            if (IsDead(e))
                            {
                                field[currMarioCoords[0], currMarioCoords[1]] = "X";
                                field[currMarioCoords[0] + 1, currMarioCoords[1]] = "-";
                                Console.WriteLine($"Mario died at {currMarioCoords[0]};{currMarioCoords[1]}.");
                                marioCoords[0] = currMarioCoords[0];
                                marioCoords[1] = currMarioCoords[1];
                                break;
                            }

                            field[currMarioCoords[0], currMarioCoords[1]] = "M";
                            field[currMarioCoords[0] + 1, currMarioCoords[1]] = "-";
                            marioCoords[0] = currMarioCoords[0];
                            marioCoords[1] = currMarioCoords[1];
                            break;
                        }
                        if (IsOnPrincess(field, currMarioCoords))
                        {
                            field[currMarioCoords[0], currMarioCoords[1]] = "-";
                            field[currMarioCoords[0] + 1, currMarioCoords[1]] = "-";
                            Console.WriteLine($"Mario has successfully saved the princess! Lives left: {e}");
                            marioCoords[0] = currMarioCoords[0];
                            marioCoords[1] = currMarioCoords[1];
                            break;
                        }
                        marioCoords[0] = currMarioCoords[0];
                        marioCoords[1] = currMarioCoords[1];
                        field[marioCoords[0], marioCoords[1]] = "M";
                        field[marioCoords[0] + 1, marioCoords[1]] = "-";
                        break;
                    case "S":
                        Spawner(field, rowInput, colInput);
                        currMarioCoords[0]++;
                        e--;
                        if (!IsInBounds(field, currMarioCoords))
                        {
                            e--;
                        }

                        if (IsOnEnemy(field, currMarioCoords))
                        {
                            e -= 2;
                            if (IsDead(e))
                            {
                                field[currMarioCoords[0], currMarioCoords[1]] = "X";
                                field[currMarioCoords[0] - 1, currMarioCoords[1]] = "-";
                                Console.WriteLine($"Mario died at {currMarioCoords[0]};{currMarioCoords[1]}.");
                                marioCoords[0] = currMarioCoords[0];
                                marioCoords[1] = currMarioCoords[1];
                                break;
                            }
                            field[currMarioCoords[0], currMarioCoords[1]] = "M";
                            field[currMarioCoords[0] - 1, currMarioCoords[1]] = "-";
                            marioCoords[0] = currMarioCoords[0];
                            marioCoords[1] = currMarioCoords[1];
                            break;
                        }
                        if (IsOnPrincess(field, currMarioCoords))
                        {
                            field[currMarioCoords[0], currMarioCoords[1]] = "-";
                            field[currMarioCoords[0] - 1, currMarioCoords[1]] = "-";
                            Console.WriteLine($"Mario has successfully saved the princess! Lives left: {e}");
                            marioCoords[0] = currMarioCoords[0];
                            marioCoords[1] = currMarioCoords[1];
                            break;
                        }
                        marioCoords[0] = currMarioCoords[0];
                        marioCoords[1] = currMarioCoords[1];
                        field[marioCoords[0], marioCoords[1]] = "M";
                        field[marioCoords[0] - 1, marioCoords[1]] = "-";
                        break;
                    case "A":
                        Spawner(field, rowInput, colInput);
                        currMarioCoords[1]--;
                        e--;
                        if (!IsInBounds(field, currMarioCoords))
                        {
                            e--;
                        }

                        if (IsOnEnemy(field, currMarioCoords))
                        {
                            e -= 2;
                            if (IsDead(e))
                            {
                                field[currMarioCoords[0], currMarioCoords[1]] = "X";
                                field[currMarioCoords[0], currMarioCoords[1] + 1] = "-";
                                Console.WriteLine($"Mario died at {currMarioCoords[0]};{currMarioCoords[1]}.");
                                marioCoords[0] = currMarioCoords[0];
                                marioCoords[1] = currMarioCoords[1];
                                break;
                            }
                            
                            field[currMarioCoords[0], currMarioCoords[1]] = "M";
                            field[currMarioCoords[0], currMarioCoords[1] + 1] = "-";
                            marioCoords[0] = currMarioCoords[0];
                            marioCoords[1] = currMarioCoords[1];
                            break;
                        }
                        if (IsOnPrincess(field, currMarioCoords))
                        {
                            field[currMarioCoords[0], currMarioCoords[1]] = "-";
                            field[currMarioCoords[0], currMarioCoords[1] + 1] = "-";
                            Console.WriteLine($"Mario has successfully saved the princess! Lives left: {e}");
                            marioCoords[0] = currMarioCoords[0];
                            marioCoords[1] = currMarioCoords[1];
                            break;
                        }
                        marioCoords[0] = currMarioCoords[0];
                        marioCoords[1] = currMarioCoords[1];
                        field[marioCoords[0], marioCoords[1]] = "M";
                        field[marioCoords[0], marioCoords[1] + 1] = "-";
                        break;
                    case "D":
                        Spawner(field, rowInput, colInput);
                        currMarioCoords[1]++;
                        e--;
                        if (!IsInBounds(field, currMarioCoords))
                        {
                            e--;
                        }

                        if (IsOnEnemy(field, currMarioCoords))
                        {
                            e -= 2;
                            if (IsDead(e))
                            {
                                field[currMarioCoords[0], currMarioCoords[1]] = "X";
                                field[currMarioCoords[0], currMarioCoords[1] - 1] = "-";
                                Console.WriteLine($"Mario died at {currMarioCoords[0]};{currMarioCoords[1]}.");
                                marioCoords[0] = currMarioCoords[0];
                                marioCoords[1] = currMarioCoords[1];
                                break;
                            }
                            field[currMarioCoords[0], currMarioCoords[1]] = "M";
                            field[currMarioCoords[0], currMarioCoords[1] - 1] = "-";
                            marioCoords[0] = currMarioCoords[0];
                            marioCoords[1] = currMarioCoords[1];
                            break;

                        }
                        if (IsOnPrincess(field, currMarioCoords))
                        {
                            field[currMarioCoords[0], currMarioCoords[1]] = "-";
                            field[currMarioCoords[0], currMarioCoords[1] - 1] = "-";
                            Console.WriteLine($"Mario has successfully saved the princess! Lives left: {e}");
                            marioCoords[0] = currMarioCoords[0];
                            marioCoords[1] = currMarioCoords[1];
                            break;
                        }
                        marioCoords[0] = currMarioCoords[0];
                        marioCoords[1] = currMarioCoords[1];
                        field[marioCoords[0], marioCoords[1]] = "M";
                        field[marioCoords[0], marioCoords[1] - 1] = "-";
                        break;
                }

                if (field[princessCoors[0], princessCoors[1]] == "-" ||
                    field[marioCoords[0], marioCoords[1]] == "X")
                {
                    break;
                }
                input = Console.ReadLine();

            }

            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    Console.Write(field[row, col]); 
                }

                Console.WriteLine();
            }

        }

        public static bool IsOnEnemy(string[,] field, int[] marioCoords)
        {
            if (field[marioCoords[0], marioCoords[1]] == "B")
            {
                return true;
            }

            return false;
        }

        public static bool IsDead(int lives)
        {
            if (lives <= 0)
            {
                return true;
            }

            return false;
        }

        public static bool IsOnPrincess(string[,] field, int[] marioCoords)
        {
            if (field[marioCoords[0], marioCoords[1]] == "P")
            {
                return true;
            }

            return false;
        }

        public static bool IsInBounds(string[,] field, int[] marioCoords)
        {
            if (marioCoords[0] > field.GetLength(0) || marioCoords[1] > field.GetLength(1))
            {
                return false;
            }

            return true;
        }

        public static void Spawner(string[,] field, int row, int col)
        {
            field[row, col] = "B";
        }
    }
}
