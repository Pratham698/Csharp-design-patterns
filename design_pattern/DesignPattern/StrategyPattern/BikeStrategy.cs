using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StrategyPattern
{
    public class BikeStrategy : IStrategy
    {
        public string GetTravelTime(string source, string destination)
        {
            return "Bike Time take: 60 min";
        }
    }
}
