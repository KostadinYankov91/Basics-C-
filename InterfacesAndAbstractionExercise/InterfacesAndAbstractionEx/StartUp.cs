using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PersonInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            List<Citizen> citizens = new List<Citizen>();
            List<Rebel> rebels = new List<Rebel>();
            List<string> names = new List<string>();
            int n = int.Parse(Console.ReadLine());

            string input;
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                string[] arguments = input.Split();

                if (arguments.Length < 4)
                {
                    string name = arguments[0];
                    string age = arguments[1];
                    string group = arguments[2];
                    Rebel rebel = new Rebel(name, age, group);
                    rebels.Add(rebel);
                }
                else
                {
                    string name = arguments[0];
                    string age = arguments[1];
                    string id = arguments[2];
                    string birthDate = arguments[3];
                    Citizen citizen = new Citizen(name, age, id, birthDate);
                    citizens.Add(citizen);
                }

                if (i == n)
                {
                    break;
                }

            }
            
            string pattern = @"\s+";
            while ((input = Console.ReadLine()) != "End")
            {
                string currInput = Regex.Replace(input, pattern, "");
                names.Add(currInput);
            }

            foreach (string item in names)
            {
                foreach (Citizen citizen in citizens)
                {
                    if (item == citizen.Name)
                    {
                        citizen.BuyFood();
                    }
                }
                foreach (Rebel rebel in rebels)
                {
                    if (item == rebel.Name)
                    {
                        rebel.BuyFood();
                    }
                }
            }

            int citizensFood = 0;
            foreach (Citizen item in citizens)
            {
                citizensFood += item.Food;
            }
            int rebelsFood = 0;
            foreach (Rebel rebel in rebels)
            {
                rebelsFood += rebel.Food;
            }


            Console.WriteLine($"{citizensFood + rebelsFood}");

        }
    }
}
