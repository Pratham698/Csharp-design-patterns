using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StrategyPattern
{
    //Concrete Strategy
    public class CarStrategy : IStrategy
    {
        public string GetTravelTime(string source, string destination)
        {
            return "Car Time take: 30 min";
        }
    }
}
