using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchedBook = Console.ReadLine();
            string nextBook = Console.ReadLine();

            int countB = 0;

            string output = "";

            bool isFound = false;

            while (nextBook != "No More Books")
            {

                if (nextBook == searchedBook)
                {
                    isFound = true;
                    break;
                }

                countB++;
                nextBook = Console.ReadLine();
            }


            output = $"The book you search is not here!\nYou checked {countB} books.";
            
            if (isFound)
            {
                output = $"You checked {countB} books and found it.";
            }

            Console.WriteLine(output);
        }
    }
}
