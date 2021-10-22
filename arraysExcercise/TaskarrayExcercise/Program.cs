using System;
using System.Linq;

namespace arrayExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            string[] names = new string[n];
            int[] sumS = new int[n];

            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Console.ReadLine();

                string currentName = names[i];
                string vowel = "AaEeIiOoUu";

                int sum = 0;

                for (int j = 0; j < currentName.Length; j++)
                {
                    char letter = currentName[j];
                    if (vowel.Contains(letter))
                    {
                        sum += (letter * currentName.Length);
                    }
                    else
                    {
                        sum += (letter / currentName.Length);
                    }
                }

                sumS[i] = sum;

            }


            for (int i = 0; i < sumS.Length - 1; i++)
            {
                for (int j = i + 1; j < sumS.Length; j++)
                {
                    int temp;

                    if (sumS[i] > sumS[j])
                    {
                        temp = sumS[i];
                        sumS[i] = sumS[j];
                        sumS[j] = temp;
                    }
                }
            }

            for (int i = 0; i < sumS.Length; i++)
            {
                Console.WriteLine(sumS[i]);
            }


        }

    }
}
