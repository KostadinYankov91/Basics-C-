using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony.Models
{
    public interface IBrowable
    {
        string Browsing(string site)
        {
            return $"Browsing: {site}!";
        }
    }
}
