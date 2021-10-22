using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public interface IPerson : IIdentifiable, ICelebratable, IAge, IBuyer
    {
       
    }
}
