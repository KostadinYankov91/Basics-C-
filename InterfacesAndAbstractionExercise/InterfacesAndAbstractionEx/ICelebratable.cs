using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public interface ICelebratable
    {
        string Name { get; }
        string Birthdate { get; }
    }
}
