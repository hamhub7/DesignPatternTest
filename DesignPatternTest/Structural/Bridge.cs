using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest.Structural.Bridge
{
    public interface IBoon
    {
        string God { get; }
        string Inflicts { get; }
    }

    public class AproditeBoon : IBoon
    {
        public string God => "Aphrodite";
        public string Inflicts => "Weak/Charmed";
    }

    public class AresBoon : IBoon
    {
        public string God => "Ares";
        public string Inflicts => "Doom";
    }

    public class ArtemisBoon : IBoon
    {
        public string God => "Artemis";
        public string Inflicts => "Critical";
    }

    public class AthenaBoon : IBoon
    {
        public string God => "Athena";
        public string Inflicts => "Deflect";
    }

    public class ChaosBoon : IBoon
    {
        public string God => "Athena";
        public string Inflicts => "A Random Effect";
    }

    public class DemeterBoon : IBoon
    {
        public string God => "Demeter";
        public string Inflicts => "Chill";
    }

    public class DionysusBoon : IBoon
    {
        public string God => "Dionysus";
        public string Inflicts => "Hangover";
    }

    public class PoseidonBoon : IBoon
    {
        public string God => "Poseidon";
        public string Inflicts => "Knockback";
    }

    public class ZeusBoon : IBoon
    {
        public string God => "Zeus";
        public string Inflicts => "Chain Lightning";
    }

    public interface IInfernalWeapon
    {
        string Name { get; }
        IBoon Boon { get; }
        void Attack();
        void Special();
    }

    public class StygianBlade : IInfernalWeapon
    {
        public string Name => "Stygius";

        public IBoon Boon { get; }

        public StygianBlade(IBoon boon)
        {
            Boon = boon;
        }

        public void Attack()
        {
            Console.WriteLine($"Zagreus Strikes his enemy with {Name}, inflicting {Boon.Inflicts}!");
        }

        public void Special()
        {
            Console.WriteLine($"Zagreus Nova Smashes his enemies with {Name}, inflicting {Boon.Inflicts}!");
        }
    }

    public class EternalSpear : IInfernalWeapon
    {
        public string Name => "Varatha";

        public IBoon Boon { get; }

        public EternalSpear(IBoon boon)
        {
            Boon = boon;
        }

        public void Attack()
        {
            Console.WriteLine($"Zagreus Strikes his enemy with {Name}, inflicting {Boon.Inflicts}!");
        }

        public void Special()
        {
            Console.WriteLine($"Zagreus Throws {Name} at his enemies, inflicting {Boon.Inflicts}!");
        }
    }

    public class ShieldOfChaos : IInfernalWeapon
    {
        public string Name => "Aegis";

        public IBoon Boon { get; }

        public ShieldOfChaos(IBoon boon)
        {
            Boon = boon;
        }

        public void Attack()
        {
            Console.WriteLine($"Zagreus Bashes his enemy with {Name}, inflicting {Boon.Inflicts}!");
        }

        public void Special()
        {
            Console.WriteLine($"Zagreus Throws {Name} at his enemies, inflicting {Boon.Inflicts}!");
        }
    }

    public class HeartSeekingBow : IInfernalWeapon
    {
        public string Name => "Coronacht";

        public IBoon Boon { get; }

        public HeartSeekingBow(IBoon boon)
        {
            Boon = boon;
        }

        public void Attack()
        {
            Console.WriteLine($"Zagreus Fires at his enemy with {Name}, inflicting {Boon.Inflicts}!");
        }

        public void Special()
        {
            Console.WriteLine($"Zagreus Volley Fires at his enemies with {Name}, inflicting {Boon.Inflicts}!");
        }
    }

    public class TwinFistsOfMalphon : IInfernalWeapon
    {
        public string Name => "Malphon";

        public IBoon Boon { get; }

        public TwinFistsOfMalphon(IBoon boon)
        {
            Boon = boon;
        }

        public void Attack()
        {
            Console.WriteLine($"Zagreus Pummels his enemy with {Name}, inflicting {Boon.Inflicts}!");
        }

        public void Special()
        {
            Console.WriteLine($"Zagreus executes out a Rising Cutter with {Name}, inflicting {Boon.Inflicts}!");
        }
    }

    public class AdamantRail : IInfernalWeapon
    {
        public string Name => "Exagryph";

        public IBoon Boon { get; }

        public AdamantRail(IBoon boon)
        {
            Boon = boon;
        }

        public void Attack()
        {
            Console.WriteLine($"Zagreus Fires at his enemies with {Name}, inflicting {Boon.Inflicts}!");
        }

        public void Special()
        {
            Console.WriteLine($"Zagreus Bombards his enemies with {Name}, inflicting {Boon.Inflicts}!");
        }
    }
}
