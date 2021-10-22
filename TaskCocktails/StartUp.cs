namespace CocktailParty
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            Ingredient vodka = new Ingredient("Vodka", 2, 5);
            Ingredient milk = new Ingredient("Milk", 0, 3);

            Cocktail cocktail = new Cocktail("Pina Colada", 10, 5);

            cocktail.Add(vodka);
            cocktail.Add(milk);

            cocktail.FindIngredient("Milk");

            Console.WriteLine(cocktail.Report());
            

        }
    }
}
 