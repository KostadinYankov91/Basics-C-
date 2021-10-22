using System;
using System.Linq;
using System.Text;

namespace sb
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            while ((word = Console.ReadLine()) != "end")
            {
                word.ToCharArray();
                Console.Write($"{string.Join("", word)} =");
                Console.WriteLine($" {string.Join("", word.Reverse())}");
            }
        }
    }
}
