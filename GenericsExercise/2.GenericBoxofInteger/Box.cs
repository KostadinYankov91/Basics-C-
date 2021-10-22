using System;
using System.Collections.Generic;
using System.Text;

namespace _2.GenericBoxofInteger
{
    class Box<T>
    {
        public Box(T value)
        {
            this.Value = value;
        }
        public T Value { get; private set; }

        public override string ToString()
        {
            Type valueType = this.Value.GetType();
            string valueTypename = valueType.Name;
            string valueTypeFullName = valueType.FullName;
            return $"{valueTypeFullName}: {this.Value}";
        }
    }
}
