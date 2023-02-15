using DesignPatternTest.Creational.AbstractFactory;
using DesignPatternTest.Creational.Builder;
using DesignPatternTest.Creational.FactoryMethod;
using DesignPatternTest.Creational.Prototype;
using DesignPatternTest.Creational.Singleton;
using DesignPatternTest.Structural.Decorator;
using DesignPatternTest.Structural.Facade;
using DesignPatternTest.Structural.Flyweight;
using DesignPatternTest.Structural.Proxy;

Console.WriteLine("Singleton:");
TheWarp.Instance.DrawPower(10);
TheWarp.Instance.DrawPower(15);
TheWarp.Instance.DrawPower(20);
Console.WriteLine();


Console.WriteLine("Abstract Factory:");
IEnemyFactory enemyFactory = EnemyFactoryMaker.MakeFactory(EnemyFactoryMaker.EnemyType.Bokoblin);
Console.WriteLine(enemyFactory.CreateSwordEnemy().GetDescription());
Console.WriteLine(enemyFactory.CreateAxeEnemy().GetDescription());
Console.WriteLine(enemyFactory.CreateBowEnemy().GetDescription());
enemyFactory = EnemyFactoryMaker.MakeFactory(EnemyFactoryMaker.EnemyType.Stalfos);
Console.WriteLine(enemyFactory.CreateSwordEnemy().GetDescription());
Console.WriteLine(enemyFactory.CreateAxeEnemy().GetDescription());
Console.WriteLine(enemyFactory.CreateBowEnemy().GetDescription());
Console.WriteLine();


Console.WriteLine("Builder:");
Vehicle vehicle = new Vehicle.Builder().WithFrame(VehicleFrame.WildWiggler).WithWheels(VehicleWheels.Roller).WithGlider(VehicleGlider.CloudGlider).Build();
Console.WriteLine("Frame: " + vehicle.frame);
Console.WriteLine("Wheels: " + vehicle.wheels);
Console.WriteLine("Glider: " + vehicle.glider);
Console.WriteLine();


Console.WriteLine("Factory Method:");
IMobSpawner mobSpawner = new ZombieSpawner();
IMob mob = mobSpawner.SpawnMob();
Console.WriteLine("Spawned " + mob.GetMobType());
mobSpawner = new CreeperSpawner();
mob = mobSpawner.SpawnMob();
Console.WriteLine("Spawned " + mob.GetMobType());
Console.WriteLine();


Console.WriteLine("Prototype:");
IPrototype jangoFett = new CloneHost(1.83f, 79, "Human");
CloneHost clone = (CloneHost)jangoFett.Clone();
Console.WriteLine("Height: " + clone.height + "m");
Console.WriteLine("Weight: " + clone.weight + "kg");
Console.WriteLine("Species: " + clone.species);
Console.WriteLine();


Console.WriteLine("Adapter:");
Console.WriteLine();


Console.WriteLine("Bridge:");
Console.WriteLine();


Console.WriteLine("Composite:");
Console.WriteLine();


Console.WriteLine("Decorator:");
IIronManArmor armor = new MarkL();
armor = new ThrusterUpgrades(armor);
Console.Write(armor.GetDetails());
Console.WriteLine("Speed: " + armor.GetSpeed());
Console.WriteLine("Attack Power: " + armor.GetAttackPower());
Console.WriteLine();

Console.WriteLine("Facade:");
FrostpunkFacade frostpunkFacade = new();
frostpunkFacade.Dawn();
frostpunkFacade.WorkDay();
frostpunkFacade.Dusk();
Console.WriteLine();

Console.WriteLine("Flyweight:");
TombWorld tombWorld = new();
List<INecron> army = new();
army.Add(tombWorld.AwakenNecron(NecronType.NecronWarrior));
army.Add(tombWorld.AwakenNecron(NecronType.NecronWarrior));
army.Add(tombWorld.AwakenNecron(NecronType.SkorpekhDestroyer));
army.Add(tombWorld.AwakenNecron(NecronType.SkorpekhDestroyer));
army.Add(tombWorld.AwakenNecron(NecronType.TombBlade));
foreach(INecron necron in army)
{
    Console.WriteLine(necron.GetDetails());
}
Console.WriteLine();

Console.WriteLine("Proxy:");
SpiceHarvester harvester070 = new(070);
SpiceHarvester harvester227 = new(227);
SpiceHarvester harvester471 = new(471);
SpiceHarvester harvester770 = new(770);
SpiceHarvester harvester886 = new(886);
ISpiceDeposit dune = new ProxySandDune(new SandDune());
dune.Enter(harvester070);
dune.Enter(harvester227);
dune.Enter(harvester471);
dune.Enter(harvester770);
dune.Enter(harvester886);
dune.Exit(harvester070);
dune.Enter(harvester886);
dune.Enter(harvester227);
Console.WriteLine();