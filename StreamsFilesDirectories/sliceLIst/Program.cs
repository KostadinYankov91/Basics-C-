using System;
using System.IO;

namespace sliceLIst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream streamReader = new FileStream(@"C:\Users\Voidlook\source\repos\StreamsFilesDirectories\sliceLIst\slicelist.txt", FileMode.Open))
            {
                int chunkSize = (int)Math.Ceiling(streamReader.Length / 4.0);

                for (int i = 0; i < 4; i++)
                {
                    byte[] buffer = new byte[1];
                    int count = 0;

                    using (FileStream streamWriter = new FileStream($@"C:\Users\Voidlook\source\repos\StreamsFilesDirectories\sliceLIst\slicelist-{i + 1}.txt", FileMode.Open))

                    {
                        while (count <= chunkSize)
                        {
                            streamReader.Read(buffer, 0, buffer.Length);
                            Console.WriteLine(buffer[0]);
                            streamWriter.Write(buffer, 0, buffer.Length);
                            count += buffer.Length;
                        }

                        if (streamReader.Position != streamReader.Length && i == 3)
                        {
                            int remainingBytes = (int)streamReader.Length - (int)streamReader.Position;
                            byte[] lastBuffer = new byte[streamReader.Length - streamReader.Position];
                            streamReader.Read(lastBuffer, 0 , remainingBytes);
                            streamWriter.Write(lastBuffer, 0, lastBuffer.Length);

                        }
                    }

                }


            }
        }
    }
}
}
