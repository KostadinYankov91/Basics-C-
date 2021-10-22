using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Diagnostics.CodeAnalysis;

namespace comparingObjects
{
    public class PersonOne : IComparable<PersonOne>
    {
        private string[] Data;
        private string Name { get; set; }
        private int Age { get; set; }
        private string Town { get; set; }
        
        public PersonOne(string name, int age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }
        public PersonOne(string[] data)
        {
            this.Name = data[0];
            this.Age = int.Parse(data[1]);
            this.Town = data[2];
        }


        public int CompareTo(PersonOne other)
        {
            if (this.Name.CompareTo(other.Name) != 0)
            {
                return this.Name.CompareTo(other.Name);
            }
            if (this.Age.CompareTo(other.Age) != 0)
            {
                return this.Age.CompareTo(other.Age);
            }
            if (this.Town.CompareTo(other.Town) != 0)
            {
                return this.Town.CompareTo(other.Town);
            }

            return 0;
        }

    }
}
