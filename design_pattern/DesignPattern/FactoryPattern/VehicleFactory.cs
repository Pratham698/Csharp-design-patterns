using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryPattern
{
    //Factory Class to generate objects according to given information
    public class VehicleFactory
    {
        public static IVehicle GetVehicle(string Type)
        {
            IVehicle objectType = null;
            if (Type.ToLower().Equals("bike"))
            {
                objectType = new Bike();
            }
            return objectType;
        }
    }
}
