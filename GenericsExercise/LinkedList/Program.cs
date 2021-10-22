using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicLinkedList<int> playlist = new MusicLinkedList<int>();
            while (true)
            {
                Console.WriteLine("Add music to playlist SRC: ");
                int src = int.Parse(Console.ReadLine());

                if (src == "end")
                {
                    break;
                }

                pl aylist.AddLast(new NodeMusic(src));
            }


            playlist.ForEachFromHead(s => Console.WriteLine(s.Value));

            return;
        }
    }
}
