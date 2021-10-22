using System;
using System.Collections.Generic;
using System.Linq;

namespace CAdvancedExam
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> firstBox = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

            Stack<int> secondBox = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

            int currFirstBoxValue = 0;
            int currSecondBoxValue = 0;
            List<int> claimedItems = new List<int>();
            int sum = 0;

            while (firstBox.Count > 0 && secondBox.Count > 0)
            {
                currFirstBoxValue = firstBox.Peek();
                currSecondBoxValue = secondBox.Peek();
                sum = currFirstBoxValue + currSecondBoxValue;

                if (sum % 2 == 0)
                {
                    claimedItems.Add(sum);
                    firstBox.Dequeue();
                    secondBox.Pop();
                }
                else
                {
                    currSecondBoxValue = secondBox.Pop();
                    firstBox.Enqueue(currSecondBoxValue);
                }
            }

            sum = 0;

            if (firstBox.Count == 0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            else if (secondBox.Count == 0)
            {
                Console.WriteLine("Second lootbox is empty");
            }

            foreach (var item in claimedItems)
            {
                sum += item;
            }

            if (sum >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {sum}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {sum}");
            }

        }
    }
}
