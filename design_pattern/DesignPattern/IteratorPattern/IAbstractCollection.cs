using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.IteratorPattern
{
    //Creating Aggregate- Iterator Object Interface
    interface IAbstractCollection
    {
        Iterator CreateIterator();
    }
}
