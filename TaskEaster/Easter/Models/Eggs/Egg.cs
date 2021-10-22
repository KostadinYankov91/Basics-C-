using System;
using System.Collections.Generic;
using System.Text;
using Easter.Models.Eggs.Contracts;
using Easter.Utilities.Messages;

namespace Easter.Models.Eggs
{
    public class Egg : IEgg
    {
        private string name;
        private int energyRequired;

        public Egg(string name, int energyRequired)
        {
            this.Name = name;
            this.EnergyRequired = energyRequired;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidEggName);
                }
            }
        }

        public int EnergyRequired
        {
            get => this.energyRequired;
            private set
            {
                if (this.energyRequired < 0)
                {
                    this.energyRequired = 0;
                }

                this.energyRequired = value;
            }
        }

        public void GetColored()
        {
            this.energyRequired -= 10;
            if (this.energyRequired < 0)
            {
                this.energyRequired = 0;
            }
        }

        public bool IsDone()
        {
            if (energyRequired == 0)
            {
                return true;
            }

            return false;
        }
    }
}
