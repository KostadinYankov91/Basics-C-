using System;
using System.Collections.Generic;
using System.Linq;

namespace theFinalQuest
{
    class Program
    {

        static void SwapList(List<string> words, string stringOne, string stringTwo)
        {

            if (words.Contains(stringOne) && words.Contains(stringTwo))
            {
                int firstIndex = words.IndexOf(stringOne);
                int secondIndex = words.IndexOf(stringTwo);

                words[secondIndex] = stringOne;
                words[firstIndex] = stringTwo;
            }

            return;
        }
        static void ReplaceWord(List<string> words, string stringOne, string stringTwo)
        {

            if (words.Contains(stringTwo))
            {
                int secondIndex = words.IndexOf(stringTwo);
                words[secondIndex] = stringOne;
            }

            return;
        }

        static void PutWord(List<string> words, string stringOne, int index)
        {
            if (index > 0 && index < words.Count + 1)
            {
                words.Insert(index - 1, stringOne);
            }
            else if (index == words.Count)
            {
                words.Add(stringOne);
            }

            return;
        }

        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();
            //List<string> input = Console.ReadLine().Split().ToList();

            int iterations = 0;
            string valueToRemove = string.Empty;
            int indexToRemoveAt = 0;

            string input;

            while ((input = Console.ReadLine()) != "Stop")
            {

                string[] arguments = input.Split();
                string command = arguments[0];
                string word = arguments[1];

                if (arguments.Length > 2)
                {
                    string wordTwo = arguments[2];

                    if (command == "Swap")
                    {
                        SwapList(words, word, wordTwo);
                    }
                    else if (command == "Put")
                    {
                        PutWord(words, word, int.Parse(wordTwo));
                    }
                    else if (command == "Replace")
                    {
                        ReplaceWord(words, word, wordTwo);
                    }

                }

                else if (command == "Delete")
                {
                    valueToRemove = word;
                    indexToRemoveAt = int.Parse(valueToRemove);

                    if (indexToRemoveAt + 1 < words.Count - 1)
                    {
                        words.RemoveAt(indexToRemoveAt + 1);
                    }
                }

                else if (command == "Sort")
                {
                    words.Sort();

                    while (iterations < words.Count - 1)
                    {
                        iterations++;
                        words.Add(words[0]);
                        words.RemoveAt(0);
                    }

                }

                //input = Console.ReadLine();
                //input = Console.ReadLine().Split().ToList();

            }

            Console.WriteLine(string.Join(' ', words));

        }
    }
}