using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public abstract class Soldier : ISoldier
    {
        public Soldier(string id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.Lastname = lastName;
        }
        public string Id { get; }

        public string FirstName { get; }

        public string Lastname { get; }

        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.Lastname} Id: {this.Id}";
        }
    }
}
