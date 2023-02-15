using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest.Structural.Decorator
{
    public interface IIronManArmor
    {
        string GetDetails();
        int GetSpeed();
        int GetAttackPower();
    }

    public class MarkXLII : IIronManArmor
    {
        public string GetDetails()
        {
            StringBuilder sb = new();
            sb.AppendLine("Mark XLII (42)");
            sb.AppendLine("Features:");
            sb.AppendLine("Flight");
            sb.AppendLine("Heads Up Display");
            sb.AppendLine("Life-Support System");
            sb.AppendLine("Armor Summoning");
            sb.AppendLine("Collapsible Plating");
            sb.AppendLine("Repulsors");
            sb.AppendLine("Unibeam");
            sb.AppendLine("Lasers");
            sb.AppendLine("Missiles");
            return sb.ToString();
        }

        public int GetSpeed() => 5;

        public int GetAttackPower() => 10;
    }

    public class MarkL : IIronManArmor
    {
        public string GetDetails()
        {
            StringBuilder sb = new();
            sb.AppendLine("Mark L (50)");
            sb.AppendLine("Features:");
            sb.AppendLine("Flight");
            sb.AppendLine("Heads Up Display");
            sb.AppendLine("Life-Support System");
            sb.AppendLine("Repulsors");
            sb.AppendLine("Unibeam");
            sb.AppendLine("Lasers");
            sb.AppendLine("Missiles");
            sb.AppendLine("Nanite Manipulation");
            return sb.ToString();
        }

        public int GetSpeed() => 10;

        public int GetAttackPower() => 20;
    }

    public abstract class ArmorUpgrades : IIronManArmor
    {
        private readonly IIronManArmor _armor;

        protected ArmorUpgrades(IIronManArmor armor)
        {
            _armor = armor;
        }

        public virtual string GetDetails() => _armor.GetDetails();

        public virtual int GetSpeed() => _armor.GetSpeed();

        public virtual int GetAttackPower() => _armor.GetAttackPower();
    }

    public class ThrusterUpgrades : ArmorUpgrades
    {
        public ThrusterUpgrades(IIronManArmor armor) : base(armor) { }

        public override string GetDetails() => base.GetDetails() + "Upgraded Thruster\n";

        public override int GetSpeed() => base.GetSpeed() + 1;
    }

    public class WeaponUpgrades : ArmorUpgrades
    {
        public WeaponUpgrades(IIronManArmor armor) : base(armor) { }

        public override string GetDetails() => base.GetDetails() + "Upgraded Weapons\n";

        public override int GetAttackPower() => base.GetAttackPower() + 5;
    }
}
