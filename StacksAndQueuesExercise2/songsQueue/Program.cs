using System;
using System.Collections.Generic;
using System.Linq;

namespace songsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songsInput = Console.ReadLine().Split(", ");

            Queue<string> playlist = new Queue<string>(songsInput);

            while (playlist.Any())
            {
                if (!playlist.Any())
                {
                    break;
                }
                string input = Console.ReadLine();

                string[] arguments = input.Split();

                if (arguments[0] == "Play")
                {
                    playlist.Dequeue();
                }
                else if (arguments[0] == "Show")
                {
                    Console.WriteLine(string.Join(", ", playlist));
                }
                else if (arguments[0] == "Add")
                {
                    if (arguments.Length < 3)
                    {
                        string songSingleName = arguments[1];
                        if (playlist.Contains(songSingleName))
                        {
                            Console.WriteLine($"{songSingleName} is already contained!");
                        }
                        else
                        {
                            playlist.Enqueue(arguments[1]);
                        }
                    }
                    else if (arguments.Length == 3)
                    {
                        string songName = arguments[1] + " " + arguments[2];
                        if (playlist.Contains(songName))
                        {
                            Console.WriteLine($"{songName} is already contained!");
                        }
                        else
                        {
                            playlist.Enqueue(songName);
                        }
                    }
                    else if (arguments.Length == 4)
                    {
                        string songName = arguments[1] + " " + arguments[2] + " " + arguments[3];
                        if (playlist.Contains(songName))
                        {
                            Console.WriteLine($"{songName} is already contained!");
                        }
                        else
                        {
                            playlist.Enqueue(songName);
                        }
                    }
                    else if (arguments.Length == 5)
                    {
                        string songName = arguments[1] + " " + arguments[2] + " " + arguments[3] + " " + arguments[4];
                        if (playlist.Contains(songName))
                        {
                            Console.WriteLine($"{songName} is already contained!");
                        }
                        else
                        {
                            playlist.Enqueue(songName);
                        }
                    }
                }

            }

            Console.WriteLine("No more songs!");

        }
    }
}
