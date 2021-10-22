using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Easter.Core.Contracts;
using Easter.Models.Bunnies;
using Easter.Models.Dyes;
using Easter.Models.Eggs;
using Easter.Models.Eggs.Contracts;
using Easter.Repositories;
using Easter.Utilities.Messages;

namespace Easter.Core
{
    public class Controller : IController
    {
        private BunnyRepository bunnies;
        private EggRepository eggs;
        private List<IEgg> coloredEggs;

        public string AddBunny(string bunnyType, string bunnyName)
        {
            if (bunnyType != "HappyBunny" &&
                bunnyType != "SleepyBunny")
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidBunnyType);
            }

            if (bunnyType == "HappyBunny")
            {
                HappyBunny bunny = new HappyBunny(bunnyName);
                bunnies = new BunnyRepository();
                this.bunnies.Add(bunny);
            }
            else if (bunnyType == "SleepyBunny")
            {
                SleepyBunny bunny = new SleepyBunny(bunnyName);
                bunnies = new BunnyRepository();
                this.bunnies.Add(bunny);
            }

            return $"Successfully added {bunnyType} named {bunnyName}.";
        }

        public string AddDyeToBunny(string bunnyName, int power)
        {
            if (this.bunnies.FindByName(bunnyName) == null)
            {
                throw new InvalidOperationException(ExceptionMessages.InexistentBunny);
            }

            this.bunnies.FindByName(bunnyName).AddDye(new Dye(power));

            return $"Successfully added dye with power {power} to bunny {bunnyName}!";
        }

        public string AddEgg(string eggName, int energyRequired)
        {
            eggs = new EggRepository();
            this.eggs.Add(new Egg(eggName, energyRequired));
            return $"Successfully added egg: {eggName}!";
        }

        public string ColorEgg(string eggName)
        {

            if (this.bunnies.Models.Count < 1)
            {
                throw new InvalidOperationException(ExceptionMessages.BunniesNotReady);
            }

            this.bunnies.Models.FirstOrDefault(b => b.Energy >= 50).Work();
            this.eggs.FindByName(eggName).GetColored();

            if (bunnies.Models.FirstOrDefault(b => b.Energy <= 0).Energy <= 0)
            {
                this.bunnies.Remove(bunnies.Models.FirstOrDefault(b => b.Energy <= 0));
            }

            if (this.eggs.FindByName(eggName).IsDone())
            {
                coloredEggs.Add(this.eggs.FindByName(eggName));
                return $"Egg {eggName} is done.";
            }

            return $"Egg {eggName} is not done.";

        }

        public string Report()
        {
            return $"{coloredEggs.Count} eggs are done!\r\n" +
                   $"Bunnies info:\r\n" +
                   $"{string.Join(Environment.NewLine, bunnies.ToString())}";
        }
    }
}
