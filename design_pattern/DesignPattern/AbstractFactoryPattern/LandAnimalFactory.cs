using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryPattern
{
    //Concrete Factory Class
    public class LandAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(string AnimalType)
        {
            if (AnimalType.Equals("Dog"))
                return new Dog();
            else if (AnimalType.Equals("Cat"))
                return new Cat();
            else if (AnimalType.Equals("Lion"))
                return new Lion();
            else
                return null;
        }
    }
}
