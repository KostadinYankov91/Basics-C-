﻿using System;

namespace nestedCycles
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int h = 0; h <= 23; h++)
            {
                for (int m = 0; m <= 59; m++)
                {
                    Console.WriteLine($"{h:d2}:{m:d2}");
                }
            }
        }
    }
}
