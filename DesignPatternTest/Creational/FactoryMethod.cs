using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest.Creational.FactoryMethod
{
    public enum MobType
    {
        Zombie,
        Skeleton,
        Spider,
        Creeper,
        Pig,
        Cow,
        Chicken
    }

    public interface IMob
    {
        public MobType GetMobType();
    }

    public class Zombie : IMob
    {
        public MobType GetMobType()
        {
            return MobType.Zombie;
        }
    }

    public class Creeper : IMob
    {
        public MobType GetMobType()
        {
            return MobType.Creeper;
        }
    }

    public interface IMobSpawner
    {
        IMob SpawnMob();
    }

    public class ZombieSpawner : IMobSpawner
    {
        public IMob SpawnMob()
        {
            return new Zombie();
        }
    }

    public class CreeperSpawner : IMobSpawner
    {
        public IMob SpawnMob()
        {
            return new Creeper();
        }
    }
}
