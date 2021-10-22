using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Telephony.Models
{
    public interface ICallable
    {
        static string Call(string number)
        {
            if (number.Length == 10)
            {
                return $"Calling... {number}";
            }

            return $"Dialing... {number}";
        }
    }
}
