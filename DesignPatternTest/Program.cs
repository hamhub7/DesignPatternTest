using DesignPatternTest.Behavioral.Observer;
using DesignPatternTest.Behavioral.Strategy;
using DesignPatternTest.Creational.AbstractFactory;
using DesignPatternTest.Creational.Builder;
using DesignPatternTest.Creational.FactoryMethod;
using DesignPatternTest.Creational.Prototype;
using DesignPatternTest.Creational.Singleton;
using DesignPatternTest.Structural.Adapter;
using DesignPatternTest.Structural.Bridge;
using DesignPatternTest.Structural.Decorator;
using DesignPatternTest.Structural.Facade;
using DesignPatternTest.Structural.Flyweight;
using DesignPatternTest.Structural.Proxy;

Console.WriteLine("Singleton:");
TheWarp.Instance.DrawPower(10);
TheWarp.Instance.DrawPower(15);
TheWarp.Instance.DrawPower(20);
Console.WriteLine();
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
Console.WriteLine();


Console.WriteLine("Builder:");
Vehicle vehicle = new Vehicle.Builder().WithFrame(VehicleFrame.WildWiggler).WithWheels(VehicleWheels.Roller).WithGlider(VehicleGlider.CloudGlider).Build();
Console.WriteLine("Frame: " + vehicle.frame);
Console.WriteLine("Wheels: " + vehicle.wheels);
Console.WriteLine("Glider: " + vehicle.glider);
Console.WriteLine();
Console.WriteLine();


Console.WriteLine("Factory Method:");
IMobSpawner mobSpawner = new ZombieSpawner();
IMob mob = mobSpawner.SpawnMob();
Console.WriteLine("Spawned " + mob.GetMobType());
mobSpawner = new CreeperSpawner();
mob = mobSpawner.SpawnMob();
Console.WriteLine("Spawned " + mob.GetMobType());
Console.WriteLine();
Console.WriteLine();


Console.WriteLine("Prototype:");
IPrototype jangoFett = new CloneHost(1.83f, 79, "Human");
CloneHost clone = (CloneHost)jangoFett.Clone();
Console.WriteLine("Height: " + clone.height + "m");
Console.WriteLine("Weight: " + clone.weight + "kg");
Console.WriteLine("Species: " + clone.species);
Console.WriteLine();
Console.WriteLine();


Console.WriteLine("Adapter:");
Console.WriteLine("Xbox with proper controller");
XboxController xboxController = new(new XboxSeriesS());
xboxController.PressAllButtons();
Console.WriteLine("Playstation with proper controller");
PlaystationController playstationController = new(new PS5());
playstationController.PressAllButtons();
Console.WriteLine("Xbox with Playstation controller");
PlaystationController adaptedPlaystationController = new(new XboxToPlaystationControllerAdapter(new XboxSeriesS()));
adaptedPlaystationController.PressAllButtons();
Console.WriteLine("Playstation with Xbox controller");
XboxController adaptedXboxController = new(new PlaystationToXboxControllerAdapter(new PS5()));
adaptedXboxController.PressAllButtons();
Console.WriteLine();
Console.WriteLine();


Console.WriteLine("Bridge:");
IInfernalWeapon stygianBlade = new StygianBlade(new ZeusBoon());
stygianBlade.Attack();
stygianBlade.Special();
IInfernalWeapon shieldOfChaos = new ShieldOfChaos(new AresBoon());
shieldOfChaos.Attack();
shieldOfChaos.Special();
Console.WriteLine();
Console.WriteLine();


Console.WriteLine("Composite:");
Console.WriteLine();
Console.WriteLine();


Console.WriteLine("Decorator:");
IIronManArmor armor = new MarkL();
armor = new ThrusterUpgrades(armor);
Console.Write(armor.GetDetails());
Console.WriteLine("Speed: " + armor.GetSpeed());
Console.WriteLine("Attack Power: " + armor.GetAttackPower());
Console.WriteLine();
Console.WriteLine();


Console.WriteLine("Facade:");
FrostpunkFacade frostpunkFacade = new();
frostpunkFacade.Dawn();
frostpunkFacade.WorkDay();
frostpunkFacade.Dusk();
Console.WriteLine();
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
Console.WriteLine();


Console.WriteLine("Chain of Responsibility:");
Console.WriteLine();
Console.WriteLine();


Console.WriteLine("Command:");
Console.WriteLine();
Console.WriteLine();


Console.WriteLine("Interpreter:");
Console.WriteLine();
Console.WriteLine();


Console.WriteLine("Iterator:");
Console.WriteLine();
Console.WriteLine();


Console.WriteLine("Mediator:");
Console.WriteLine();
Console.WriteLine();


Console.WriteLine("Memento:");
Console.WriteLine();
Console.WriteLine();


Console.WriteLine("Observer:");
Hitman agent47 = new();
Guard guard = new();
guard.Register(agent47);
Console.WriteLine("Guard's last seen action: " + guard.ObservedAction);
agent47.ActSuspicious("Grab knife");
Console.WriteLine("Guard's last seen action: " + guard.ObservedAction);
agent47.ActSuspicious("Stab civilian");
Console.WriteLine("Guard's last seen action: " + guard.ObservedAction);
Console.WriteLine();
Console.WriteLine();


Console.WriteLine("State:");
Console.WriteLine();
Console.WriteLine();


Console.WriteLine("Strategy:");
IPersonaUser joker = new Joker();
joker.Attack(new MeleeAttack());
joker.Attack(new GunAttack());
joker.Attack(new PersonaAttack(new Eiha()));
joker.Attack(new PersonaAttack(new Cleave()));
Console.WriteLine();
Console.WriteLine();


Console.WriteLine("Template Method:");
Console.WriteLine();
Console.WriteLine();


Console.WriteLine("Visitor:");
Console.WriteLine();
Console.WriteLine();