using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest.Structural.Proxy
{
    public interface ISpiceDeposit
    {
        void Enter(SpiceHarvester harvester);
        void Exit(SpiceHarvester harvester);
    }

    public class SandDune : ISpiceDeposit
    {
        public void Enter(SpiceHarvester harvester)
        {
            Console.WriteLine($"Spice Harvester ID #{harvester.ID:000} is now mining spice");
        }

        public void Exit(SpiceHarvester harvester)
        {
            Console.WriteLine($"Spice Harvester ID #{harvester.ID:000} has left the dune");
        }
    }

    public class SpiceHarvester
    {
        public int ID { get; }

        public SpiceHarvester(int id)
        {
            ID = id;
        }
    }

    public class ProxySandDune : ISpiceDeposit
    {
        private const int NUM_HARVESTERS_ALLOWED = 3;

        private readonly List<SpiceHarvester> harvesters = new();

        private readonly SandDune dune;

        public ProxySandDune(SandDune dune)
        {
            this.dune = dune;
        }

        public void Enter(SpiceHarvester harvester)
        {
            if (harvesters.Where(sh => sh.ID == harvester.ID).Any())
            {
                Console.WriteLine("Harvester with same ID already on this dune");
            }
            else if (harvesters.Count >= NUM_HARVESTERS_ALLOWED)
            {
                Console.WriteLine("Too many harvesters on this dune");
            }
            else
            {
                dune.Enter(harvester);
                harvesters.Add(harvester);
            }
        }

        public void Exit(SpiceHarvester harvester)
        {
            if (!harvesters.Where(sh => sh.ID == harvester.ID).Any())
            {
                Console.WriteLine("Harvester is not on this dune");
            }
            else
            {
                harvesters.RemoveAll(sh => sh.ID == harvester.ID);
            }
        }
    }
}
