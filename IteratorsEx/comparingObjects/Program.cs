using System;
using System.Collections.Generic;

namespace comparingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonOne> people = new List<PersonOne>();
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                PersonOne person = new PersonOne(input.Split());
                people.Add(person);
            }

            int index = int.Parse(Console.ReadLine());
            int matches = 0;
            int nonEqual = 0;

            foreach (PersonOne person in people)
            {

                if (index <= people.Count - 1)
                {
                    if (people[index].CompareTo(person) == 0)
                    {
                        matches++;
                        continue;
                    }
                    else
                    {
                        nonEqual++;
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("No matches");
                    break;
                }
            }

            if (index <= people.Count - 1)
            {
                Console.WriteLine($"{matches} {nonEqual} {people.Count}");
            }
        }
    }
}
