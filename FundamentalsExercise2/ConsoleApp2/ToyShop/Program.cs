using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripcost = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            double puzzleC = 2.60;
            int dolls = int.Parse(Console.ReadLine());
            int dollC = 3;
            int teddys = int.Parse(Console.ReadLine());
            double teddyC = 4.10;
            int minions = int.Parse(Console.ReadLine());
            double minionC = 8.20;
            int trucks = int.Parse(Console.ReadLine());
            int truckC = 2;

            double totalC = puzzles * puzzleC + dolls * dollC + teddys + teddyC + minions * minionC + trucks + truckC;
            double totalam = puzzles + dolls + teddys + minions + trucks;
            double discountC = totalC - totalC * 0.25;
            double nettotalMoney = totalC * totalam - (totalC * totalam * 0.10);
            double netdiscountC = discountC - discountC * 0.10;
            double netdiscountMoney = netdiscountC - tripcost;

            if (totalam > 50)
            {
                
                Console.WriteLine("Yes! " + (netdiscountMoney) + " lv left.");

            }

           
            
           
        }
    }
}
