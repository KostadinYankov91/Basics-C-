using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterators
{
    public class Book<T>
    {
        public string Title { get; private set; }
        public int Year { get; private set; }
        public List<string> Authors { get; private set; }

        public Book(string title, int year, params string[] authors
            /*IEnumerable<string> authors*/)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = authors.ToList();
        }
    }
}
