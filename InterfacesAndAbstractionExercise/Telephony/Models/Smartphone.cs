using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Telephony.Models;
using System.Linq;

namespace Telephony.models
{
    public class Smartphone : ICallable, IBrowsable
    {
        private List<string> numbers;
        public Smartphone(string input)
        {
            Numbers = input;
        }
        public string Numbers
        {
            get => string.Join(" ", this.numbers);
            private set
            {
                string pattern = @"\d{10}";
                Regex regex = new Regex(pattern);
                MatchCollection numberMatches = regex.Matches(value);

                foreach (var item in numberMatches)
                {
                    numbers.Add(item.ToString());
                }

            }
        }
    }

    internal interface IBrowsable
    {
    }
}
