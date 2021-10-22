using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CocktailParty
{
    public class Cocktail
    {
        private List<Ingredient> ingredients;
        private int currentAlcoholLevel;
        private int currentQuantity;

        public Cocktail(string name, int capacity, int maxAlcoholLevel)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.MaxAlcoholLevel = maxAlcoholLevel;
            ingredients = new List<Ingredient>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int MaxAlcoholLevel { get; set; }

        public int CurrentAlcoholLevel
        {
            get
            {
                foreach (Ingredient ingredient in ingredients)
                {
                    currentAlcoholLevel += ingredient.Alcohol;
                }

                return this.currentAlcoholLevel;
            }
        }

        public void Add(Ingredient ingredient)
        {

            if (!ingredients.Contains(ingredient) &&
                ingredient.Alcohol < this.MaxAlcoholLevel &&
                ingredient.Quantity <= this.Capacity &&
                ingredient.Quantity + currentQuantity <= this.Capacity)
            {
                ingredients.Add(ingredient);
                currentQuantity += ingredient.Quantity;
            }
        }
        public bool Remove(string name)
        {
            if (ingredients.Any(i => i.Name == name))
            {
                ingredients.Remove(ingredients.Find(i => i.Name == name));
                return true;
            }

            return false;
        }

        public Ingredient FindIngredient(string name)
        {
            if (ingredients.Any(i => i.Name == name))
            {
                return ingredients.FirstOrDefault(i => i.Name == name);
            }

            return null;
        }

        public Ingredient GetMostAlcoholicIngredient()
        {
            
            int mostAlcohol = 0;
            foreach (Ingredient ingredient in ingredients)
            {
                if (ingredient.Alcohol > mostAlcohol)
                {
                    mostAlcohol = ingredient.Alcohol;
                }
            }

            return ingredients.Find(i => i.Alcohol == mostAlcohol);
        }

        public string Report()
        {
            return $"Cocktail: {Name} - Current Alcohol Level: {CurrentAlcoholLevel}\r\n" +
                   $"{string.Join(Environment.NewLine, ingredients)}";
        }
    }
}
