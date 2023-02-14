using DesignPatternTest.Creational.AbstractFactory;
using DesignPatternTest.Creational.Builder;
using DesignPatternTest.Creational.FactoryMethod;
using DesignPatternTest.Creational.Prototype;
using DesignPatternTest.Creational.Singleton;

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