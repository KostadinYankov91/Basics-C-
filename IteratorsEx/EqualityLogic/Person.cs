using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Diagnostics.CodeAnalysis;

namespace EqualityLogic
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public Person(string[] data)
        {
            Name = data[0];
            Age = int.Parse(data[1]);
        }
        private string Name { get; set; }
        private int Age { get; set; }
        //public Person(string[] data)
        //{
        //    this.Name = data[0];
        //    this.Age = int.Parse(data[1]);
        //}


        public int CompareTo(Person other)
        {
            if (this.Name.CompareTo(other.Name) != 0)
            {
                return this.Name.CompareTo(other.Name);
            }
            if (this.Age.CompareTo(other.Age) != 0)
            {
                return this.Age.CompareTo(other.Age);
            }
            return 0;
        }

        public override int GetHashCode()
        {
            int nameHash = this.Name.GetHashCode();
            int ageHash = this.Age.GetHashCode();

            return nameHash + ageHash;
        }

        public override bool Equals(object obj)
        {
            return this.GetHashCode() == obj.GetHashCode();
        }

    }
}
