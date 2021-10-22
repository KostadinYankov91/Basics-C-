using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Easter.Models.Eggs.Contracts;
using Easter.Repositories.Contracts;

namespace Easter.Repositories
{
    public class EggRepository : IRepository<IEgg>
    {
        private List<IEgg> models;

        public EggRepository()
        {
            models = new List<IEgg>();
        }
        public IReadOnlyCollection<IEgg> Models { get => this.models; }
        public void Add(IEgg model)
        {
            this.models.Add(model);
        }

        public bool Remove(IEgg model)
        {
            if (models.Contains(model))
            {
                this.models.Remove(model);
                return true;
            }

            return false;
        }

        public IEgg FindByName(string name)
        {
            return this.models.FirstOrDefault(b => b.Name == name);
        }
    }
}
