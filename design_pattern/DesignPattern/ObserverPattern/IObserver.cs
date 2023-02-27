﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.ObserverPattern
{
    //Creating Observer Interface
    public interface IObserver
    {
        void update(string availability);
    }
}
