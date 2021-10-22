using System;
using System.Runtime.InteropServices;

namespace whileCyclesEx
{ 
    
        class Program
        {
            static void Main(string[] args)
            {
                string searchedBook = Console.ReadLine();
                string nextBook = Console.ReadLine();

                int countB = 0;

                string output = "";

                while (nextBook != "No More Books")
                {

                    if (nextBook == searchedBook)
                    {
                        output = $"You checked {countB} books and found it.";
                        break;
                    }
                    else if (nextBook != searchedBook)
                    {
                        countB++;
                    }

                    else if (nextBook == "No More Books")
                    {
                        output = $"The book you search is not here!\nYou checked {countB} books.";
                        break;
                    }

                    nextBook = Console.ReadLine();
                }

                Console.WriteLine(output);

            }
        }
    }




