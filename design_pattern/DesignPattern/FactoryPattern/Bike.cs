using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryPattern
{
    //Concrete Class
    public class Bike : IVehicle
    {
        private readonly int Wheels;
        public Bike()
        {
            this.Wheels = 2;
        }

        public int NumberOfWheels()
        {
            return this.Wheels;
        }

        public string VehicleType()
        {
            return "Bike Class";
        }
    }
}
