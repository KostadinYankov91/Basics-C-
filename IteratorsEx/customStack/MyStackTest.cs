using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace customStack
{
    public class MyStackTest<T> : IEnumerable<T>
    {
        private Stack<T> items;
        private int index = 0;

        public MyStackTest()
        {
            this.items = new Stack<T>();
        }
        public MyStackTest(Stack<T> items)
        {
            this.items = items;
        }
        public void Push(T num)
        {
            items.Push(num);
        }

        public void Pop()
        {
            this.items.Pop();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
