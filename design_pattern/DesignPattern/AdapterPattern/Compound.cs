using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AdapterPattern
{
    /// <summary>
    /// The 'Target' class
    /// </summary>
    public class Compound : IDisposable
    {
        protected float boilingPoint;
        protected float meltingPoint;
        protected double molecularWeight;
        protected string molecularFormula;
        public virtual void Display()
        {
            Console.WriteLine("\nCompound: Unknown ------ ");
        }

        public void Dispose()
        {
            Console.WriteLine("Disposed Worked");
        }
    }
}
