﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsEx
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> items;
        private int index;
        public ListyIterator(List<T> items)
        {
            this.items = items;
            this.index = 0;
        }

        public ListyIterator(params T[] items)
        {
            this.items = items.ToList();
            this.index = 0;
        }


        public bool Move()
        {
            bool hasNext = this.HasNext();
            if (hasNext)
            {
                this.index++;
            }

            return hasNext;

        }
        public void Print()
        {
            if (this.index >= items.Count || this.index < 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Console.WriteLine(this.items[this.index]);

        }
        public void PrintAll()
        {
            foreach (T item in items)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
        }
        public bool HasNext() =>
            this.index < this.items.Count - 1;

        public IEnumerator<T> GetEnumerator()
        {
            //foreach (T item in items)
            //{
            //    yield return item;
            //}

            return new Enumerator(this.items);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private class Enumerator : IEnumerator<T>
        {
            private List<T> elements;
            private int index;
            public Enumerator(List<T> elements)
            {
                this.elements = elements;
                this.index = - 1;
            }

            public T Current 
            { 
                get 
                {
                    if (this.index >= this.elements.Count || this.index < 0)
                    {
                        throw new InvalidOperationException("Invalid Operation!");
                    }
                    return this.elements[this.index];
                } 
            }

            object IEnumerator.Current => this.Current;

            public bool MoveNext()
            {
                bool hasNext = this.index < this.elements.Count - 1;
                if (hasNext)
                {
                    this.index++;
                }

                return hasNext;
            }

            public void Reset()
            {
                this.index = -1;
            }

            public void Dispose()
            {
            }
        }

    }

}
