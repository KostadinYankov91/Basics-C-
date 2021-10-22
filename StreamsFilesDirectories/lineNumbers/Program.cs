using System;
using System.IO;

namespace lineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../output.txt"))
            {
                using (StreamWriter writer = new StreamWriter("../../../output.txt"))
                {
                    string line = reader.ReadLine();
                    int row = 1;

                    while (line != null)
                    {
                        //line.Insert(0, row.ToString());
                        writer.WriteLine($"{row}. {line}");
                        row++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
