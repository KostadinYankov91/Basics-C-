﻿using System;

namespace rageExpences
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double money = headsetPrice * (lostGames / 2);
            money += mousePrice * (lostGames / 3);
            money += keyboardPrice * (lostGames / 6);
            money += displayPrice * (lostGames / 12);

            Console.WriteLine($"Rage expenses: {money:F2} lv.");
        }
    }
}
