﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public interface IPrivate : ISoldier
    {
        decimal Salary { get; }
    }
}
