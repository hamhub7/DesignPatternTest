using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest.Behavioral.Strategy
{
    public interface IAttack
    {
        void Execute(IPersonaUser user);
    }

    public class MeleeAttack : IAttack
    {
        public void Execute(IPersonaUser user)
        {
            Random random = new();
            if (random.NextDouble() < user.MeleeAccuracy)
            {
                Console.WriteLine($"{user} deals {user.MeleeDamage} damage to the enemy");
            }
            else
            {
                Console.WriteLine($"{user} misses!");
            }
        }
    }

    public class GunAttack : IAttack
    {
        public void Execute(IPersonaUser user)
        {
            if (!user.HasAmmo())
            {
                Console.WriteLine($"{user} has no ammo! Attack failed");
            }
            else
            {
                user.UseAmmo();
                Random random = new();
                if (random.NextDouble() < user.GunAccuracy)
                {
                    Console.WriteLine($"{user} uses 1 ammo and deals {user.GunDamage} damage to the enemy");
                }
                else
                {
                    Console.WriteLine($"{user} uses 1 ammo, but misses!");
                }
            }
        }
    }

    public class PersonaAttack : IAttack
    {
        readonly ISkill skill;

        public PersonaAttack(ISkill skill)
        {
            this.skill = skill;
        }

        public void Execute(IPersonaUser user)
        {
            Console.WriteLine($"{user} calls upon {user.PersonaName} to perform {skill.Name}! It deals {skill.Damage} {skill.Element} damage!");
        }
    }

    public enum DamageElement
    {
        Phys,
        Gun,
        Fire,
        Ice,
        Elec,
        Wind,
        Psy,
        Nuke,
        Bless,
        Curse,
        Almighty
    }

    public interface ISkill
    {
        public string Name { get; }
        public int Damage { get; }
        public DamageElement Element { get; }
    }

    public class Eiha : ISkill
    {
        public string Name => "Eiha";

        public int Damage => 50;

        public DamageElement Element => DamageElement.Curse;
    }

    public class Cleave : ISkill
    {
        public string Name => "Cleave";

        public int Damage => 65;

        public DamageElement Element => DamageElement.Phys;
    }

    public interface IPersonaUser
    {
        public int MeleeDamage { get; }
        public double MeleeAccuracy { get; }
        public bool HasAmmo();
        public void UseAmmo();
        public int GunDamage { get; }
        public double GunAccuracy { get; }

        public string PersonaName { get; }

        public void Attack(IAttack attack)
        {
            attack.Execute(this);
        }
    }

    public class Joker : IPersonaUser
    {
        readonly string name = "Joker";

        public string PersonaName => "Arsene";

        public int MeleeDamage => 38;

        public double MeleeAccuracy => 0.96;

        private int ammo = 8;

        public bool HasAmmo()
        {
            return ammo > 0;
        }

        public void UseAmmo()
        {
            if (ammo <= 0) throw new InvalidOperationException();
            ammo--;
        }

        public int GunDamage => 50;

        public double GunAccuracy => 0.92;

        public override string ToString()
        {
            return name;
        }
    }
}
