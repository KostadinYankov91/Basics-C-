using System;
using System.IO;

namespace baseStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream stream = new FileStream(@"C:\Users\Voidlook\source\repos\StreamsFilesDirectories\baseStreams\students.txt", FileMode.Open))
            {

                byte[] buffer = new byte[4096];
                Console.WriteLine($"Stream position: {stream.Position}");

                for (int i = 0; i < stream.Length/buffer.Length; i++)
                {
                    stream.Read(buffer, 0, 2);

                    //Console.WriteLine($"{(char)buffer[0]}{(char)buffer[1]}");
                    //Console.WriteLine(String.Join(" ", buffer));
                }

                    Console.WriteLine($"Stream Position: {stream.Position}");
            }
        }
    }
}
