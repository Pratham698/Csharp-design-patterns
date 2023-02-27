using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryPattern
{
    //Concrete Factory Class
    public class SeaAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(string AnimalType)
        {
            if (AnimalType.Equals("Octopus"))
                return new Octopus();
            else if (AnimalType.Equals("Shark"))
                return new Shark();
            else
                return null;
        }
    }
}
