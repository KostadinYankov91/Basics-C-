using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cooking
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> liquids = new Queue<int>();
            Stack<int> ingredients = new Stack<int>();

            string[] inputLiquids = Console.ReadLine().Split();
            string[] inputIngredients = Console.ReadLine().Split();

            for (int i = 0; i < inputLiquids.Length; i++)
            {
                liquids.Enqueue(int.Parse(inputLiquids[i]));
                ingredients.Push(int.Parse(inputIngredients[i]));
            }

            int currLiquid = 0;
            int currIngredient = 0;
            int sum = 0;
            int bread = 25;
            int cake = 50;
            int pastry = 75;
            int fruitPie = 100;
            int breadCooked = 0;
            int cakeCooked = 0;
            int pastryCooked = 0;
            int fruitPieCooked = 0;

            while (liquids.Count > 0 && ingredients.Count > 0)
            {
                currLiquid = liquids.Peek();
                currIngredient = ingredients.Peek();
                sum = currLiquid + currIngredient;

                if (sum == bread)
                {
                    liquids.Dequeue();
                    ingredients.Pop();
                    breadCooked++;
                    continue;
                }

                if (sum == cake)
                {
                    liquids.Dequeue();
                    ingredients.Pop();
                    cakeCooked++;
                    continue;
                }

                if (sum == pastry)
                {
                    liquids.Dequeue();
                    ingredients.Pop();
                    pastryCooked++;
                    continue;
                }

                if (sum == fruitPie)
                {
                    liquids.Dequeue();
                    ingredients.Pop();
                    fruitPieCooked++;
                    continue;
                }

                liquids.Dequeue();
                currIngredient += 3;
                ingredients.Pop();
                ingredients.Push(currIngredient);
            }

            string result = AllCookedOrLeftUncooked(liquids, ingredients);
            Console.WriteLine(result);
            string resultWhatIsLeft = WhatIsLeft(liquids, ingredients);
            Console.WriteLine(resultWhatIsLeft);

            SortedDictionary<string, int> cookedThings = new SortedDictionary<string, int>();

            cookedThings.Add("Bread", breadCooked);
            cookedThings.Add("Cake", cakeCooked);
            cookedThings.Add("Pastry", pastryCooked);
            cookedThings.Add("Fruit Pie", fruitPieCooked);

            foreach (KeyValuePair<string, int> cookedFood in cookedThings)
            {
                Console.WriteLine($"{cookedFood.Key}: {cookedFood.Value}");
            }
        }

        public static string AllCookedOrLeftUncooked(Queue<int> liquids, Stack<int> ingredients)
        {
            if (liquids.Count == 0 && ingredients.Count == 0)
            {
                return "Wohoo! You succeeded in cooking all the food!";
            }

            return "Ugh, what a pity! You didn't have enough materials to cook everything.";
        }

        public static string WhatIsLeft(Queue<int> liquids, Stack<int> ingredients)
        {
            StringBuilder sb = new StringBuilder();

            if (liquids.Count > 0)
            {
                sb.AppendLine($"Liquids left: {string.Join(", ", liquids)}");
            }
            else
            {
                sb.AppendLine("Liquids left: none");
            }
            if (ingredients.Count > 0)
            {
                sb.Append($"Ingredients left: {string.Join(", ", ingredients)}");
            }
            else
            {
                sb.Append("Ingredients left: none");
            }

            return sb.ToString();
        }

    }
}
