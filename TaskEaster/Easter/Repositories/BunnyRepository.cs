using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Easter.Models.Bunnies.Contracts;
using Easter.Repositories.Contracts;

namespace Easter.Repositories
{
    public class BunnyRepository : IRepository<IBunny>
    {
        private List<IBunny> models;

        public BunnyRepository()
        {
            models = new List<IBunny>();
        }
        public IReadOnlyCollection<IBunny> Models { get => this.models; }
        public void Add(IBunny model)
        {
            this.models.Add(model);
        }

        public bool Remove(IBunny model)
        {

            if (models.Contains(model))
            {
                this.models.Remove(model);
                return true;
            }

            return false;
        }

        public IBunny FindByName(string name)
        {
            IBunny bunny = this.models.FirstOrDefault(b => b.Name == name);
            if (bunny != null)
            {
                return this.models.FirstOrDefault(b => b.Name == name);
            }

            return null;
        }
    }
}
