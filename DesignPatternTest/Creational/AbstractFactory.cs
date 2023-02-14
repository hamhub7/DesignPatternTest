namespace DesignPatternTest.Creational.AbstractFactory
{
    public interface ISwordEnemy
    {
        string GetDescription();
    }

    public interface IAxeEnemy
    {
        string GetDescription();
    }

    public interface IBowEnemy
    {
        string GetDescription();
    }

    public class SwordStalfos : ISwordEnemy
    {
        public string GetDescription()
        {
            return "Stalfos with a sword";
        }
    }

    public class AxeStalfos : IAxeEnemy
    {
        public string GetDescription()
        {
            return "Stalfos with an axe";
        }
    }

    public class BowStalfos : IBowEnemy
    {
        public string GetDescription()
        {
            return "Stalfos with a bow";
        }
    }

    public class SwordBokoblin : ISwordEnemy
    {
        public string GetDescription()
        {
            return "Bokoblin with a sword";
        }
    }

    public class AxeBokoblin : IAxeEnemy
    {
        public string GetDescription()
        {
            return "Bokoblin with an axe";
        }
    }

    public class BowBokoblin : IBowEnemy
    {
        public string GetDescription()
        {
            return "Bokoblin with a bow";
        }
    }

    public interface IEnemyFactory
    {
        ISwordEnemy CreateSwordEnemy();
        IAxeEnemy CreateAxeEnemy();
        IBowEnemy CreateBowEnemy();
    }

    public class StalfosEnemyFactory : IEnemyFactory
    {
        public ISwordEnemy CreateSwordEnemy()
        {
            return new SwordStalfos();
        }

        public IAxeEnemy CreateAxeEnemy()
        {
            return new AxeStalfos();
        }

        public IBowEnemy CreateBowEnemy()
        {
            return new BowStalfos();
        }
    }

    public class BokoblinEnemyFactory : IEnemyFactory
    {
        public ISwordEnemy CreateSwordEnemy()
        {
            return new SwordBokoblin();
        }

        public IAxeEnemy CreateAxeEnemy()
        {
            return new AxeBokoblin();
        }

        public IBowEnemy CreateBowEnemy()
        {
            return new BowBokoblin();
        }
    }

    public static class EnemyFactoryMaker
    {
        public enum EnemyType
        {
            Stalfos,
            Bokoblin,
        }

        public static IEnemyFactory MakeFactory(EnemyType type)
        {
            return type switch
            {
                EnemyType.Stalfos => new StalfosEnemyFactory(),
                EnemyType.Bokoblin => new BokoblinEnemyFactory(),
                _ => throw new NotImplementedException("EnemyType not supported"),
            };
        }
    }
}
