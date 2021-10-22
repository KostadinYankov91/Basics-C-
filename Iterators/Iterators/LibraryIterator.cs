using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Iterators
{

    public class LibraryIterator<Т> : IEnumerator<T>
    {
        private  readonly List<Book> books;

        private int currentindex; /*= -1;*/
        public LibraryIterator(IEnumerable<Т> books)
        {
            this.Reset();
            this.books = new List<Book>(books);
        }

        object IEnumerator.Current => Current;

        public Т Current => books[currentindex];
        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            currentindex++;

            return currentindex < books.Count;
        }

        public void Reset()
        {
            currentindex = -1;
        }


    }
}