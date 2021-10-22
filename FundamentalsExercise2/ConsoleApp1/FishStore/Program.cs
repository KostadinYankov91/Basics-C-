using System;

namespace FishStore
{
    class Program
    {
        static void Main(string[] args)
        {

            // input cost of Skumria i Caca and kg of others
            double costSk = double.Parse(Console.ReadLine());
            double costCa = double.Parse(Console.ReadLine());
            double allPalKg = double.Parse(Console.ReadLine());
            double allSafKg = double.Parse(Console.ReadLine());
            double allMiKg = double.Parse(Console.ReadLine());
            
            //calclutaions
            double costPal = costSk + costSk * 0.6;
            double costSaf = costCa + costCa * 0.8;
            double costMi = 7.5;

            double palMoney = allPalKg * costPal;
            double safMoney = allSafKg * costSaf;
            double miMoney = allMiKg * costMi;

            double moneyToPay = palMoney + safMoney + miMoney;

            //Money needed output 
            Console.WriteLine(moneyToPay.ToString("0.00"));
           
        }
    }
}
