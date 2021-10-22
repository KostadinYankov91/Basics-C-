using System;

namespace Iterators
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[]
                {
                    new Book("Winnie", 1967, new string[] {"A.A. Milne"}),
                    new Book("Under the Yoke", 1895, "Ivan Vazov")
                };

            Library<Book> myLibrary = new Library<Book>(books);

            foreach (var item in myLibrary)
            {
                Console.WriteLine(item.Title);
            }
        }
    }
}
