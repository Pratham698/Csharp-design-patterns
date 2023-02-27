using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryPattern
{
    public class Dog : IAnimal
    {
        public string speak()
        {
            return "Bark bark";
        }
    }
}
