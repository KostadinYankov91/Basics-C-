using System;
using System.Collections.Generic;
using System.Text;
using Easter.Models.Bunnies.Contracts;
using Easter.Models.Dyes.Contracts;
using Easter.Utilities.Messages;

namespace Easter.Models.Bunnies
{
    public abstract class Bunny : IBunny
    {
        private string name;
        protected int energy;
        private ICollection<IDye> dyes;

        public Bunny(string name, int energy)
        {
            this.Name = name;
            this.Energy = energy;
            this.dyes = new List<IDye>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace((value)))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidBunnyName);
                }

                this.name = value;
            }
        }

        public int Energy
        {
            get => this.energy;
            private set
            {
                if (this.energy < 0)
                {
                    this.energy = 0;
                }
            }
        }

        public ICollection<IDye> Dyes
        {
            get => dyes;
        }

        public virtual void Work()
        {
            this.energy -= 10;
            if (this.energy < 0)
            {
                this.energy = 0;
            }
        }

        public void AddDye(IDye dye)
        {
            dyes.Add(dye);
        }

        public override string ToString()
        {
            return $"Name: {this.Name}\r\n" +
                   $"Energy: {this.Energy}\r\n" +
                   $"Dyes: {dyes.Count} not finished";
        }
    }
}
