using System;
using System.Collections.Generic;
using System.Text;

namespace customListCustomStack
{
    class CustomList
    {
        private const int Initialcapacity = 2;

        private int[] array;

        public int Count { get; private set; }

        public CustomList()
        {
            this.array = new int[Initialcapacity];
        }

        public int this[int index]
        {
            get
            {
                this.Validator(index);
                return this.array[index];
            }
            set
            {
                this.Validator(index);
                this.array[index] = value;
            }
        }

        public void Add(int number)
        {
            if (this.Count == this.array.Length)
            {
                this.Resize();
            }

            this.array[this.Count] = number;
            this.Count++;
        }

        public int RemoveAt(int index)
        {
            this.Validator(index);

            int number = this.array[index];
            this.array[index] = default;

            this.Shift(index);
            this.Count--;

            if (this.Count == this.array.Length / 4)
            {
                this.Shrink();
            }

            return number;
        }

        private void Shrink()
        {
            int[] copy = new int[this.array.Length / 2];
            Array.Copy(this.array, copy, this.Count);

            this.array = copy;
        }

        private void Shift(int index)
        {
            for (int i = index; i < this.Count - 1; i++)
            {
                this.array[i] = this.array[i + 1];
            }
        }

        private void Validator(int index)
        {
            if (index >= this.Count && index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        private void Resize()
        {
            int[] copy = new int[this.array.Length * 2];

            for (int i = 0; i < this.array.Length; i++)
            {
                copy[i] = this.array[i];
            }

            this.array = copy;

        }
    }
}
