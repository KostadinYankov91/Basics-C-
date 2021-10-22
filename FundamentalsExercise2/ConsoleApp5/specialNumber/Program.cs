using System;

namespace specialNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {

                if (i == 5 || i == 7 || i == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }

                if (i > 11)
                {
                    int sum = 0;
                    for (int j = i; j > 0; j /= 10)
                    {
                        int jNumber = j;

                        jNumber %= 10;

                        if (jNumber <= 9 && jNumber > 0)
                        {
                            sum += jNumber;
                        }
                        else if (sum == 5 || sum == 7 || sum == 11)
                        {
                            Console.WriteLine($"{j} -> True");
                            break;
                        }
                        else if (sum != 5 || sum != 7 || sum != 11)
                        {
                            Console.WriteLine($"{i} -> False");
                            break;
                        }
                    }


                }
                else
                {

                    Console.WriteLine($"{i} -> False");
                }

            }
        }
    }
}
