
using System;
using System.Linq;

namespace moreExcerciseArrays
{
    class Program
    {


        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] sequence = Console.ReadLine().Split($"{}").ToArray();

            int[] sumTotalArray = new int[sequence.Length];
            string[] names = new string[sequence.Length];

            for (int i = 0; i < sequence.Length; i++)
            {
                string currentWord = sequence[i];
                char[] lettersInCurrentWord = currentWord.ToCharArray();

                int sumVowels = 0;
                int sumConsonants = 0;
                int sumTotal = 0;

                foreach (char lett in lettersInCurrentWord)
                {
                    int ascii = lett;

                    if (ascii == 65 || ascii == 97 || ascii == 69 || ascii == 101)
                    {
                        sumVowels += ascii * lettersInCurrentWord.Length;
                    }
                    else if (ascii == 73 || ascii == 105 || ascii == 79 || ascii == 111)
                    {
                        sumVowels += ascii * lettersInCurrentWord.Length;

                    }
                    else if (ascii == 89 || ascii == 121)
                    {
                        sumVowels += ascii * lettersInCurrentWord.Length;

                    }
                    else if (ascii == 85 || ascii == 117)
                    {
                        sumVowels += ascii * lettersInCurrentWord.Length;
                    }
                    else
                    {
                        sumConsonants += ascii / lettersInCurrentWord.Length;
                    }

                    sumTotal = sumConsonants + sumVowels;

                }


                sumTotalArray[i] = sumTotal;
                sumTotal = 0;
            
            }
            
            Array.Sort(sumTotalArray);

            foreach (var item in sumTotalArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
