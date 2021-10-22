using System;
using System.Collections.Generic;
using System.Linq;

namespace keyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int barrelSize = int.Parse(Console.ReadLine());

            int[] bulletsInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> bullets = new Stack<int>(bulletsInput);

            int[] locksInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> locks = new Queue<int>(locksInput);

            int intelligence = int.Parse(Console.ReadLine());
            int bulletsCount = 0;
            int currbarrelSize = barrelSize;

            while (bullets.Any() && locks.Any())
            {
                
                bulletsCount++;
                currbarrelSize--;
                int currentBullet = bullets.Pop();
                int currentLock = locks.Peek();


                if (currentBullet <= currentLock)
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                
                if (currbarrelSize == 0 && bullets.Any())
                {
                    currbarrelSize = barrelSize;
                    Console.WriteLine("Reloading!");
                }
                
            }

            if (!locks.Any())
            {
                int moneyEarned = intelligence - (bulletsCount * bulletPrice);
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarned}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }

            Console.WriteLine();

        }
    }
}
