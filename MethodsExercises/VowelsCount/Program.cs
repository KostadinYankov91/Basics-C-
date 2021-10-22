using System;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine().ToLower();

            int counter = Vowels(str);

            Console.WriteLine(counter);

        }

        public static int Vowels(string str)
        {
            int counter = 0;

            for (int i = 0; i < str.Length; i++)
            {
                char currentChar = str[i];

                if (currentChar == 'a')
                {
                    counter++;
                }
                else if (currentChar == 'e')
                {
                    counter++;
                }
                else if (currentChar == 'i')
                {
                    counter++;
                }
                else if (currentChar == 'o')
                {
                    counter++;
                }
                else if (currentChar == 'u')
                {
                    counter++;
                }
            }

            return counter;

        }
    }



}
