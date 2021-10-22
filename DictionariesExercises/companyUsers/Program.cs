using System;
using System.Collections.Generic;
using System.Linq;

namespace companyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> details = new Dictionary<string, List<string>>();
            string company;
            string ID;

            while (input != "End")
            {
                string[] arguments = input.Split(" -> ");
                company = arguments[0];
                ID = arguments[1];

                if (!details.ContainsKey(company))
                {
                    details.Add(company, null);
                }
                if (!details.ContainsKey(ID))
                {
                    List<string> idS = new List<string>();
                    idS.Add(ID);
                    details.Add(company, idS);
                }
            }

            details.OrderBy(x => x.Key);

            foreach (var item in details)
            {
                Console.WriteLine($"{item.Key}");
                
            }
        }
    }
}
