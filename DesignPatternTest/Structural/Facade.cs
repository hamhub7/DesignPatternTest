using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest.Structural.Facade
{
    public interface IWorkerBuilding
    {
        string GetName();
    }

    public interface IEngineerBuilding
    {
        string GetName();
    }

    public class Sawmill : IWorkerBuilding, IEngineerBuilding
    {
        public string GetName() => "Sawmill";
    }

    public class HuntersHut : IWorkerBuilding
    {
        public string GetName() => "Hunter's Hut";
    }

    public class Workshop : IEngineerBuilding
    {
        public string GetName() => "Workshop";
    }

    public abstract class Citizen
    {
        public abstract string GetName();

        public void WakeUp()
        {
            Console.WriteLine($"{GetName()} wakes up");
        }

        public void GoToSleep()
        {
            Console.WriteLine($"{GetName()} goes to sleep");
        }

        public void GoToWork()
        {
            Console.WriteLine($"{GetName()} goes to work");
        }

        public void GoHome()
        {
            Console.WriteLine($"{GetName()} goes home");
        }

        private void DoJob(Job job)
        {
            switch (job)
            {
                case Job.WakeUp:
                    WakeUp();
                    break;
                case Job.GoToSleep:
                    GoToSleep();
                    break;
                case Job.GoToWork:
                    GoToWork();
                    break;
                case Job.GoHome:
                    GoHome();
                    break;
                case Job.Work:
                    Work();
                    break;
                default: throw new ArgumentException("Job not supported", nameof(job));
            }
        }

        public void DoJob(params Job[] jobs)
        {
            jobs.ToList().ForEach(job => DoJob(job));
        }

        public abstract void Work();

        public enum Job
        {
            WakeUp,
            GoToSleep,
            GoToWork,
            GoHome,
            Work,
        }
    }

    public class Worker : Citizen
    {
        private readonly string name;
        private readonly IWorkerBuilding building;

        public Worker(string name, IWorkerBuilding building)
        {
            this.name = name;
            this.building = building;
        }

        public override string GetName()
        {
            return name;
        }

        public override void Work()
        {
            Console.WriteLine($"{GetName()} does rudimentary work at the {building.GetName()}");
        }
    }

    public class Engineer : Citizen
    {
        private readonly string name;
        private readonly IEngineerBuilding building;

        public Engineer(string name, IEngineerBuilding building)
        {
            this.name = name;
            this.building = building;
        }

        public override string GetName()
        {
            return name;
        }

        public override void Work()
        {
            Console.WriteLine($"{GetName()} does advanced work at the {building.GetName()}");
        }
    }

    public class FrostpunkFacade
    {
        private readonly List<Citizen> employees = new()
        {
            new Worker("Paul Allen", new Sawmill()),
            new Worker("Patrick Bateman", new HuntersHut()),
            new Engineer("Evelyn Williams", new Sawmill()),
            new Engineer("Craig McDermott", new Workshop()),
        };

        public void Dawn()
        {
            MakeActions(employees, Citizen.Job.WakeUp, Citizen.Job.GoToWork);
        }

        public void WorkDay()
        {
            MakeActions(employees, Citizen.Job.Work);
        }

        public void Dusk()
        {
            MakeActions(employees, Citizen.Job.GoHome, Citizen.Job.GoToSleep);
        }

        private static void MakeActions(List<Citizen> employees, params Citizen.Job[] jobs)
        {
            employees.ForEach(e => e.DoJob(jobs));
        }
    }
}
