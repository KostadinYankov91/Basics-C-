using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterators
{
    public class Library : IEnumerable<Book> 
    {
        private /*readonly*/ List<T> books;

        public Library(IEnumerable<T> books)
        {
            this.books = new List<T>(books);
        }

        public Library()
        {
            books = new List<T>();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new LibraryIterator<T>(books);
            //foreach (var book in books)
            //{
            //    yield return book;
            //}
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
