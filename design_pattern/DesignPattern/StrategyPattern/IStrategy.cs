﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StrategyPattern
{
    public interface IStrategy
    {
        string GetTravelTime(string source, string destination);
    }
}
