using System;
using System.Collections.Generic;

namespace aMinersTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> output = new Dictionary<string, int>();

            string resources;

            while ((resources = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!output.ContainsKey(resources))
                {
                    output.Add(resources, 0);
                }

                output[resources] += quantity;
            }

            foreach (var item in output)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
