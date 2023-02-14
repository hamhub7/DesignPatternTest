using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest.Creational.Prototype
{
    public interface IPrototype
    {
        IPrototype Clone();
    }

    public class CloneHost : IPrototype
    {
        public float height; // meters
        public float weight; // kilos
        public string species;

        public CloneHost(float height, float weight, string species)
        {
            this.height = height;
            this.weight = weight;
            this.species = species;
        }

        public IPrototype Clone()
        {
            return (IPrototype)MemberwiseClone();
        }
    }
}
