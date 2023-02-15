using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest.Structural.Flyweight
{
    public interface INecron
    {
        string GetDetails();
    }

    public enum NecronType
    {
        NecronWarrior,
        SkorpekhDestroyer,
        TombBlade,
    }

    public class NecronWarrior : INecron
    {
        public string GetDetails() => "Necron Warrior, hash code " + GetHashCode(); 
    }

    public class SkorpekhDestroyer : INecron
    {
        public string GetDetails() => "Skorpekh Destroyer, hash code " + GetHashCode();
    }

    public class TombBlade : INecron
    {
        public string GetDetails() => "Tomb Blade, hash code " + GetHashCode();
    }

    public class TombWorld
    {
        private readonly Dictionary<NecronType, INecron> necrons = new();

        public INecron AwakenNecron(NecronType type)
        {
            bool necronExists = necrons.TryGetValue(type, out INecron? necron);
            if(!necronExists || necron is null)
            {
                switch (type)
                {
                    case NecronType.NecronWarrior:
                        necron = new NecronWarrior();
                        necrons.Add(type, necron);
                        break;
                    case NecronType.SkorpekhDestroyer:
                        necron = new SkorpekhDestroyer();
                        necrons.Add(type, necron);
                        break;
                    case NecronType.TombBlade:
                        necron = new TombBlade();
                        necrons.Add(type, necron);
                        break;
                    default: throw new ArgumentException("Type not supported", nameof(type));
                }
            }
            return necron;
        }
    }
}
